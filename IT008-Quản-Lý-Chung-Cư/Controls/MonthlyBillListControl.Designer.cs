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
            pnlHeader = new Panel();
            cmbFilter = new ComboBox();
            picFilter = new PictureBox();
            picTitleIcon = new PictureBox();
            labelTitle = new Label();
            btnCreate = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTitleIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.WhiteSmoke;
            pnlHeader.Controls.Add(cmbFilter);
            pnlHeader.Controls.Add(picFilter);
            pnlHeader.Controls.Add(picTitleIcon);
            pnlHeader.Controls.Add(labelTitle);
            pnlHeader.Controls.Add(btnCreate);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1157, 123);
            pnlHeader.TabIndex = 0;
            // 
            // cmbFilter
            // 
            cmbFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Arial", 11F);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "ALL STATUS", "PAID", "UNPAID" });
            cmbFilter.Location = new Point(655, 53);
            cmbFilter.Margin = new Padding(4, 5, 4, 5);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(217, 33);
            cmbFilter.TabIndex = 4;
            // 
            // picFilter
            // 
            picFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picFilter.Image = Properties.Resources.filter_icon;
            picFilter.Location = new Point(616, 51);
            picFilter.Margin = new Padding(4, 5, 4, 5);
            picFilter.Name = "picFilter";
            picFilter.Size = new Size(28, 36);
            picFilter.SizeMode = PictureBoxSizeMode.Zoom;
            picFilter.TabIndex = 3;
            picFilter.TabStop = false;
            // 
            // picTitleIcon
            // 
            picTitleIcon.Image = Properties.Resources.bill_icon;
            picTitleIcon.Location = new Point(26, 31);
            picTitleIcon.Margin = new Padding(4, 5, 4, 5);
            picTitleIcon.Name = "picTitleIcon";
            picTitleIcon.Size = new Size(51, 61);
            picTitleIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picTitleIcon.TabIndex = 1;
            picTitleIcon.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(44, 62, 80);
            labelTitle.Location = new Point(90, 50);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(329, 39);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "MONTHLY BILLS";
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.BackColor = Color.ForestGreen;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(900, 31);
            btnCreate.Margin = new Padding(4, 5, 4, 5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(231, 69);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "CREATE NEW +";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(240, 244, 248);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 123);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(26, 15, 0, 0);
            flowLayoutPanel1.Size = new Size(1157, 797);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // MonthlyBillListControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlHeader);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MonthlyBillListControl";
            Size = new Size(1157, 920);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTitleIcon).EndInit();
            ResumeLayout(false);

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