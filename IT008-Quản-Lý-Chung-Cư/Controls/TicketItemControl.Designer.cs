namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    partial class TicketItemControl
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlStrip = new Panel();
            lblInfo = new Label();
            lblStatus = new Label();
            lblDate = new Label();
            picTicketIcon = new PictureBox();
            picCalendarIcon = new PictureBox();
            pnlBackground = new Panel();
            ((System.ComponentModel.ISupportInitialize)picTicketIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCalendarIcon).BeginInit();
            pnlBackground.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStrip
            // 
            pnlStrip.BackColor = Color.FromArgb(52, 152, 219);
            pnlStrip.Dock = DockStyle.Left;
            pnlStrip.Location = new Point(0, 0);
            pnlStrip.Margin = new Padding(3, 5, 3, 5);
            pnlStrip.Name = "pnlStrip";
            pnlStrip.Size = new Size(8, 89);
            pnlStrip.TabIndex = 0;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblInfo.ForeColor = Color.FromArgb(44, 62, 80);
            lblInfo.Location = new Point(72, 36);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(261, 25);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "[A101] Air Conditioner Leak";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.White;
            lblStatus.Font = new Font("Arial", 8.5F, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(713, 36);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(7, 3, 7, 3);
            lblStatus.Size = new Size(63, 26);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "OPEN";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Arial Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.Gray;
            lblDate.Location = new Point(840, 42);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(122, 20);
            lblDate.TabIndex = 3;
            lblDate.Text = "12/07/2025 14:30";
            // 
            // picTicketIcon
            // 
            picTicketIcon.Image = Properties.Resources.ticket_icon;
            picTicketIcon.Location = new Point(24, 28);
            picTicketIcon.Margin = new Padding(3, 5, 3, 5);
            picTicketIcon.Name = "picTicketIcon";
            picTicketIcon.Size = new Size(42, 49);
            picTicketIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picTicketIcon.TabIndex = 4;
            picTicketIcon.TabStop = false;
            // 
            // picCalendarIcon
            // 
            picCalendarIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCalendarIcon.Image = Properties.Resources.calendar_icon;
            picCalendarIcon.Location = new Point(810, 35);
            picCalendarIcon.Margin = new Padding(3, 5, 3, 5);
            picCalendarIcon.Name = "picCalendarIcon";
            picCalendarIcon.Size = new Size(24, 28);
            picCalendarIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picCalendarIcon.TabIndex = 5;
            picCalendarIcon.TabStop = false;
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.White;
            pnlBackground.BorderStyle = BorderStyle.FixedSingle;
            pnlBackground.Controls.Add(picCalendarIcon);
            pnlBackground.Controls.Add(lblDate);
            pnlBackground.Controls.Add(lblStatus);
            pnlBackground.Controls.Add(lblInfo);
            pnlBackground.Controls.Add(picTicketIcon);
            pnlBackground.Controls.Add(pnlStrip);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 8);
            pnlBackground.Margin = new Padding(7, 8, 7, 8);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(1028, 91);
            pnlBackground.TabIndex = 0;
            // 
            // TicketItemControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            Controls.Add(pnlBackground);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 5, 3, 5);
            Name = "TicketItemControl";
            Padding = new Padding(0, 8, 0, 8);
            Size = new Size(1028, 107);
            ((System.ComponentModel.ISupportInitialize)picTicketIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCalendarIcon).EndInit();
            pnlBackground.ResumeLayout(false);
            pnlBackground.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlStrip;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox picTicketIcon;
        private System.Windows.Forms.PictureBox picCalendarIcon;
    }
}