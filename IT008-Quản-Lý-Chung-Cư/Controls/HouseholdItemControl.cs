using System;
using System.Drawing;
using System.Windows.Forms;

namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    public partial class HouseholdItemControl : UserControl
    {
        public int HouseholdId { get; private set; }

        // We now accept the 'primaryOwner' name directly in the constructor
        public HouseholdItemControl(int id, string unitCode, string primaryOwner)
        {
            InitializeComponent();
            HouseholdId = id;

            // Matches screenshot format: "Unit_Code: 101 Primary_Owner: Name"
            lblMainInfo.Text = $"Unit_Code: {unitCode}   Primary_Owner: {primaryOwner}";

            // Click events
            this.Click += (s, e) => btnView.PerformClick();
            foreach (Control c in this.Controls)
            {
                if (!(c is Button)) c.Click += (s, e) => btnView.PerformClick();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Household_Form form = new Household_Form(HouseholdId);
            form.ShowDialog();
        }
    }
}