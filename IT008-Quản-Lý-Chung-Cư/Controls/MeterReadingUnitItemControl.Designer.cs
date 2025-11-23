namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    partial class MeterReadingUnitItemControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMainInfo = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.panelLeftStrip = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMainInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMainInfo.Location = new System.Drawing.Point(25, 15);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(350, 20);
            this.lblMainInfo.TabIndex = 0;
            this.lblMainInfo.Text = "Unit_Code: A101   Primary_Owner: Name Here";
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(730, 10);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 30);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "VIEW MORE";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // panelLeftStrip
            // 
            this.panelLeftStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.panelLeftStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftStrip.Location = new System.Drawing.Point(0, 0);
            this.panelLeftStrip.Name = "panelLeftStrip";
            this.panelLeftStrip.Size = new System.Drawing.Size(5, 50);
            this.panelLeftStrip.TabIndex = 2;
            // 
            // MeterReadingUnitItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelLeftStrip);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblMainInfo);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "MeterReadingUnitItemControl";
            this.Size = new System.Drawing.Size(850, 50);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel panelLeftStrip;
    }
}