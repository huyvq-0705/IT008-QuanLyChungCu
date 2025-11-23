using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

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

                                // Key must allow retrieving the original Date object later
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
            Panel p = new Panel();
            p.Size = new Size(700, 50);
            p.Margin = new Padding(0, 0, 0, 10);
            p.BackColor = Color.WhiteSmoke; // Slight bg to distinguish rows

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            lbl.Location = new Point(10, 12);
            lbl.Text = $"MONTH: {data.Date:MMMM yyyy}  |  ELEC: {data.Elec:N0} KWH  |  WATER: {data.Water:N0} M3";
            p.Controls.Add(lbl);

            Button btnEdit = new Button();
            btnEdit.Text = "EDIT";
            btnEdit.Size = new Size(80, 30);
            btnEdit.Location = new Point(600, 10);
            btnEdit.BackColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Cursor = Cursors.Hand;

            // Pass data to Edit Form
            btnEdit.Click += (s, e) =>
            {
                NewMeterReading_Form f = new NewMeterReading_Form(_unitId, _unitCode, _staffId, data.Date, data.Elec, data.Water);
                if (f.ShowDialog() == DialogResult.OK) LoadHistory();
            };
            p.Controls.Add(btnEdit);

            return p;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            NewMeterReading_Form form = new NewMeterReading_Form(_unitId, _unitCode, _staffId);
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