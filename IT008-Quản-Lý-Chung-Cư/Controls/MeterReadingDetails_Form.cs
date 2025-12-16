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
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private Panel CreateHistoryItem(MonthlyReadingDisplay data)
        {
            Guna2Panel p = new Guna2Panel();
            p.Size = new Size(950, 60);
            p.Margin = new Padding(0, 0, 0, 10);
            p.FillColor = Color.FromArgb(245, 248, 250);
            p.BorderRadius = 8;
            p.ShadowDecoration.Enabled = true;
            p.ShadowDecoration.Depth = 5;
            p.ShadowDecoration.BorderRadius = 8;

            Guna2HtmlLabel lbl = new Guna2HtmlLabel();
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Arial", 12F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(44, 62, 80);
            lbl.Location = new Point(20, 15);
            lbl.Text = $"MONTH: {data.Date:MM/yyyy} | ELECTRICITY: {data.Elec:N0} KWH | WATER: {data.Water:N0} M³";
            p.Controls.Add(lbl);

            Guna2Button btnEdit = new Guna2Button();
            btnEdit.Text = "EDIT";
            btnEdit.Size = new Size(120, 40);
            btnEdit.Location = new Point(800, 10);
            btnEdit.FillColor = Color.FromArgb(52, 152, 219);
            btnEdit.ForeColor = Color.White;
            btnEdit.BorderRadius = 6;
            btnEdit.Cursor = Cursors.Hand;

            btnEdit.Click += (s, e) =>
            {
                Form f = new NewMeterReading_Form(_unitId, _unitCode, _staffId, data.Date, data.Elec, data.Water);
                if (f.ShowDialog() == DialogResult.OK) LoadHistory();
            };
            p.Controls.Add(btnEdit);

            return p;
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