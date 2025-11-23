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
            this.Load += MonthlyBillListControl_Load;
            this.Resize += (s, e) => ResizeItems();
        }

        private void MonthlyBillListControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ResizeItems()
        {
            flowLayoutPanel1.SuspendLayout();
            int w = flowLayoutPanel1.ClientSize.Width - 25;
            foreach (Control c in flowLayoutPanel1.Controls) c.Width = w;
            flowLayoutPanel1.ResumeLayout();
        }

        public void LoadData()
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                using (var conn = Db.Open())
                {
                    // Fetch Bill ID, Unit Code, Period, Total Amount, Status
                    string sql = @"
                        SELECT b.id, u.unit_code, b.period_month, b.total_amount, b.status
                        FROM monthly_bill b
                        JOIN unit u ON b.unit_id = u.id
                        WHERE b.is_deleted = FALSE
                        ORDER BY b.period_month DESC, u.unit_code ASC";

                    using (var cmd = new NpgsqlCommand(sql, conn))
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

                            // Create a simple panel item for the list
                            var item = CreateBillItem(id, code, period, total, status);
                            item.Width = flowLayoutPanel1.ClientSize.Width - 25;
                            flowLayoutPanel1.Controls.Add(item);
                        }
                        flowLayoutPanel1.ResumeLayout();
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
            Panel p = new Panel();
            p.Height = 50;
            p.BackColor = Color.White;
            p.Padding = new Padding(10);
            p.Cursor = Cursors.Hand;
            p.Click += (s, e) => OpenBill(id);

            Label lblInfo = new Label();
            lblInfo.Text = $"Unit: {code}  |  Period: {period:MM/yyyy}  |  Total: {total:N0} VND";
            lblInfo.Font = new Font("Segoe UI", 11);
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(10, 12);
            lblInfo.Click += (s, e) => OpenBill(id);

            Label lblStatus = new Label();
            lblStatus.Text = status;
            lblStatus.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblStatus.ForeColor = status == "PAID" ? Color.SeaGreen : Color.OrangeRed;
            lblStatus.Location = new Point(p.Width - 100, 12); // Right aligned roughly
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Right;
            lblStatus.TextAlign = ContentAlignment.MiddleRight;
            lblStatus.Click += (s, e) => OpenBill(id);

            p.Controls.Add(lblInfo);
            p.Controls.Add(lblStatus);

            // Bottom border
            Panel line = new Panel();
            line.Height = 1;
            line.Dock = DockStyle.Bottom;
            line.BackColor = Color.LightGray;
            p.Controls.Add(line);

            return p;
        }

        private void OpenBill(int id)
        {
            MonthlyBill_Form form = new MonthlyBill_Form(_staffId, id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData(); // Reload list to show updated status/amount
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Pass staffId to the form
            MonthlyBill_Form form = new MonthlyBill_Form(_staffId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}