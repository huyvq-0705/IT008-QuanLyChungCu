using System;
using System.Windows.Forms;
using Npgsql;

namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    public partial class MeterReadingListControl : UserControl
    {
        private int _staffId;

        public MeterReadingListControl(int staffId)
        {
            InitializeComponent();
            _staffId = staffId;
            this.Load += MeterReadingListControl_Load;
            this.Resize += (s, e) => ResizeItems();
        }

        private void MeterReadingListControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ResizeItems()
        {
            flowLayoutPanel1.SuspendLayout();
            int newWidth = flowLayoutPanel1.ClientSize.Width - 25;
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                c.Width = newWidth;
            }
            flowLayoutPanel1.ResumeLayout();
        }

        public void LoadData()
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                using (var conn = Db.Open())
                {
                    // Find occupied units and their primary owner
                    string sql = @"
                        SELECT u.id, u.unit_code, 
                               COALESCE(m.full_name, 'Unknown') as owner_name
                        FROM unit u
                        JOIN household h ON h.unit_id = u.id AND h.end_date IS NULL
                        LEFT JOIN household_member m ON m.household_id = h.id AND m.is_primary = TRUE
                        WHERE u.status = 'OCCUPIED' AND u.is_deleted = FALSE
                        ORDER BY u.unit_code";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanel1.SuspendLayout();
                        while (reader.Read())
                        {
                            int unitId = reader.GetInt32(0);
                            string code = reader.GetString(1);
                            string owner = reader.GetString(2);

                            // Pass staffId down so it can be used when creating new readings later
                            var item = new MeterReadingUnitItemControl(unitId, code, owner, _staffId);
                            item.Width = flowLayoutPanel1.ClientSize.Width - 25;
                            flowLayoutPanel1.Controls.Add(item);
                        }
                        flowLayoutPanel1.ResumeLayout();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading units: " + ex.Message);
            }
        }
    }
}