using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class Unit_Form : Form
    {
        private int _selectedUnitId = -1;
        private bool _isViewOnly = false;

        public Unit_Form()
        {
            InitializeComponent();
            _isViewOnly = true;
            SetupViewOnlyMode();
        }

        public Unit_Form(int unitId)
        {
            InitializeComponent();
            _selectedUnitId = unitId;
            _isViewOnly = true;
            SetupViewOnlyMode();
        }

        private void Unit_Form_Load(object? sender, EventArgs e)
        {
            LoadUnitDetails(_selectedUnitId);
        }

        // ==================== VIEW ONLY ====================

        private void SetupViewOnlyMode()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            panelLeft.Dock = DockStyle.Fill;
        }

        // ==================== DATA LOADING ====================

        private void LoadUnitDetails(int id)
        {
            try
            {
                using (var conn = Db.Open())
                {
                    string sql = @"
                        SELECT 
                            u.unit_code,
                            u.floor_no,
                            u.area_m2,
                            u.monthly_rent,
                            u.status,
                            ut.label AS unit_type_label
                        FROM unit u
                        JOIN unit_type ut ON ut.id = u.unit_type_id
                        WHERE u.id = @id
                    ";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Unit not found.");
                                return;
                            }

                            // ===== Basic info =====
                            txtCode.Text = reader["unit_code"].ToString();
                            txtFloor.Text = reader["floor_no"].ToString();
                            txtArea.Text = reader["area_m2"] + " m²";
                            txtRent.Text = $"{reader["monthly_rent"]:N0} VND";

                            string status = reader["status"]?.ToString() ?? "N/A";
                            lblStatusValue.Text = status;

                            // ===== Unit Type Parsing =====
                            string unitTypeLabel = reader["unit_type_label"]?.ToString() ?? "";
                            lblTypeValue.Text = unitTypeLabel;

                            int bedrooms = 0;
                            int bathrooms = 0;

                            string type = unitTypeLabel.ToUpper();

                            // Studio
                            if (type.Contains("STUDIO"))
                            {
                                bedrooms = 0;
                                bathrooms = 0;
                            }
                            // Other types (1BR, 2BR / 2Bathroom, etc.)
                            else if (type.Contains("BR"))
                            {
                                // Bedrooms
                                int brIndex = type.IndexOf("BR");
                                if (brIndex > 0 &&
                                    int.TryParse(type.Substring(0, brIndex), out int br))
                                {
                                    bedrooms = br;
                                }

                                // Bathrooms
                                if (type.Contains("BATH"))
                                {
                                    string[] parts = type.Split('/');
                                    foreach (var p in parts)
                                    {
                                        if (p.Contains("BATH"))
                                        {
                                            string num = new string(p.Where(char.IsDigit).ToArray());
                                            if (int.TryParse(num, out int bath))
                                                bathrooms = bath;
                                        }
                                    }
                                }
                                else
                                {
                                    bathrooms = 1; // default rule
                                }
                            }

                            lblBedValue.Text = bedrooms.ToString();
                            lblBathValue.Text = bathrooms.ToString();

                            // ===== Status Color =====
                            Color statusColor = status switch
                            {
                                "OCCUPIED" => Color.SeaGreen,
                                "VACANT" => Color.Goldenrod,
                                "MAINTENANCE" => Color.Crimson,
                                _ => Color.Gray
                            };

                            pn_StatusValue.FillColor = statusColor;
                            lblStatusValue.ForeColor = Color.White;

                            using (Graphics g = CreateGraphics())
                            {
                                SizeF textSize = g.MeasureString(lblStatusValue.Text, lblStatusValue.Font);
                                pn_StatusValue.Size = new Size((int)textSize.Width + 20, 30);
                                lblStatusValue.Location = new Point(
                                    (pn_StatusValue.Width - (int)textSize.Width) / 2,
                                    (pn_StatusValue.Height - (int)textSize.Height) / 2
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading unit details: " + ex.Message);
            }
        }
    }
}
