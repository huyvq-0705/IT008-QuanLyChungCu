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
            this.pnlLeftStrip = new System.Windows.Forms.Panel();
            this.lblMainInfo = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.pnlLeftStrip);
            this.pnlCard.Controls.Add(this.lblMainInfo);
            this.pnlCard.Controls.Add(this.btnView);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(750, 85);
            this.pnlCard.TabIndex = 0;
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
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.lblMainInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblMainInfo.Location = new System.Drawing.Point(25, 32);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(350, 21);
            this.lblMainInfo.TabIndex = 1;
            this.lblMainInfo.Text = "🏢 Unit_Code: 101  |  👤 Primary_Owner: Truong Sinh";
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(590, 25);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(140, 38);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "👁️ VIEW MORE";
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
            this.Size = new System.Drawing.Size(750, 85);
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlLeftStrip;
        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.Button btnView;
    }
}