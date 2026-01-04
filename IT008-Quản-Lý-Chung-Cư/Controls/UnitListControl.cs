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

            // Set default selection
            cmbFilter.SelectedIndex = 0; // "ALL STATUS"

            // Event Handlers
            this.Load += UnitListControl_Load;
            this.Resize += UnitListControl_Resize;
            flowLayoutPanel1.Resize += UnitListControl_Resize;

            // Reload data when filter changes
            cmbFilter.SelectedIndexChanged += (s, e) => LoadData();
        }

        private void UnitListControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void UnitListControl_Resize(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                int newWidth = flowLayoutPanel1.ClientSize.Width - 30; // 30 for scrollbar/padding

                flowLayoutPanel1.SuspendLayout();
                foreach (Control c in flowLayoutPanel1.Controls)
                {
                    c.Width = newWidth;
                }
                flowLayoutPanel1.ResumeLayout();
            }
        }

        public void LoadData()
        {
            flowLayoutPanel1.Controls.Clear();

            string selectedStatus = cmbFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedStatus)) selectedStatus = "ALL STATUS";

            try
            {
                using (var conn = Db.Open())
                {
                    string sql = @"
                SELECT 
                    u.id,
                    u.unit_code,
                    u.floor_no,
                    u.status,
                    ut.label AS unit_type
                FROM unit u
                JOIN unit_type ut ON ut.id = u.unit_type_id
                WHERE u.is_deleted = FALSE";

                    if (selectedStatus != "ALL STATUS")
                        sql += " AND u.status = @status";

                    sql += " ORDER BY u.unit_code";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        if (selectedStatus != "ALL STATUS")
                            cmd.Parameters.AddWithValue("@status", selectedStatus);

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

                                UnitItemControl item =
                                    new UnitItemControl(id, code, floor, status, type);

                                item.Width = flowLayoutPanel1.ClientSize.Width - 30;
                                item.Margin = new Padding(0, 0, 0, 10);

                                flowLayoutPanel1.Controls.Add(item);
                            }

                            flowLayoutPanel1.ResumeLayout();
                        }
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