namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    partial class MonthlyBillListControl
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
            this.picTitleIcon = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.cmbFilter);
            this.pnlHeader.Controls.Add(this.picFilter);
            this.pnlHeader.Controls.Add(this.picTitleIcon);
            this.pnlHeader.Controls.Add(this.labelTitle);
            this.pnlHeader.Controls.Add(this.btnCreate);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // cmbFilter
            // 
            this.cmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "ALL STATUS",
            "PAID",
            "UNPAID"});
            this.cmbFilter.Location = new System.Drawing.Point(510, 28);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(170, 28);
            this.cmbFilter.TabIndex = 4;
            // 
            // picFilter
            // 
            this.picFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFilter.Image = global::IT008_Quản_Lý_Chung_Cư.Properties.Resources.filter_icon;
            this.picFilter.Location = new System.Drawing.Point(475, 28);
            this.picFilter.Name = "picFilter";
            this.picFilter.Size = new System.Drawing.Size(28, 28);
            this.picFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFilter.TabIndex = 3;
            this.picFilter.TabStop = false;
            // 
            // picTitleIcon
            // 
            this.picTitleIcon.Image = global::IT008_Quản_Lý_Chung_Cư.Properties.Resources.bill_icon;
            this.picTitleIcon.Location = new System.Drawing.Point(20, 20);
            this.picTitleIcon.Name = "picTitleIcon";
            this.picTitleIcon.Size = new System.Drawing.Size(40, 40);
            this.picTitleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitleIcon.TabIndex = 1;
            this.picTitleIcon.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelTitle.Location = new System.Drawing.Point(70, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(205, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "MONTHLY BILLS";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(700, 20);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(180, 45);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "CREATE NEW +";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 520);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // MonthlyBillListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "MonthlyBillListControl";
            this.Size = new System.Drawing.Size(900, 600);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleIcon)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picTitleIcon;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.PictureBox picFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
    }
}