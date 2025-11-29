using System;
using System.Drawing;
using System.Windows.Forms;

namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    public partial class UnitItemControl : UserControl
    {
        public int UnitId { get; private set; }

        public UnitItemControl(int id, string code, int floor, string status, string type)
        {
            InitializeComponent();
            UnitId = id;

            // 1. Set Text
            lblUnitCode.Text = $"Unit: {code}";
            lblDetails.Text = $"Floor {floor}  •  {type}";
            lblStatus.Text = status.ToUpper();

            // 2. Apply Styling based on Status
            ApplyStatusStyle(status);

            // 3. Make the whole control clickable (User Experience)
            this.Click += (s, e) => btnViewMore.PerformClick();
            foreach (Control c in this.Controls)
            {
                if (!(c is Button)) c.Click += (s, e) => btnViewMore.PerformClick();
            }
        }

        private void ApplyStatusStyle(string status)
        {
            Color statusColor;

            switch (status.ToUpper())
            {
                case "OCCUPIED":
                    statusColor = Color.SeaGreen; // Nice Green
                    break;
                case "MAINTENANCE":
                    statusColor = Color.Crimson; // Nice Red
                    break;
                case "VACANT":
                    statusColor = Color.Goldenrod; // Darker Yellow (Readable on white)
                    break;
                default:
                    statusColor = Color.Gray;
                    break;
            }

            // Apply color to the side strip and the status text
            panelStatusStrip.BackColor = statusColor;
            lblStatus.ForeColor = statusColor;

            // Optional: Change button border to match
            btnViewMore.FlatAppearance.BorderColor = statusColor;
        }

        private void btnViewMore_Click(object sender, EventArgs e)
        {
            Unit_Form detailPopup = new Unit_Form(UnitId);
            detailPopup.ShowDialog();
        }
    }
}