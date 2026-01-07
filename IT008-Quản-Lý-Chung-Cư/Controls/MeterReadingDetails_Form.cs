using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using Guna.UI2.WinForms;

namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class MeterReadingDetails_Form : Form
    {
        private int _unitId;
        private int _staffId;
        private string _unitCode;

        public MeterReadingDetails_Form(int unitId, string unitCode, int staffId)
        {
            InitializeComponent();
            _unitId = unitId;
            _unitCode = unitCode;
            _staffId = staffId;
            lblUnitCode.Text = $"UNIT_CODE: {_unitCode}";
            LoadHistory();
        }

        private void LoadHistory()
        {
            pnlHistory.Controls.Clear();
            try
            {
                var monthlyData = new Dictionary<string, MonthlyReadingDisplay>();

                using (var conn = Db.Open())
                {
                    string sql = "SELECT tariff_type, period_month, consumption FROM meter_reading WHERE unit_id = @uid ORDER BY period_month DESC";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", _unitId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string type = reader.GetString(0);
                                DateTime date = reader.GetDateTime(1);
                                decimal consumption = reader.GetDecimal(2);

                                string key = date.ToString("yyyy-MM-dd");

                                if (!monthlyData.ContainsKey(key))
                                    monthlyData[key] = new MonthlyReadingDisplay { Date = date };

                                if (type == "ELECTRICITY") monthlyData[key].Elec = consumption;
                                else if (type == "WATER") monthlyData[key].Water = consumption;
                            }
                        }
                    }
                }

                // Create UI for each month
                foreach (var entry in monthlyData.Values)
                {
                    pnlHistory.Controls.Add(CreateHistoryItem(entry));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel CreateHistoryItem(MonthlyReadingDisplay data)
        {
            Guna2Panel p = new Guna2Panel();
            p.Size = new Size(950, 70);
            p.Margin = new Padding(0, 0, 0, 12);
            p.FillColor = Color.White;
            p.BorderRadius = 10;
            p.ShadowDecoration.Enabled = true;
            p.ShadowDecoration.Depth = 8;
            p.ShadowDecoration.BorderRadius = 10;
            p.ShadowDecoration.Color = Color.FromArgb(200, 200, 200);

            Guna2HtmlLabel lbl = new Guna2HtmlLabel();
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Arial", 11F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(44, 62, 80);
            lbl.Location = new Point(25, 25);
            lbl.Text = $"MONTH: {data.Date:MM/yyyy} | ELECTRICITY: {data.Elec:N0} KWH | WATER: {data.Water:N0} M³";
            p.Controls.Add(lbl);

            // Edit button
            Guna2Button btnEdit = new Guna2Button();
            btnEdit.Text = "EDIT";
            btnEdit.Size = new Size(100, 45);
            btnEdit.Location = new Point(p.Width - 120, 13);
            btnEdit.FillColor = Color.FromArgb(52, 152, 219);
            btnEdit.ForeColor = Color.White;
            btnEdit.BorderRadius = 8;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnEdit.Click += (s, e) =>
            {
                Form f = new NewMeterReading_Form(_unitId, _unitCode, _staffId, data.Date, data.Elec, data.Water);
                if (f.ShowDialog() == DialogResult.OK) LoadHistory();
            };
            p.Controls.Add(btnEdit);

            // Delete button
            Guna2Button btnDelete = new Guna2Button();
            btnDelete.Text = "DEL";
            btnDelete.Size = new Size(70, 45);
            btnDelete.Location = new Point(p.Width - 205, 13);
            btnDelete.FillColor = Color.FromArgb(231, 76, 60);
            btnDelete.ForeColor = Color.White;
            btnDelete.BorderRadius = 8;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnDelete.Click += (s, e) => DeleteMeterReading(data.Date);
            p.Controls.Add(btnDelete);

            return p;
        }

        private void DeleteMeterReading(DateTime periodMonth)
        {
            if (MessageBox.Show(
                $"Are you sure you want to delete the meter readings for {periodMonth:MM/yyyy}?\n\nThis will delete both ELECTRICITY and WATER readings for this month.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (var conn = Db.Open())
                    {
                        // Delete both electricity and water readings for this period
                        string sql = "DELETE FROM meter_reading WHERE unit_id = @uid AND period_month = @period";
                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@uid", _unitId);
                            cmd.Parameters.AddWithValue("@period", periodMonth.Date);
                            int rowsDeleted = cmd.ExecuteNonQuery();

                            if (rowsDeleted > 0)
                            {
                                MessageBox.Show(
                                    $"Successfully deleted {rowsDeleted} meter reading(s) for {periodMonth:MM/yyyy}.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                    LoadHistory(); // Refresh the list
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error deleting meter reading: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form form = new NewMeterReading_Form(_unitId, _unitCode, _staffId);
            if (form.ShowDialog() == DialogResult.OK) LoadHistory();
        }

        private void lblReturn_Click(object sender, EventArgs e) => this.Close();

        private class MonthlyReadingDisplay
        {
            public DateTime Date { get; set; }
            public decimal Elec { get; set; }
            public decimal Water { get; set; }
        }
    }
}