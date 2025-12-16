using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    public partial class MonthlyBillListControl : UserControl
    {
        private int _staffId;

        public MonthlyBillListControl(int staffId)
        {
            InitializeComponent();
            _staffId = staffId;

            // Set Default
            cmbFilter.SelectedIndex = 0; // ALL STATUS

            // Events
            this.Load += MonthlyBillListControl_Load;
            this.Resize += (s, e) => ResizeItems();

            // Reload when filter changes
            cmbFilter.SelectedIndexChanged += (s, e) => LoadData();
        }

        private void MonthlyBillListControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ResizeItems()
        {
            flowLayoutPanel1.SuspendLayout();
            // Adjust width to account for scrollbar
            int w = flowLayoutPanel1.ClientSize.Width - 30;
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                c.Width = w;
            }
            flowLayoutPanel1.ResumeLayout();
        }

        public void LoadData()
        {
            flowLayoutPanel1.Controls.Clear();
            string selectedFilter = cmbFilter.SelectedItem?.ToString();
            // Handle null case on first load
            if (string.IsNullOrEmpty(selectedFilter)) selectedFilter = "ALL STATUS";

            try
            {
                using (var conn = Db.Open())
                {
                    // Base Query
                    string sql = @"
                        SELECT b.id, u.unit_code, b.period_month, b.total_amount, b.status
                        FROM monthly_bill b
                        JOIN unit u ON b.unit_id = u.id
                        WHERE b.is_deleted = FALSE";

                    // Apply Filter
                    if (selectedFilter != "ALL STATUS")
                    {
                        sql += " AND b.status = @status";
                    }

                    sql += " ORDER BY b.period_month DESC, u.unit_code ASC";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // Add parameter only if filtering
                        if (selectedFilter != "ALL STATUS")
                        {
                            cmd.Parameters.AddWithValue("@status", selectedFilter);
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
            // --- CARD CONTAINER ---
            Panel p = new Panel();
            p.Height = 85; // Taller for better spacing
            p.BackColor = Color.White;
            p.Cursor = Cursors.Hand;
            p.Margin = new Padding(0, 0, 0, 15); // Space between items
            p.Click += (s, e) => OpenBill(id);

            // --- LEFT BLUE STRIP ---
            Panel strip = new Panel();
            strip.Width = 6;
            strip.Dock = DockStyle.Left;
            strip.BackColor = Color.FromArgb(52, 152, 219); // Theme Blue
            p.Controls.Add(strip);

            // --- BILL ICON ---
            PictureBox icon = new PictureBox();
            icon.Image = Properties.Resources.bill_icon;
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            icon.Size = new Size(40, 40);
            icon.Location = new Point(25, 22);
            icon.Click += (s, e) => OpenBill(id);
            p.Controls.Add(icon);

            // --- TITLE: Unit & Period ---
            Label lblTitle = new Label();
            lblTitle.Text = $"Unit: {code}  |  Period: {period:MM/yyyy}";
            lblTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(80, 18);
            lblTitle.Click += (s, e) => OpenBill(id);
            p.Controls.Add(lblTitle);

            // --- SUBTITLE: Amount ---
            Label lblAmount = new Label();
            lblAmount.Text = $"Total Amount: {total:N0} VND";
            lblAmount.Font = new Font("Arial", 10);
            lblAmount.ForeColor = Color.Gray;
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(80, 46);
            lblAmount.Click += (s, e) => OpenBill(id);
            p.Controls.Add(lblAmount);

            // --- STATUS BADGE (RIGHT) ---
            Label lblStatus = new Label();
            lblStatus.Text = status;
            lblStatus.Font = new Font("Arial", 10, FontStyle.Bold);
            lblStatus.AutoSize = true;

            // Color Logic
            if (status == "PAID")
            {
                lblStatus.ForeColor = Color.SeaGreen;
            }
            else if (status == "UNPAID")
            {
                lblStatus.ForeColor = Color.FromArgb(231, 76, 60); // Red
            }
            else
            {
                lblStatus.ForeColor = Color.Orange; // Pending or other
            }

            // Align to right
            lblStatus.Location = new Point(p.Width - 120, 32);
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus.TextAlign = ContentAlignment.MiddleRight;
            lblStatus.Click += (s, e) => OpenBill(id);
            p.Controls.Add(lblStatus);

            return p;
        }

        private void OpenBill(int id)
        {
            MonthlyBill_Form form = new MonthlyBill_Form(_staffId, id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MonthlyBill_Form form = new MonthlyBill_Form(_staffId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}