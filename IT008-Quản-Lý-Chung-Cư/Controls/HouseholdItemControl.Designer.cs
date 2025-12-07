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
            pnlCard = new Panel();
            picUserIcon = new PictureBox();
            picHouseholdIcon = new PictureBox();
            pnlLeftStrip = new Panel();
            lblUnitCode = new Label();
            lblOwner = new Label();
            btnView = new Button();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHouseholdIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(picUserIcon);
            pnlCard.Controls.Add(picHouseholdIcon);
            pnlCard.Controls.Add(pnlLeftStrip);
            pnlCard.Controls.Add(lblUnitCode);
            pnlCard.Controls.Add(lblOwner);
            pnlCard.Controls.Add(btnView);
            pnlCard.Dock = DockStyle.Fill;
            pnlCard.Location = new Point(0, 0);
            pnlCard.Margin = new Padding(4, 5, 4, 5);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(964, 131);
            pnlCard.TabIndex = 0;
            // 
            // picUserIcon
            // 
            picUserIcon.Image = Properties.Resources.staff_icon;
            picUserIcon.Location = new Point(112, 74);
            picUserIcon.Margin = new Padding(4, 5, 4, 5);
            picUserIcon.Name = "picUserIcon";
            picUserIcon.Size = new Size(21, 25);
            picUserIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picUserIcon.TabIndex = 3;
            picUserIcon.TabStop = false;
            // 
            // picHouseholdIcon
            // 
            picHouseholdIcon.Image = Properties.Resources.household_icon;
            picHouseholdIcon.Location = new Point(32, 34);
            picHouseholdIcon.Margin = new Padding(4, 5, 4, 5);
            picHouseholdIcon.Name = "picHouseholdIcon";
            picHouseholdIcon.Size = new Size(51, 61);
            picHouseholdIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picHouseholdIcon.TabIndex = 2;
            picHouseholdIcon.TabStop = false;
            // 
            // pnlLeftStrip
            // 
            pnlLeftStrip.BackColor = Color.FromArgb(52, 152, 219);
            pnlLeftStrip.Dock = DockStyle.Left;
            pnlLeftStrip.Location = new Point(0, 0);
            pnlLeftStrip.Margin = new Padding(4, 5, 4, 5);
            pnlLeftStrip.Name = "pnlLeftStrip";
            pnlLeftStrip.Size = new Size(8, 131);
            pnlLeftStrip.TabIndex = 0;
            // 
            // lblUnitCode
            // 
            lblUnitCode.AutoSize = true;
            lblUnitCode.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblUnitCode.ForeColor = Color.FromArgb(44, 62, 80);
            lblUnitCode.Location = new Point(103, 28);
            lblUnitCode.Margin = new Padding(4, 0, 4, 0);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(182, 30);
            lblUnitCode.TabIndex = 1;
            lblUnitCode.Text = "Unit Code: A101";
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOwner.ForeColor = Color.Gray;
            lblOwner.Location = new Point(142, 78);
            lblOwner.Margin = new Padding(4, 0, 4, 0);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(164, 20);
            lblOwner.TabIndex = 4;
            lblOwner.Text = "Owner: Truong Sinh";
            // 
            // btnView
            // 
            btnView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnView.BackColor = Color.FromArgb(52, 152, 219);
            btnView.Cursor = Cursors.Hand;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(771, 38);
            btnView.Margin = new Padding(4, 5, 4, 5);
            btnView.Name = "btnView";
            btnView.Size = new Size(154, 54);
            btnView.TabIndex = 2;
            btnView.Text = "VIEW MORE";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // HouseholdItemControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlCard);
            Margin = new Padding(4, 5, 4, 5);
            Name = "HouseholdItemControl";
            Padding = new Padding(0, 0, 0, 15);
            Size = new Size(964, 146);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHouseholdIcon).EndInit();
            ResumeLayout(false);

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