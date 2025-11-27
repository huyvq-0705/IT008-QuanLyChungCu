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
            pnlStrip.Margin = new Padding(3, 4, 3, 4);
            pnlStrip.Name = "pnlStrip";
            pnlStrip.Size = new Size(7, 77);
            pnlStrip.TabIndex = 0;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInfo.ForeColor = Color.FromArgb(44, 62, 80);
            lblInfo.Location = new Point(64, 31);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(261, 25);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "[A101] Air Conditioner Leak";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.White;
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(46, 204, 113);
            lblStatus.Location = new Point(634, 31);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(6, 3, 6, 3);
            lblStatus.Size = new Size(63, 28);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "OPEN";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F);
            lblDate.ForeColor = Color.Gray;
            lblDate.Location = new Point(747, 33);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(124, 20);
            lblDate.TabIndex = 3;
            lblDate.Text = "12/07/2025 14:30";
            // 
            // picTicketIcon
            // 
            picTicketIcon.Image = Properties.Resources.ticket_icon;
            picTicketIcon.Location = new Point(21, 24);
            picTicketIcon.Margin = new Padding(3, 4, 3, 4);
            picTicketIcon.Name = "picTicketIcon";
            picTicketIcon.Size = new Size(37, 43);
            picTicketIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picTicketIcon.TabIndex = 4;
            picTicketIcon.TabStop = false;
            // 
            // picCalendarIcon
            // 
            picCalendarIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCalendarIcon.Image = Properties.Resources.calendar_icon;
            picCalendarIcon.Location = new Point(720, 32);
            picCalendarIcon.Margin = new Padding(3, 4, 3, 4);
            picCalendarIcon.Name = "picCalendarIcon";
            picCalendarIcon.Size = new Size(21, 24);
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
            pnlBackground.Location = new Point(0, 7);
            pnlBackground.Margin = new Padding(6, 7, 6, 7);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(914, 79);
            pnlBackground.TabIndex = 0;
            // 
            // TicketItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            Controls.Add(pnlBackground);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TicketItemControl";
            Padding = new Padding(0, 7, 0, 7);
            Size = new Size(914, 93);
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