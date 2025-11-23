using System;
using System.Windows.Forms;
using IT008_Quản_Lý_Chung_Cư.Controls;

namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class Dashboard_Form : Form
    {
        // Store the logged-in user's ID
        private int _currentStaffId;

        // Default constructor (for Designer support, though rarely used directly now)
        public Dashboard_Form() : this(1) { }

        // Main Constructor requiring ID
        public Dashboard_Form(int staffId)
        {
            InitializeComponent();
            _currentStaffId = staffId;
        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            // Load Unit view by default, or Profile if you prefer
            btnUnit_Click(sender, e);
        }

        private void ShowControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }

        // --- Button Events ---

        private void btnStaff_Click(object sender, EventArgs e)
        {
            // Show MY PROFILE instead of a list
            ShowControl(new MyProfileControl(_currentStaffId));
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            ShowControl(new UnitListControl());
        }

        private void btnHousehold_Click(object sender, EventArgs e)
        {
            ShowControl(new HouseholdListControl());
        }
        private void btnMeterReading_Click(object sender, EventArgs e)
        {
            // Pass the current staff ID to the control
            ShowControl(new IT008_Quản_Lý_Chung_Cư.Controls.MeterReadingListControl(_currentStaffId));
        }
        private void btnMonthlyBill_Click(object sender, EventArgs e)
        {
            // Pass the _currentStaffId so creating bills works
            ShowControl(new IT008_Quản_Lý_Chung_Cư.Controls.MonthlyBillListControl(_currentStaffId));
        }
        private void btnTicket_Click(object sender, EventArgs e)
        {
            // Make sure to use the full namespace if needed or just Controls.TicketListControl
            ShowControl(new IT008_Quản_Lý_Chung_Cư.Controls.TicketListControl(_currentStaffId));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Page().Show();
        }
    }
}