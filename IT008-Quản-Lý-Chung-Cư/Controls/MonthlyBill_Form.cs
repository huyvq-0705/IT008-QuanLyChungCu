using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class MonthlyBill_Form : Form
    {
        public class UnitItem { public int Id; public string Code; public decimal Rent; public override string ToString() => Code; }

        private int _staffId;
        private int? _billId = null;
        private decimal _elecRate = 0;
        private decimal _waterRate = 0;

        private TrackBar trackStatus;
        private Label lblStatusDisplay;
        private Label lblStatusTitle;

        public MonthlyBill_Form(int staffId)
        {
            InitializeComponent();
            _staffId = staffId;

            ApplyDynamicSize();

            SetupSlider();
            LoadTariffs();
            LoadUnits();

            CenterContent();

            txtElecUsage.KeyPress += AllowOnlyNumbersAndDecimal;
            txtWaterUsage.KeyPress += AllowOnlyNumbersAndDecimal;
            txtAdjust.KeyPress += AllowOnlyNumbersDecimalAndNegative;
        }

        public MonthlyBill_Form(int staffId, int billId) : this(staffId)
        {
            _billId = billId;
            this.Text = "Edit Monthly Bill";
            lblTitle.Text = "Edit Monthly Bill";
            btnSave.Text = "UPDATE BILL";
            LoadBillData();
        }

        private void ApplyDynamicSize()
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int newWidth = (int)(screen.Width * 0.75);
            int newHeight = (int)(screen.Height * 0.75);

            this.Size = new Size(newWidth, newHeight);
            this.CenterToScreen();
        }

        private void CenterContent()
        {
            int centerX = (this.pnlMain.Width - groupBox1.Width) / 2;

            label1.Left = centerX;
            cbUnit.Left = centerX;
            label2.Left = centerX + 240;
            dtpMonth.Left = centerX + 240;

            groupBox1.Left = centerX;
            groupBox2.Left = centerX;
            groupBox3.Left = centerX;
            pnlSummary.Left = centerX;
        }

        private void SetupSlider()
        {
            int sliderX = pnlSummary.Left + 120;
            int sliderY = pnlSummary.Bottom + 20;

            lblStatusTitle = new Label();
            lblStatusTitle.Text = "Payment Status:";
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.Font = new Font("Arial", 10F, FontStyle.Regular);
            lblStatusTitle.ForeColor = Color.Gray;
            lblStatusTitle.Location = new Point(pnlSummary.Left + 15, sliderY + 5);
            pnlMain.Controls.Add(lblStatusTitle);

            trackStatus = new TrackBar();
            trackStatus.Minimum = 0;
            trackStatus.Maximum = 1;
            trackStatus.Value = 0;
            trackStatus.TickStyle = TickStyle.None;
            trackStatus.AutoSize = false;
            trackStatus.Size = new Size(50, 30);
            trackStatus.Location = new Point(lblStatusTitle.Right + 10, sliderY + 2);
            trackStatus.ValueChanged += (s, e) => UpdateStatusLabel();
            pnlMain.Controls.Add(trackStatus);

            lblStatusDisplay = new Label();
            lblStatusDisplay.AutoSize = true;
            lblStatusDisplay.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblStatusDisplay.Location = new Point(trackStatus.Right + 5, sliderY + 5);
            pnlMain.Controls.Add(lblStatusDisplay);

            UpdateStatusLabel();
        }

        private void UpdateStatusLabel()
        {
            if (trackStatus.Value == 1)
            {
                lblStatusDisplay.Text = "PAID";
                lblStatusDisplay.ForeColor = Color.SeaGreen;
            }
            else
            {
                lblStatusDisplay.Text = "UNPAID";
                lblStatusDisplay.ForeColor = Color.OrangeRed;
            }
        }

        private void LoadBillData()
        {
            try
            {
                using (var conn = Db.Open())
                {
                    string sql = @"SELECT unit_id, period_month, rent_amount, electricity_amount, water_amount, adjustments, status
                                     FROM monthly_bill WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _billId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int unitId = reader.GetInt32(0);
                                dtpMonth.Value = reader.GetDateTime(1);
                                txtRent.Text = reader.GetDecimal(2).ToString("N0");
                                txtElecTotal.Text = reader.GetDecimal(3).ToString("N0");
                                txtWaterTotal.Text = reader.GetDecimal(4).ToString("N0");
                                txtAdjust.Text = reader.GetDecimal(5).ToString("0");
                                string status = reader.GetString(6);

                                trackStatus.Value = (status == "PAID") ? 1 : 0;
                                UpdateStatusLabel();

                                foreach (UnitItem item in cbUnit.Items)
                                {
                                    if (item.Id == unitId) { cbUnit.SelectedItem = item; break; }
                                }

                                cbUnit.Enabled = false;
                                dtpMonth.Enabled = false;
                            }
                        }
                    }
                }
                CalculateTotal();
            }
            catch (Exception ex) { MessageBox.Show("Error loading bill: " + ex.Message); }
        }

        private void LoadUnits()
        {
            try
            {
                using (var conn = Db.Open())
                {
                    string sql = "SELECT id, unit_code, monthly_rent FROM unit WHERE status = 'OCCUPIED' AND is_deleted = FALSE ORDER BY unit_code";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbUnit.Items.Add(new UnitItem { Id = reader.GetInt32(0), Code = reader.GetString(1), Rent = reader.GetDecimal(2) });
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error units: " + ex.Message); }
        }

        private void LoadTariffs()
        {
            try
            {
                using (var conn = Db.Open())
                {
                    string sql = "SELECT name, rate_per_unit FROM tariff";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            decimal rate = reader.GetDecimal(1);
                            if (name == "ELECTRICITY") _elecRate = rate;
                            if (name == "WATER") _waterRate = rate;
                        }
                    }
                }
                lblElecRate.Text = $"Rate: {_elecRate:N0}";
                lblWaterRate.Text = $"Rate: {_waterRate:N0}";
            }
            catch { }
        }

        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUnit.SelectedItem is UnitItem selectedUnit)
            {
                txtRent.Text = selectedUnit.Rent.ToString("N0");
                FetchAndFillMeterReadings(selectedUnit.Id, dtpMonth.Value);
            }
        }

        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {
            if (cbUnit.SelectedItem is UnitItem selectedUnit)
            {
                FetchAndFillMeterReadings(selectedUnit.Id, dtpMonth.Value);
            }
        }

        private void FetchAndFillMeterReadings(int unitId, DateTime selectedMonth)
        {
            try
            {
                using (var conn = Db.Open())
                {
                    string sql = @"
                SELECT tariff_type, consumption
                FROM meter_reading
                WHERE unit_id = @unitId AND period_month = @month";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@unitId", unitId);
                        cmd.Parameters.AddWithValue("@month", new DateTime(selectedMonth.Year, selectedMonth.Month, 1));

                        using (var reader = cmd.ExecuteReader())
                        {
                            decimal electricity = 0;
                            decimal water = 0;

                            while (reader.Read())
                            {
                                string tariffType = reader.GetString(0);
                                decimal consumption = reader.GetDecimal(1);

                                if (tariffType == "ELECTRICITY")
                                {
                                    electricity = consumption;
                                }
                                else if (tariffType == "WATER")
                                {
                                    water = consumption;
                                }
                            }

                            // Populate the fields with the fetched values
                            txtElecUsage.Text = electricity > 0 ? electricity.ToString("0.###") : string.Empty;
                            txtWaterUsage.Text = water > 0 ? water.ToString("0.###") : string.Empty;

                            // Trigger calculation of total
                            CalculateTotal();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching meter readings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotal(object sender = null, EventArgs e = null)
        {
            decimal.TryParse(txtRent.Text.Replace(",", ""), out decimal rent);
            decimal.TryParse(txtElecUsage.Text, out decimal elecUsage);
            decimal.TryParse(txtWaterUsage.Text, out decimal waterUsage);
            decimal.TryParse(txtAdjust.Text, out decimal adjust);

            decimal elecVal = elecUsage * _elecRate;
            decimal waterVal = waterUsage * _waterRate;

            if (_billId != null && elecUsage == 0 && !string.IsNullOrEmpty(txtElecTotal.Text))
                decimal.TryParse(txtElecTotal.Text.Replace(",", ""), out elecVal);
            else txtElecTotal.Text = elecVal.ToString("N0");

            if (_billId != null && waterUsage == 0 && !string.IsNullOrEmpty(txtWaterTotal.Text))
                decimal.TryParse(txtWaterTotal.Text.Replace(",", ""), out waterVal);
            else txtWaterTotal.Text = waterVal.ToString("N0");

            decimal total = rent + elecVal + waterVal + adjust;
            lblTotalAmount.Text = $"{total:N0} VND";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbUnit.SelectedItem == null && _billId == null) { MessageBox.Show("Select unit"); return; }

            try
            {
                using (var conn = Db.Open())
                {
                    string status = (trackStatus.Value == 1) ? "PAID" : "UNPAID";
                    string sql;

                    if (_billId == null)
                    {
                        sql = @"INSERT INTO monthly_bill
                            (unit_id, period_month, rent_amount, electricity_amount, water_amount, adjustments, total_amount, created_by_staff_id, status)
                            VALUES (@uid, @period, @rent, @elec, @water, @adj, @total, @staff, @status)";
                    }
                    else
                    {
                        sql = @"UPDATE monthly_bill
                                 SET adjustments=@adj, total_amount=@total, status=@status, updated_at=now()
                                 WHERE id=@id";
                    }

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        decimal.TryParse(txtElecTotal.Text.Replace(",", ""), out decimal elec);
                        decimal.TryParse(txtWaterTotal.Text.Replace(",", ""), out decimal water);
                        decimal.TryParse(txtAdjust.Text, out decimal adj);
                        decimal.TryParse(lblTotalAmount.Text.Replace(" VND", "").Replace(",", ""), out decimal total);

                        cmd.Parameters.AddWithValue("@adj", adj);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@staff", _staffId);

                        if (_billId == null)
                        {
                            UnitItem u = (UnitItem)cbUnit.SelectedItem;
                            DateTime p = dtpMonth.Value;
                            cmd.Parameters.AddWithValue("@uid", u.Id);
                            cmd.Parameters.AddWithValue("@period", new DateTime(p.Year, p.Month, 1));
                            cmd.Parameters.AddWithValue("@rent", u.Rent);
                            cmd.Parameters.AddWithValue("@elec", elec);
                            cmd.Parameters.AddWithValue("@water", water);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@id", _billId);
                        }

                        cmd.ExecuteNonQuery();
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void AllowOnlyNumbersAndDecimal(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                if (((TextBox)sender).Text.Contains(e.KeyChar))
                {
                    e.Handled = true;
                }
                return;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            e.Handled = true;
        }

        private void AllowOnlyNumbersDecimalAndNegative(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            if (e.KeyChar.ToString() == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
            {
                if (((TextBox)sender).Text.Contains(e.KeyChar))
                {
                    e.Handled = true;
                }
                return;
            }

            if (e.KeyChar == '-')
            {
                if (((TextBox)sender).Text.Length == 0)
                {
                    return;
                }
            }

            e.Handled = true;
        }
    }
}