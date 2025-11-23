using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Npgsql;

namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class NewHousehold_Form : Form
    {
        // Simple class to hold dropdown data
        public class UnitItem
        {
            public int Id { get; set; }
            public string Code { get; set; }
            public override string ToString() => Code;
        }

        public NewHousehold_Form()
        {
            InitializeComponent();
            LoadVacantUnits();
        }

        private void LoadVacantUnits()
        {
            try
            {
                cbUnits.Items.Clear();
                using (var conn = Db.Open())
                {
                    // Only select units that are VACANT and not deleted
                    string sql = "SELECT id, unit_code FROM unit WHERE status = 'VACANT' AND is_deleted = FALSE ORDER BY unit_code";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbUnits.Items.Add(new UnitItem
                            {
                                Id = reader.GetInt32(0),
                                Code = reader.GetString(1)
                            });
                        }
                    }
                }

                if (cbUnits.Items.Count > 0)
                    cbUnits.SelectedIndex = 0;
                else
                {
                    MessageBox.Show("No vacant units available! Please add more units or check status.");
                    btnSave.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading units: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbUnits.SelectedItem == null)
            {
                MessageBox.Show("Please select a Unit.");
                return;
            }

            var selectedUnit = (UnitItem)cbUnits.SelectedItem;

            try
            {
                using (var conn = Db.Open())
                {
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Insert into Household
                            string sqlHousehold = @"
                                INSERT INTO household (unit_id, start_date, note)
                                VALUES (@uid, @start, @note)";

                            using (var cmd = new NpgsqlCommand(sqlHousehold, conn))
                            {
                                cmd.Parameters.AddWithValue("@uid", selectedUnit.Id);
                                cmd.Parameters.AddWithValue("@start", dtpStart.Value);
                                cmd.Parameters.AddWithValue("@note", txtNote.Text.Trim());
                                cmd.ExecuteNonQuery();
                            }

                            // 2. Update Unit status to OCCUPIED
                            string sqlUnit = "UPDATE unit SET status = 'OCCUPIED' WHERE id = @uid";
                            using (var cmd = new NpgsqlCommand(sqlUnit, conn))
                            {
                                cmd.Parameters.AddWithValue("@uid", selectedUnit.Id);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show("Household created successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating household: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}