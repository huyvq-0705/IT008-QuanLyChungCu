namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    partial class MonthlyBillListControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            btnMonthToggle = new Button();
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
            pnlHeader.Controls.Add(btnMonthToggle);
            pnlHeader.Controls.Add(cmbFilter);
            pnlHeader.Controls.Add(picFilter);
            pnlHeader.Controls.Add(picTitleIcon);
            pnlHeader.Controls.Add(labelTitle);
            pnlHeader.Controls.Add(btnCreate);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1028, 107);
            pnlHeader.TabIndex = 1;
            // 
            // btnMonthToggle
            // 
            btnMonthToggle.FlatStyle = FlatStyle.Flat;
            btnMonthToggle.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnMonthToggle.Location = new Point(418, 46);
            btnMonthToggle.Name = "btnMonthToggle";
            btnMonthToggle.Size = new Size(124, 31);
            btnMonthToggle.TabIndex = 0;
            btnMonthToggle.Click += btnMonthToggle_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Arial", 11F);
            cmbFilter.Items.AddRange(new object[] { "ALL STATUS", "PAID", "UNPAID" });
            cmbFilter.Location = new Point(582, 46);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(193, 29);
            cmbFilter.TabIndex = 1;
            // 
            // picFilter
            // 
            picFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picFilter.Image = Properties.Resources.filter_icon;
            picFilter.Location = new Point(548, 44);
            picFilter.Name = "picFilter";
            picFilter.Size = new Size(25, 31);
            picFilter.SizeMode = PictureBoxSizeMode.Zoom;
            picFilter.TabIndex = 2;
            picFilter.TabStop = false;
            // 
            // picTitleIcon
            // 
            picTitleIcon.Image = Properties.Resources.bill_icon;
            picTitleIcon.Location = new Point(23, 27);
            picTitleIcon.Name = "picTitleIcon";
            picTitleIcon.Size = new Size(45, 53);
            picTitleIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picTitleIcon.TabIndex = 3;
            picTitleIcon.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Georgia", 19.8F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(44, 62, 80);
            labelTitle.Location = new Point(80, 43);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(321, 38);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "MONTHLY BILLS";
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.BackColor = Color.ForestGreen;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(800, 27);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(205, 60);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "CREATE NEW +";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(240, 244, 248);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 107);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(23, 13, 0, 0);
            flowLayoutPanel1.Size = new Size(1028, 693);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // MonthlyBillListControl
            // 
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlHeader);
            Name = "MonthlyBillListControl";
            Size = new Size(1028, 800);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTitleIcon).EndInit();
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private PictureBox picTitleIcon;
        private Label labelTitle;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCreate;
        private PictureBox picFilter;
        private ComboBox cmbFilter;
        private Button btnMonthToggle;
    }
}
