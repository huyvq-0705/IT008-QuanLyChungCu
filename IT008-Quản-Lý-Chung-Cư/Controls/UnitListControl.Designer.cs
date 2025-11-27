namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    partial class UnitListControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.picFilter = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeader.Controls.Add(this.cmbFilter);
            this.pnlHeader.Controls.Add(this.picFilter);
            this.pnlHeader.Controls.Add(this.labelTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 70);
            this.pnlHeader.TabIndex = 2;
            // 
            // cmbFilter
            // 
            this.cmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "ALL STATUS",
            "VACANT",
            "OCCUPIED",
            "MAINTENANCE"});
            this.cmbFilter.Location = new System.Drawing.Point(710, 22);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(170, 28);
            this.cmbFilter.TabIndex = 2;
            // 
            // picFilter
            // 
            this.picFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFilter.Image = global::IT008_Quản_Lý_Chung_Cư.Properties.Resources.filter_icon;
            this.picFilter.Location = new System.Drawing.Point(675, 22);
            this.picFilter.Name = "picFilter";
            this.picFilter.Size = new System.Drawing.Size(28, 28);
            this.picFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFilter.TabIndex = 1;
            this.picFilter.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelTitle.Location = new System.Drawing.Point(20, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(123, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ALL UNITS";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 530);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // UnitListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UnitListControl";
            this.Size = new System.Drawing.Size(900, 600);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox picFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
    }
}