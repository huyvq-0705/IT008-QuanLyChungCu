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
            pnlHeader = new Panel();
            cmbFilter = new ComboBox();
            picFilter = new PictureBox();
            labelTitle = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFilter).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.WhiteSmoke;
            pnlHeader.Controls.Add(cmbFilter);
            pnlHeader.Controls.Add(picFilter);
            pnlHeader.Controls.Add(labelTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1157, 107);
            pnlHeader.TabIndex = 2;
            // 
            // cmbFilter
            // 
            cmbFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Segoe UI", 11F);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "ALL STATUS", "VACANT", "OCCUPIED", "MAINTENANCE" });
            cmbFilter.Location = new Point(913, 34);
            cmbFilter.Margin = new Padding(4, 5, 4, 5);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(96, 33);
            cmbFilter.TabIndex = 2;
            // 
            // picFilter
            // 
            picFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picFilter.Image = Properties.Resources.filter_icon;
            picFilter.Location = new Point(868, 34);
            picFilter.Margin = new Padding(4, 5, 4, 5);
            picFilter.Name = "picFilter";
            picFilter.Size = new Size(36, 43);
            picFilter.SizeMode = PictureBoxSizeMode.Zoom;
            picFilter.TabIndex = 1;
            picFilter.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(44, 62, 80);
            labelTitle.Location = new Point(26, 31);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(191, 35);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ALL UNITS";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 107);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(26, 0, 0, 0);
            flowLayoutPanel1.Size = new Size(1157, 813);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // UnitListControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlHeader);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UnitListControl";
            Size = new Size(1157, 920);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFilter).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox picFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
    }
}