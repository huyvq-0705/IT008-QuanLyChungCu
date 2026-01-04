using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using IT008_Quản_Lý_Chung_Cư.Controls;

namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class Dashboard_Form : Form
    {
        private int _currentStaffId;

        // Danh sách chứa ALL button menu
        private List<Guna2Button> _menuButtons;

        // Màu mặc định và màu active
        private Color defaultColor = Color.White;
        private Color activeColor = Color.FromArgb(94, 148, 255);
        private Color defaultTextColor = Color.Black;
        private Color activeTextColor = Color.White;

        public Dashboard_Form() : this(1) { }

        public Dashboard_Form(int staffId)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            _currentStaffId = staffId;
        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            // Gom nút vào danh sách
            _menuButtons = new List<Guna2Button>()
            {
                btnStaff,
                btnUnit,
                btnHousehold,
                btnMeterReading,
                btnMonthlyBill,
                btnTicket
            };

            btnUnit_Click(sender, e);   // Load mặc định
        }


        // ========== HÀM XỬ LÝ ACTIVE ==========
        private void SetActiveButton(Guna2Button clicked)
        {
            foreach (var btn in _menuButtons)
            {
                // Reset nút về mặc định
                btn.FillColor = defaultColor;
                btn.ForeColor = defaultTextColor;
            }

            // Gán màu cho nút đang chọn
            clicked.FillColor = activeColor;
            clicked.ForeColor = activeTextColor;
        }


        // ========== HÀM HIỂN THỊ CONTROL ==========
        private void ShowControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }


        // ========== CÁC SỰ KIỆN CLICK ==========

        private void btnStaff_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnStaff);
            ShowControl(new ViewProfile_Control(_currentStaffId));
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnUnit);
            ShowControl(new UnitListControl());
        }

        private void btnHousehold_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnHousehold);
            ShowControl(new HouseholdListControl());
        }

        private void btnMeterReading_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnMeterReading);
            ShowControl(new MeterReadingListControl(_currentStaffId));
        }

        private void btnMonthlyBill_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnMonthlyBill);
            ShowControl(new MonthlyBillListControl(_currentStaffId));
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnTicket);
            ShowControl(new TicketListControl(_currentStaffId));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Logout KHÔNG nằm trong group menu nên không tô màu
            this.Hide();
            new Login_Page().Show();
        }
    }
}
