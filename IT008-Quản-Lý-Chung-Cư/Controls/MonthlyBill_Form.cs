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

        private Panel pnlToggle;
        private Panel pnlToggleSlider;
        private Label lblStatusDisplay;
        private Label lblStatusTitle;
        private bool _isPaid = false;

        public MonthlyBill_Form(int staffId)
        {
            InitializeComponent();
            _staffId = staffId;

            ApplyDynamicSize();

            SetupModernToggle();
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

        private void SetupModernToggle()
        {
            int toggleY = pnlSummary.Bottom + 30;

            // Status Title Label
            lblStatusTitle = new Label();
            lblStatusTitle.Text = "Payment Status:";
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.Font = new Font("Arial", 11F, FontStyle.Regular);
            lblStatusTitle.ForeColor = Color.FromArgb(80, 80, 80);
            lblStatusTitle.Location = new Point(pnlSummary.Left + 20, toggleY + 8);
            pnlMain.Controls.Add(lblStatusTitle);

            // Toggle Background Panel
            pnlToggle = new Panel();
            pnlToggle.Size = new Size(60, 30);
            pnlToggle.Location = new Point(lblStatusTitle.Right + 15, toggleY);
            pnlToggle.BackColor = Color.FromArgb(220, 220, 220);
            pnlToggle.Cursor = Cursors.Hand;
            pnlToggle.Click += ToggleStatus;
            pnlMain.Controls.Add(pnlToggle);

            // Toggle Slider (the circle that moves)
            pnlToggleSlider = new Panel();
            pnlToggleSlider.Size = new Size(26, 26);
            pnlToggleSlider.Location = new Point(2, 2);
            pnlToggleSlider.BackColor = Color.White;
            pnlToggleSlider.Cursor = Cursors.Hand;
            pnlToggleSlider.Click += ToggleStatus;
            pnlToggle.Controls.Add(pnlToggleSlider);

            // Round the corners
            System.Drawing.Drawing2D.GraphicsPath pathToggle = new System.Drawing.Drawing2D.GraphicsPath();
            pathToggle.AddEllipse(0, 0, pnlToggle.Height, pnlToggle.Height);
            pathToggle.AddEllipse(pnlToggle.Width - pnlToggle.Height, 0, pnlToggle.Height, pnlToggle.Height);
            pathToggle.AddRectangle(new Rectangle(pnlToggle.Height / 2, 0, pnlToggle.Width - pnlToggle.Height, pnlToggle.Height));
            pnlToggle.Region = new Region(pathToggle);

            System.Drawing.Drawing2D.GraphicsPath pathSlider = new System.Drawing.Drawing2D.GraphicsPath();
            pathSlider.AddEllipse(0, 0, pnlToggleSlider.Width, pnlToggleSlider.Height);
            pnlToggleSlider.Region = new Region(pathSlider);

            // Status Display Label
            lblStatusDisplay = new Label();
            lblStatusDisplay.AutoSize = true;
            lblStatusDisplay.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblStatusDisplay.Location = new Point(pnlToggle.Right + 15, toggleY + 8);
            pnlMain.Controls.Add(lblStatusDisplay);

            UpdateToggleDisplay();
        }

        private void ToggleStatus(object sender, EventArgs e)
        {
            _isPaid = !_isPaid;
            AnimateToggle();
            UpdateToggleDisplay();
        }

        private void AnimateToggle()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            int targetX = _isPaid ? (pnlToggle.Width - pnlToggleSlider.Width - 2) : 2;
            int step = _isPaid ? 2 : -2;

            timer.Tick += (s, e) =>
            {
                if ((_isPaid && pnlToggleSlider.Left >= targetX) || (!_isPaid && pnlToggleSlider.Left <= targetX))
                {
                    pnlToggleSlider.Left = targetX;
                    timer.Stop();
                    timer.Dispose();
                }
                else
                {
                    pnlToggleSlider.Left += step;
                }
            };

            timer.Start();
        }

        private void UpdateToggleDisplay()
        {
            if (_isPaid)
            {
                pnlToggle.BackColor = Color.FromArgb(46, 204, 113);
                lblStatusDisplay.Text = "PAID";
                lblStatusDisplay.ForeColor = Color.FromArgb(46, 204, 113);
            }
            else
            {
                pnlToggle.BackColor = Color.FromArgb(220, 220, 220);
                lblStatusDisplay.Text = "UNPAID";
                lblStatusDisplay.ForeColor = Color.FromArgb(231, 76, 60);
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

                                _isPaid = (status == "PAID");
                                pnlToggleSlider.Left = _isPaid ? (pnlToggle.Width - pnlToggleSlider.Width - 2) : 2;
                                UpdateToggleDisplay();

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

                            txtElecUsage.Text = electricity > 0 ? electricity.ToString("0.###") : string.Empty;
                            txtWaterUsage.Text = water > 0 ? water.ToString("0.###") : string.Empty;

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
                    string status = _isPaid ? "PAID" : "UNPAID";
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