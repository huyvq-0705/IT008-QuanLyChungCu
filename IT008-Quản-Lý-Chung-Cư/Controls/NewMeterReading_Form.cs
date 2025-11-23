using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class NewMeterReading_Form : Form
    {
        private int _unitId;
        private int _staffId;
        private bool _isEditMode = false;
        private DateTime _editDate;

        // Constructor for ADDING
        public NewMeterReading_Form(int unitId, string unitCode, int staffId)
        {
            InitializeComponent();
            _unitId = unitId;
            _staffId = staffId;
            this.Text = $"Add Readings for {unitCode}";
            dtpMonth.Value = DateTime.Now.AddMonths(-1);
        }

        // Constructor for EDITING
        public NewMeterReading_Form(int unitId, string unitCode, int staffId, DateTime monthToEdit, decimal currentElec, decimal currentWater)
            : this(unitId, unitCode, staffId)
        {
            _isEditMode = true;
            _editDate = monthToEdit;

            this.Text = $"Edit Readings for {unitCode}";
            lblTitle.Text = "Edit Meter Reading";
            btnSave.Text = "UPDATE";

            // Lock the date picker so they can't change the month during edit (keeps logic simple)
            dtpMonth.Value = monthToEdit;
            dtpMonth.Enabled = false;

            txtElec.Text = currentElec.ToString("0.###");
            txtWater.Text = currentWater.ToString("0.###");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtElec.Text, out decimal elec) || elec < 0) { MessageBox.Show("Invalid Electricity."); return; }
            if (!decimal.TryParse(txtWater.Text, out decimal water) || water < 0) { MessageBox.Show("Invalid Water."); return; }

            DateTime period = new DateTime(dtpMonth.Value.Year, dtpMonth.Value.Month, 1);

            try
            {
                using (var conn = Db.Open())
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (_isEditMode)
                        {
                            // UPDATE Logic
                            string sql = "UPDATE meter_reading SET consumption = @consump, recorded_by_staff_id = @staff, updated_at = now() WHERE unit_id = @uid AND tariff_type = @type AND period_month = @period";

                            // Update Electricity
                            using (var cmd = new NpgsqlCommand(sql, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@consump", elec);
                                cmd.Parameters.AddWithValue("@staff", _staffId);
                                cmd.Parameters.AddWithValue("@uid", _unitId);
                                cmd.Parameters.AddWithValue("@type", "ELECTRICITY");
                                cmd.Parameters.AddWithValue("@period", _editDate);
                                cmd.ExecuteNonQuery();
                            }
                            // Update Water
                            using (var cmd = new NpgsqlCommand(sql, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@consump", water);
                                cmd.Parameters.AddWithValue("@staff", _staffId);
                                cmd.Parameters.AddWithValue("@uid", _unitId);
                                cmd.Parameters.AddWithValue("@type", "WATER");
                                cmd.Parameters.AddWithValue("@period", _editDate);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // INSERT Logic (Original)
                            string sql = "INSERT INTO meter_reading (unit_id, tariff_type, period_month, consumption, recorded_by_staff_id) VALUES (@uid, @type, @period, @consump, @staff)";

                            using (var cmd = new NpgsqlCommand(sql, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@uid", _unitId);
                                cmd.Parameters.AddWithValue("@type", "ELECTRICITY");
                                cmd.Parameters.AddWithValue("@period", period);
                                cmd.Parameters.AddWithValue("@consump", elec);
                                cmd.Parameters.AddWithValue("@staff", _staffId);
                                cmd.ExecuteNonQuery();
                            }
                            using (var cmd = new NpgsqlCommand(sql, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@uid", _unitId);
                                cmd.Parameters.AddWithValue("@type", "WATER");
                                cmd.Parameters.AddWithValue("@period", period);
                                cmd.Parameters.AddWithValue("@consump", water);
                                cmd.Parameters.AddWithValue("@staff", _staffId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        tran.Commit();
                        MessageBox.Show("Saved successfully!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (PostgresException pex) when (pex.SqlState == "23505")
                    {
                        tran.Rollback();
                        MessageBox.Show($"Readings for {period:MM/yyyy} already exist.");
                    }
                    catch (Exception) { tran.Rollback(); throw; }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}