using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    public partial class UnitListControl : UserControl
    {
        public UnitListControl()
        {
            InitializeComponent();

            // --- FIX 1: Responsive Layout ---
            // When this control resizes (window maximizes), resize the items inside
            this.Resize += UnitListControl_Resize;
            flowLayoutPanel1.Resize += UnitListControl_Resize;
        }

        private void UnitListControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // This function ensures items stretch to fill the width
        private void UnitListControl_Resize(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                // Calculate new width: Container Width - Scrollbar padding (approx 25)
                int newWidth = flowLayoutPanel1.ClientSize.Width - 25;

                flowLayoutPanel1.SuspendLayout(); // Stop drawing to prevent flicker
                foreach (Control c in flowLayoutPanel1.Controls)
                {
                    c.Width = newWidth;
                }
                flowLayoutPanel1.ResumeLayout(); // Resume drawing
            }
        }

        public void LoadData()
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                using (var conn = Db.Open())
                {
                    string sql = "SELECT id, unit_code, floor_no, status, unit_type FROM unit WHERE is_deleted = FALSE ORDER BY unit_code";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanel1.SuspendLayout();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string code = reader.GetString(1);
                            int floor = reader.GetInt32(2);
                            string status = reader.GetString(3);
                            string type = reader.GetString(4);

                            UnitItemControl item = new UnitItemControl(id, code, floor, status, type);

                            // Initial width calculation
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