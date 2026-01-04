using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    public partial class MonthlyBillListControl : UserControl
    {
        private int _staffId;
        private bool _filterThisMonth = false;

        public MonthlyBillListControl(int staffId)
        {
            InitializeComponent();
            _staffId = staffId;

            cmbFilter.SelectedIndex = 0; // ALL STATUS

            // Events
            this.Load += MonthlyBillListControl_Load;
            this.Resize += (s, e) => ResizeItems();
            cmbFilter.SelectedIndexChanged += (s, e) => LoadData();

            UpdateMonthToggleUI();
        }

        private void MonthlyBillListControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ResizeItems()
        {
            flowLayoutPanel1.SuspendLayout();
            int w = flowLayoutPanel1.ClientSize.Width - 30;

            foreach (Control c in flowLayoutPanel1.Controls)
                c.Width = w;

            flowLayoutPanel1.ResumeLayout();
        }

        public void LoadData()
        {
            flowLayoutPanel1.Controls.Clear();

            string selectedFilter = cmbFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedFilter))
                selectedFilter = "ALL STATUS";

            try
            {
                using (var conn = Db.Open())
                {
                    string sql = @"
                        SELECT b.id, u.unit_code, b.period_month, b.total_amount, b.status
                        FROM monthly_bill b
                        JOIN unit u ON b.unit_id = u.id
                        WHERE b.is_deleted = FALSE";

                    // Status filter
                    if (selectedFilter != "ALL STATUS")
                        sql += " AND b.status = @status";

                    // Month filter
                    if (_filterThisMonth)
                        sql += " AND b.period_month = @month";

                    sql += " ORDER BY b.period_month DESC, u.unit_code ASC";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        if (selectedFilter != "ALL STATUS")
                            cmd.Parameters.AddWithValue("@status", selectedFilter);

                        if (_filterThisMonth)
                        {
                            DateTime now = DateTime.Now;
                            cmd.Parameters.AddWithValue(
                                "@month",
                                new DateTime(now.Year, now.Month, 1)
                            );
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            flowLayoutPanel1.SuspendLayout();

                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string code = reader.GetString(1);
                                DateTime period = reader.GetDateTime(2);
                                decimal total = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                                string status = reader.GetString(4);

                                var item = CreateBillItem(id, code, period, total, status);
                                item.Width = flowLayoutPanel1.ClientSize.Width - 30;
                                flowLayoutPanel1.Controls.Add(item);
                            }

                            flowLayoutPanel1.ResumeLayout();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bills: " + ex.Message);
            }
        }

        private Panel CreateBillItem(int id, string code, DateTime period, decimal total, string status)
        {
            Panel p = new Panel
            {
                Height = 85,
                BackColor = Color.White,
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 0, 0, 15)
            };
            p.Click += (s, e) => OpenBill(id);

            Panel strip = new Panel
            {
                Width = 6,
                Dock = DockStyle.Left,
                BackColor = Color.FromArgb(52, 152, 219)
            };
            p.Controls.Add(strip);

            PictureBox icon = new PictureBox
            {
                Image = Properties.Resources.bill_icon,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(40, 40),
                Location = new Point(25, 22)
            };
            icon.Click += (s, e) => OpenBill(id);
            p.Controls.Add(icon);

            Label lblTitle = new Label
            {
                Text = $"Unit: {code}  |  Period: {period:MM/yyyy}",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                AutoSize = true,
                Location = new Point(80, 18)
            };
            lblTitle.Click += (s, e) => OpenBill(id);
            p.Controls.Add(lblTitle);

            Label lblAmount = new Label
            {
                Text = $"Total Amount: {total:N0} VND",
                Font = new Font("Arial", 10),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(80, 46)
            };
            lblAmount.Click += (s, e) => OpenBill(id);
            p.Controls.Add(lblAmount);

            Label lblStatus = new Label
            {
                Text = status,
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(p.Width - 120, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            if (status == "PAID")
                lblStatus.ForeColor = Color.SeaGreen;
            else if (status == "UNPAID")
                lblStatus.ForeColor = Color.FromArgb(231, 76, 60);
            else
                lblStatus.ForeColor = Color.Orange;

            lblStatus.Click += (s, e) => OpenBill(id);
            p.Controls.Add(lblStatus);

            return p;
        }

        private void OpenBill(int id)
        {
            MonthlyBill_Form form = new MonthlyBill_Form(_staffId, id);
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MonthlyBill_Form form = new MonthlyBill_Form(_staffId);
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnMonthToggle_Click(object sender, EventArgs e)
        {
            _filterThisMonth = !_filterThisMonth;
            UpdateMonthToggleUI();
            LoadData();
        }

        private void UpdateMonthToggleUI()
        {
            if (_filterThisMonth)
            {
                btnMonthToggle.Text = "THIS MONTH";
                btnMonthToggle.BackColor = Color.SteelBlue;
                btnMonthToggle.ForeColor = Color.White;
            }
            else
            {
                btnMonthToggle.Text = "ALL MONTHS";
                btnMonthToggle.BackColor = Color.LightGray;
                btnMonthToggle.ForeColor = Color.Black;
            }
        }
    }
}
