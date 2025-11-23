namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    partial class TicketItemControl
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.pnlStrip = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlStrip
            // 
            this.pnlStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStrip.Location = new System.Drawing.Point(0, 0);
            this.pnlStrip.Name = "pnlStrip";
            this.pnlStrip.Size = new System.Drawing.Size(5, 60);
            this.pnlStrip.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(20, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(200, 20);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "[A101] Air Conditioner Leak";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(20, 32);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 19);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "OPEN";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(650, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 15);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "12/07/2025 14:30";
            // 
            // TicketItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pnlStrip);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "TicketItemControl";
            this.Size = new System.Drawing.Size(800, 60);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlStrip;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDate;
    }
}