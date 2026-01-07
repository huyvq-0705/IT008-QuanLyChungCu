namespace IT008_Quản_Lý_Chung_Cư
{
    partial class Household_Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlTop = new Panel();
            btnEditHousehold = new Label();
            labelMembers = new Label();
            txtNote = new Label();
            lblEndDate = new Label();
            lblStartDate = new Label();
            lblUnitCode = new Label();
            btnClose = new Label();
            pnlMembers = new FlowLayoutPanel();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(btnEditHousehold);
            pnlTop.Controls.Add(labelMembers);
            pnlTop.Controls.Add(txtNote);
            pnlTop.Controls.Add(lblEndDate);
            pnlTop.Controls.Add(lblStartDate);
            pnlTop.Controls.Add(lblUnitCode);
            pnlTop.Controls.Add(btnClose);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1242, 320);
            pnlTop.TabIndex = 0;
            // 
            // btnEditHousehold
            // 
            btnEditHousehold.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditHousehold.AutoSize = true;
            btnEditHousehold.Cursor = Cursors.Hand;
            btnEditHousehold.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnEditHousehold.ForeColor = Color.FromArgb(52, 152, 219);
            btnEditHousehold.Location = new Point(1087, 25);
            btnEditHousehold.Name = "btnEditHousehold";
            btnEditHousehold.Padding = new Padding(5, 3, 5, 3);
            btnEditHousehold.Size = new Size(119, 25);
            btnEditHousehold.TabIndex = 6;
            btnEditHousehold.Text = "✎ EDIT INFO";
            btnEditHousehold.Click += btnEditHousehold_Click;
            // 
            // labelMembers
            // 
            labelMembers.Anchor = AnchorStyles.Top;
            labelMembers.Font = new Font("Arial", 12F, FontStyle.Bold);
            labelMembers.ForeColor = Color.FromArgb(40, 40, 40);
            labelMembers.Location = new Point(221, 270);
            labelMembers.Name = "labelMembers";
            labelMembers.Size = new Size(800, 30);
            labelMembers.TabIndex = 5;
            labelMembers.Text = "HOUSEHOLD MEMBERS";
            labelMembers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Top;
            txtNote.Font = new Font("Arial", 9.5F, FontStyle.Italic);
            txtNote.ForeColor = Color.FromArgb(120, 120, 120);
            txtNote.Location = new Point(221, 215);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(800, 40);
            txtNote.TabIndex = 4;
            txtNote.Text = "Note: Family...";
            txtNote.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblEndDate
            // 
            lblEndDate.Anchor = AnchorStyles.Top;
            lblEndDate.Font = new Font("Arial", 10.5F);
            lblEndDate.ForeColor = Color.FromArgb(80, 80, 80);
            lblEndDate.Location = new Point(221, 180);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(800, 25);
            lblEndDate.TabIndex = 3;
            lblEndDate.Text = "End Date: N/A";
            lblEndDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStartDate
            // 
            lblStartDate.Anchor = AnchorStyles.Top;
            lblStartDate.Font = new Font("Arial", 10.5F);
            lblStartDate.ForeColor = Color.FromArgb(80, 80, 80);
            lblStartDate.Location = new Point(221, 150);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(800, 25);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "Start Date: 11/11/2025";
            lblStartDate.TextAlign = ContentAlignment.MiddleCenter;
            lblStartDate.Click += lblStartDate_Click;
            // 
            // lblUnitCode
            // 
            lblUnitCode.Anchor = AnchorStyles.Top;
            lblUnitCode.Font = new Font("Arial", 22F, FontStyle.Bold);
            lblUnitCode.ForeColor = Color.FromArgb(30, 30, 30);
            lblUnitCode.Location = new Point(221, 75);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(800, 55);
            lblUnitCode.TabIndex = 1;
            lblUnitCode.Text = "Unit Code: A101";
            lblUnitCode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(100, 100, 100);
            btnClose.Location = new Point(25, 25);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(5, 3, 5, 3);
            btnClose.Size = new Size(110, 25);
            btnClose.TabIndex = 0;
            btnClose.Text = "← RETURN";
            btnClose.Click += btnClose_Click;
            // 
            // pnlMembers
            // 
            pnlMembers.AutoScroll = true;
            pnlMembers.BackColor = Color.FromArgb(248, 249, 250);
            pnlMembers.Dock = DockStyle.Fill;
            pnlMembers.FlowDirection = FlowDirection.TopDown;
            pnlMembers.Location = new Point(0, 320);
            pnlMembers.Margin = new Padding(3, 4, 3, 4);
            pnlMembers.Name = "pnlMembers";
            pnlMembers.Padding = new Padding(40, 30, 40, 30);
            pnlMembers.Size = new Size(1242, 480);
            pnlMembers.TabIndex = 1;
            pnlMembers.WrapContents = false;
            // 
            // Household_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1242, 800);
            Controls.Add(pnlMembers);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Household_Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Household Details";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label btnEditHousehold;
        private System.Windows.Forms.Label lblUnitCode;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label txtNote;
        private System.Windows.Forms.Label labelMembers;
        private System.Windows.Forms.FlowLayoutPanel pnlMembers;
    }
}