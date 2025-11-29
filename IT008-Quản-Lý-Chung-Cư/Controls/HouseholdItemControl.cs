using System;
using System.Drawing;
using System.Windows.Forms;

namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    public partial class HouseholdItemControl : UserControl
    {
        public int HouseholdId { get; private set; }

        public HouseholdItemControl(int id, string unitCode, string primaryOwner)
        {
            InitializeComponent();
            HouseholdId = id;


            lblUnitCode.Text = $"Unit Code: {unitCode}";

            if (string.IsNullOrEmpty(primaryOwner))
            {
                lblOwner.Text = "Owner: ---";
            }
            else
            {
                lblOwner.Text = $"Owner: {primaryOwner}";
            }

            this.Click += (s, e) => btnView.PerformClick();


            foreach (Control c in this.pnlCard.Controls)
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