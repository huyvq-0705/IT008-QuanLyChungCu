namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    partial class UnitItemControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUnitCode = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnViewMore = new System.Windows.Forms.Button();
            this.panelStatusStrip = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelStatusStrip
            // 
            this.panelStatusStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStatusStrip.Location = new System.Drawing.Point(0, 0);
            this.panelStatusStrip.Name = "panelStatusStrip";
            this.panelStatusStrip.Size = new System.Drawing.Size(10, 98);
            this.panelStatusStrip.TabIndex = 3;
            // 
            // lblUnitCode
            // 
            this.lblUnitCode.AutoSize = true;
            this.lblUnitCode.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUnitCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUnitCode.Location = new System.Drawing.Point(25, 15);
            this.lblUnitCode.Name = "lblUnitCode";
            this.lblUnitCode.Size = new System.Drawing.Size(102, 25);
            this.lblUnitCode.TabIndex = 0;
            this.lblUnitCode.Text = "Unit: A101";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(27, 55);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 19);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "OCCUPIED";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetails.ForeColor = System.Drawing.Color.Gray;
            this.lblDetails.Location = new System.Drawing.Point(130, 21);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(119, 19);
            this.lblDetails.TabIndex = 4;
            this.lblDetails.Text = "Floor 1  •  Studio";
            // 
            // btnViewMore
            // 
            this.btnViewMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewMore.BackColor = System.Drawing.Color.White;
            this.btnViewMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMore.FlatAppearance.BorderSize = 1;
            this.btnViewMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewMore.ForeColor = System.Drawing.Color.Black;
            this.btnViewMore.Location = new System.Drawing.Point(600, 30);
            this.btnViewMore.Name = "btnViewMore";
            this.btnViewMore.Size = new System.Drawing.Size(120, 35);
            this.btnViewMore.TabIndex = 2;
            this.btnViewMore.Text = "DETAILS";
            this.btnViewMore.UseVisualStyleBackColor = false;
            this.btnViewMore.Click += new System.EventHandler(this.btnViewMore_Click);
            // 
            // UnitItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.panelStatusStrip);
            this.Controls.Add(this.btnViewMore);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblUnitCode);
            this.Name = "UnitItemControl";
            this.Size = new System.Drawing.Size(750, 98);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblUnitCode;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnViewMore;
        private System.Windows.Forms.Panel panelStatusStrip;
        private System.Windows.Forms.Label lblDetails;
    }
}