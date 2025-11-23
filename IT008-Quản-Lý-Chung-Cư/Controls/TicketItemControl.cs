using System;
using System.Drawing;
using System.Windows.Forms;

namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    public partial class TicketItemControl : UserControl
    {
        private int _ticketId;
        private int _staffId;

        public event EventHandler StatusUpdated;

        public TicketItemControl(int id, string code, string title, string status, DateTime date, int staffId)
        {
            InitializeComponent();
            _ticketId = id;
            _staffId = staffId;

            lblInfo.Text = $"[{code}] {title}";
            lblDate.Text = date.ToString("dd/MM/yyyy HH:mm");
            lblStatus.Text = status;

            // Color coding based on status
            Color stripColor = Color.Gray;
            if (status == "OPEN") stripColor = Color.OrangeRed;
            else if (status == "IN_PROGRESS") stripColor = Color.DodgerBlue;
            else if (status == "CLOSED") stripColor = Color.SeaGreen;

            pnlStrip.BackColor = stripColor;
            lblStatus.ForeColor = stripColor;

            // Click events
            this.Click += Item_Click;
            foreach (Control c in this.Controls) c.Click += Item_Click;
        }

        private void Item_Click(object sender, EventArgs e)
        {
            Ticket_Form form = new Ticket_Form(_staffId, _ticketId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                StatusUpdated?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}