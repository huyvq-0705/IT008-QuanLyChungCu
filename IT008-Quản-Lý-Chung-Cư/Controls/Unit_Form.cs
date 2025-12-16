using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class Unit_Form : Form
    {
        // Giữ lại _selectedUnitId và _isViewOnly để đảm bảo Form này chỉ dùng cho mục đích View
        private int _selectedUnitId = -1;
        private bool _isViewOnly = false;

        // Constructor mặc định (có thể bị loại bỏ nếu bạn chỉ dùng Unit_Form(int unitId))
        public Unit_Form()
        {
            InitializeComponent();
            // Đặt mặc định là View Only vì giao diện đã được thiết kế lại như vậy
            _isViewOnly = true;
            SetupViewOnlyMode();
        }

        // Constructor chính để xem chi tiết một Unit
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

        // ==================== VIEW ONLY SETUP ====================

        private void SetupViewOnlyMode()
        {
            // Thiết lập cửa sổ đơn giản, không có nút Minimize/Maximize
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Đảm bảo panelLeft lấp đầy toàn bộ Form
            panelLeft.Dock = DockStyle.Fill;
            // Kích thước Form đã được đặt trong Designer để phù hợp với panelLeft
        }

        // ==================== DATA LOADING (ĐÃ CẬP NHẬT CONTROL) ====================

        private void LoadUnitDetails(int id)
        {
            try
            {
                using (var conn = Db.Open())
                {
                    string sql = "SELECT * FROM unit WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCode.Text = reader["unit_code"].ToString();
                                txtFloor.Text = reader["floor_no"].ToString();
                                txtArea.Text = reader["area_m2"].ToString() + " m²";
                                txtRent.Text = $"{reader["monthly_rent"]:N0} VND";

                                lblBedValue.Text = reader["bedrooms"].ToString();
                                lblBathValue.Text = reader["bathrooms"].ToString();
                                lblTypeValue.Text = reader["unit_type"].ToString();

                                string status = reader["status"].ToString() ?? "N/A";
                                lblStatusValue.Text = status;

                                Color statusColor;

                                if (status == "OCCUPIED")
                                {
                                    statusColor = Color.SeaGreen;
                                }
                                else if (status == "VACANT")
                                {
                                    statusColor = Color.Goldenrod;
                                }
                                else if (status == "MAINTENANCE")
                                {
                                    statusColor = Color.Crimson; 
                                }    
                                else
                                {
                                    statusColor = Color.Gray;
                                }

                                pn_StatusValue.FillColor = statusColor;
                                lblStatusValue.ForeColor = Color.White;

                                using (Graphics g = this.CreateGraphics())
                                {
                                    SizeF textSize = g.MeasureString(lblStatusValue.Text, lblStatusValue.Font);
                                    int newWidth = (int)Math.Ceiling(textSize.Width) + 20;

                                    pn_StatusValue.Size = new Size(newWidth, 30);

                                    lblStatusValue.Location = new Point((pn_StatusValue.Width - (int)Math.Ceiling(textSize.Width)) / 2,
                                                                        (pn_StatusValue.Height - (int)Math.Ceiling(textSize.Height)) / 2);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Unit ID not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading details: " + ex.Message);
            }
        }

    }
}