namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    partial class HouseholdItemControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlCard = new System.Windows.Forms.Panel();
            this.picUserIcon = new System.Windows.Forms.PictureBox();
            this.picHouseholdIcon = new System.Windows.Forms.PictureBox();
            this.pnlLeftStrip = new System.Windows.Forms.Panel();
            this.lblUnitCode = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouseholdIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.picUserIcon);
            this.pnlCard.Controls.Add(this.picHouseholdIcon);
            this.pnlCard.Controls.Add(this.pnlLeftStrip);
            this.pnlCard.Controls.Add(this.lblUnitCode);
            this.pnlCard.Controls.Add(this.lblOwner);
            this.pnlCard.Controls.Add(this.btnView);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(750, 85);
            this.pnlCard.TabIndex = 0;
            // 
            // picUserIcon
            // 
            this.picUserIcon.Image = global::IT008_Quản_Lý_Chung_Cư.Properties.Resources.staff_icon;
            this.picUserIcon.Location = new System.Drawing.Point(80, 48);
            this.picUserIcon.Name = "picUserIcon";
            this.picUserIcon.Size = new System.Drawing.Size(16, 16);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserIcon.TabIndex = 3;
            this.picUserIcon.TabStop = false;
            // 
            // picHouseholdIcon
            // 
            this.picHouseholdIcon.Image = global::IT008_Quản_Lý_Chung_Cư.Properties.Resources.household_icon;
            this.picHouseholdIcon.Location = new System.Drawing.Point(25, 22);
            this.picHouseholdIcon.Name = "picHouseholdIcon";
            this.picHouseholdIcon.Size = new System.Drawing.Size(40, 40);
            this.picHouseholdIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHouseholdIcon.TabIndex = 2;
            this.picHouseholdIcon.TabStop = false;
            // 
            // pnlLeftStrip
            // 
            this.pnlLeftStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlLeftStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftStrip.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftStrip.Name = "pnlLeftStrip";
            this.pnlLeftStrip.Size = new System.Drawing.Size(6, 85);
            this.pnlLeftStrip.TabIndex = 0;
            // 
            // lblUnitCode
            // 
            this.lblUnitCode.AutoSize = true;
            this.lblUnitCode.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblUnitCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUnitCode.Location = new System.Drawing.Point(80, 18);
            this.lblUnitCode.Name = "lblUnitCode";
            this.lblUnitCode.Size = new System.Drawing.Size(149, 25);
            this.lblUnitCode.TabIndex = 1;
            this.lblUnitCode.Text = "Unit Code: A101";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOwner.ForeColor = System.Drawing.Color.Gray;
            this.lblOwner.Location = new System.Drawing.Point(100, 46);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(133, 19);
            this.lblOwner.TabIndex = 4;
            this.lblOwner.Text = "Owner: Truong Sinh";
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(600, 25);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(120, 35);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "VIEW MORE";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // HouseholdItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlCard);
            this.Name = "HouseholdItemControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Size = new System.Drawing.Size(750, 95);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouseholdIcon)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlLeftStrip;
        private System.Windows.Forms.Label lblUnitCode;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.PictureBox picHouseholdIcon;
        private System.Windows.Forms.PictureBox picUserIcon;
    }
}