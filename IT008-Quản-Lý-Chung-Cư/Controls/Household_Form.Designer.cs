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
            pnlTop.Size = new Size(932, 338);
            pnlTop.TabIndex = 0;
            // 
            // labelMembers
            // 
            labelMembers.Anchor = AnchorStyles.Top;
            labelMembers.Font = new Font("Arial", 11F, FontStyle.Bold);
            labelMembers.ForeColor = Color.FromArgb(40, 40, 40);
            labelMembers.Location = new Point(66, 289);
            labelMembers.Name = "labelMembers";
            labelMembers.Size = new Size(800, 27);
            labelMembers.TabIndex = 5;
            labelMembers.Text = "HOUSEHOLD MEMBERS";
            labelMembers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Top;
            txtNote.Font = new Font("Arial", 10F, FontStyle.Italic);
            txtNote.ForeColor = Color.FromArgb(120, 120, 120);
            txtNote.Location = new Point(66, 230);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(800, 25);
            txtNote.TabIndex = 4;
            txtNote.Text = "Note: Family...";
            txtNote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEndDate
            // 
            lblEndDate.Anchor = AnchorStyles.Top;
            lblEndDate.Font = new Font("Arial", 11F);
            lblEndDate.ForeColor = Color.FromArgb(80, 80, 80);
            lblEndDate.Location = new Point(66, 173);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(800, 27);
            lblEndDate.TabIndex = 3;
            lblEndDate.Text = "End Date: N/A";
            lblEndDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStartDate
            // 
            lblStartDate.Anchor = AnchorStyles.Top;
            lblStartDate.Font = new Font("Arial", 11F);
            lblStartDate.ForeColor = Color.FromArgb(80, 80, 80);
            lblStartDate.Location = new Point(66, 140);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(800, 27);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "Start Date: 11/11/2025";
            lblStartDate.TextAlign = ContentAlignment.MiddleCenter;
            lblStartDate.Click += lblStartDate_Click;
            // 
            // lblUnitCode
            // 
            lblUnitCode.Anchor = AnchorStyles.Top;
            lblUnitCode.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblUnitCode.ForeColor = Color.FromArgb(30, 30, 30);
            lblUnitCode.Location = new Point(66, 67);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(800, 60);
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
            btnClose.Location = new Point(23, 27);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(96, 23);
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
            pnlMembers.Location = new Point(0, 338);
            pnlMembers.Margin = new Padding(3, 4, 3, 4);
            pnlMembers.Name = "pnlMembers";
            pnlMembers.Padding = new Padding(34, 27, 0, 0);
            pnlMembers.Size = new Size(932, 462);
            pnlMembers.TabIndex = 1;
            pnlMembers.WrapContents = false;
            // 
            // Household_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(932, 800);
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
        private System.Windows.Forms.Label lblUnitCode;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label txtNote;
        private System.Windows.Forms.Label labelMembers;
        private System.Windows.Forms.FlowLayoutPanel pnlMembers;
    }
}