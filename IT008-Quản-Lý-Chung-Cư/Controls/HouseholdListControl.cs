using System;
using System.Windows.Forms;
using Npgsql;

namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    public partial class HouseholdListControl : UserControl
    {
        public HouseholdListControl()
        {
            InitializeComponent();
            this.Resize += (s, e) => ResizeItems();
        }

        private void HouseholdListControl_Load(object sender, EventArgs e)
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
                    // Fetch Household ID, Unit Code, and Primary Owner Name
                    string sql = @"
                        SELECT h.id, u.unit_code, 
                               COALESCE(m.full_name, 'Unknown') as owner_name
                        FROM household h
                        JOIN unit u ON h.unit_id = u.id
                        LEFT JOIN household_member m ON m.household_id = h.id AND m.is_primary = TRUE
                        WHERE h.is_deleted = FALSE 
                        ORDER BY u.unit_code";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanel1.SuspendLayout();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string code = reader.GetString(1);
                            string owner = reader.GetString(2);

                            var item = new HouseholdItemControl(id, code, owner);
                            item.Width = flowLayoutPanel1.ClientSize.Width - 25;
                            flowLayoutPanel1.Controls.Add(item);
                        }
                        flowLayoutPanel1.ResumeLayout();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading households: " + ex.Message);
            }
        }

        // Add New Household logic can go here (btnCreate_Click)
        private void btnCreate_Click(object sender, EventArgs e)
        {
            NewHousehold_Form form = new NewHousehold_Form();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Reload list to show the new household (it will appear with Owner: "Unknown" initially)
                LoadData();
            }
        }
    }
}