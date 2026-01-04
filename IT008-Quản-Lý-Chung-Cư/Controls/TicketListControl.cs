using System;
using System.Windows.Forms;
using Npgsql;

namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    public partial class TicketListControl : UserControl
    {
        private int _staffId;

        public TicketListControl(int staffId)
        {
            InitializeComponent();
            _staffId = staffId;
            this.Load += TicketListControl_Load;
            this.Resize += (s, e) => ResizeItems();
        }

        private void TicketListControl_Load(object sender, EventArgs e)
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
                    string sql = @"
                        SELECT t.id, u.unit_code, t.title, t.status, t.created_at, s.full_name
                        FROM ticket t
                        JOIN unit u ON t.unit_id = u.id
                        JOIN staff s ON t.created_by_staff_id = s.id
                        WHERE t.is_deleted = FALSE
                        ORDER BY 
                            CASE WHEN t.status = 'OPEN' THEN 1 
                                 WHEN t.status = 'IN_PROGRESS' THEN 2 
                                 ELSE 3 END,
                            t.created_at DESC";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanel1.SuspendLayout();
                        while (reader.Read())
                        {
                            string creatorName = reader.GetString(5);
                            int id = reader.GetInt32(0);
                            string code = reader.GetString(1);
                            string title = reader.GetString(2);
                            string status = reader.GetString(3); // PostgreSQL Enum returns as string
                            DateTime date = reader.GetDateTime(4);

                            var item = new TicketItemControl(id, code, title, status, date, _staffId, creatorName);
                            item.Width = flowLayoutPanel1.ClientSize.Width - 25;
                            // Subscribe to update event to reload list when item changes
                            item.StatusUpdated += (s, args) => LoadData();
                            flowLayoutPanel1.Controls.Add(item);
                        }
                        flowLayoutPanel1.ResumeLayout();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tickets: " + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Ticket_Form form = new Ticket_Form(_staffId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}