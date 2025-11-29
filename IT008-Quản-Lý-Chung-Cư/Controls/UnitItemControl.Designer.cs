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
            this.panelStatusStrip = new System.Windows.Forms.Panel();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnViewMore = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUnitCode = new System.Windows.Forms.Label();
            this.picUnitIcon = new System.Windows.Forms.PictureBox();
            this.panelActions.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUnitIcon)).BeginInit();
            this.SuspendLayout();

            // 
            // panelStatusStrip
            // 
            // Left color strip indicating status
            this.panelStatusStrip.BackColor = System.Drawing.Color.Orange; // Example default color
            this.panelStatusStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStatusStrip.Location = new System.Drawing.Point(0, 0);
            this.panelStatusStrip.Name = "panelStatusStrip";
            this.panelStatusStrip.Size = new System.Drawing.Size(8, 98); // Thinner, cleaner strip
            this.panelStatusStrip.TabIndex = 0;

            // 
            // picUnitIcon
            // 
            this.picUnitIcon.Image = global::IT008_Quản_Lý_Chung_Cư.Properties.Resources.unit_icon;
            this.picUnitIcon.Location = new System.Drawing.Point(20, 30);
            this.picUnitIcon.Name = "picUnitIcon";
            this.picUnitIcon.Size = new System.Drawing.Size(40, 40);
            this.picUnitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUnitIcon.TabIndex = 3;
            this.picUnitIcon.TabStop = false;

            // 
            // panelActions
            // 
            // Container for the button, docked to the RIGHT
            this.panelActions.Controls.Add(this.btnViewMore);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelActions.Location = new System.Drawing.Point(590, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(158, 98);
            this.panelActions.TabIndex = 2;

            // 
            // btnViewMore
            // 
            this.btnViewMore.BackColor = System.Drawing.Color.White;
            this.btnViewMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViewMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMore.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewMore.Location = new System.Drawing.Point(26, 31); // Centered visually in the panel
            this.btnViewMore.Name = "btnViewMore";
            this.btnViewMore.Size = new System.Drawing.Size(109, 36);
            this.btnViewMore.TabIndex = 0;
            this.btnViewMore.Text = "DETAILS";
            this.btnViewMore.UseVisualStyleBackColor = false;
            this.btnViewMore.Click += new System.EventHandler(this.btnViewMore_Click);

            // 
            // panelContent
            // 
            // Main text area, fills the remaining space
            this.panelContent.Controls.Add(this.picUnitIcon);
            this.panelContent.Controls.Add(this.lblDetails);
            this.panelContent.Controls.Add(this.lblStatus);
            this.panelContent.Controls.Add(this.lblUnitCode);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(8, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10); // Internal padding
            this.panelContent.Size = new System.Drawing.Size(582, 98);
            this.panelContent.TabIndex = 1;

            // 
            // lblUnitCode
            // 
            this.lblUnitCode.AutoEllipsis = true; // Cuts off with "..." if text is too long
            this.lblUnitCode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnitCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblUnitCode.Location = new System.Drawing.Point(70, 10);
            this.lblUnitCode.Name = "lblUnitCode";
            this.lblUnitCode.Size = new System.Drawing.Size(502, 35);
            this.lblUnitCode.TabIndex = 0;
            this.lblUnitCode.Text = "Unit: A101";

            // 
            // lblDetails
            // 
            this.lblDetails.AutoEllipsis = true;
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetails.ForeColor = System.Drawing.Color.Gray;
            this.lblDetails.Location = new System.Drawing.Point(70, 45); // Placed directly under Title
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(502, 25);
            this.lblDetails.TabIndex = 1;
            this.lblDetails.Text = "Floor 1  •  Studio";

            // 
            // lblStatus
            // 
            // Manually positioned at bottom-left, but relative to panelContent
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatus.Location = new System.Drawing.Point(70, 73);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 15);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "OCCUPIED";

            // 
            // UnitItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelStatusStrip);
            this.Name = "UnitItemControl";
            this.Size = new System.Drawing.Size(750, 98);
            // Optional: Add a subtle bottom border for separation between items
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panelActions.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUnitIcon)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelStatusStrip;
        private System.Windows.Forms.Panel panelActions; // Container for Button
        private System.Windows.Forms.Panel panelContent; // Container for Text
        private System.Windows.Forms.Button btnViewMore;
        private System.Windows.Forms.Label lblUnitCode;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox picUnitIcon;
    }
}