namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    partial class UnitItemControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelStatusStrip = new Panel();
            panelActions = new Panel();
            btnViewMore = new Button();
            panelContent = new Panel();
            picUnitIcon = new PictureBox();
            lblDetails = new Label();
            lblStatus = new Label();
            lblUnitCode = new Label();
            panelActions.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUnitIcon).BeginInit();
            SuspendLayout();
            // 
            // panelStatusStrip
            // 
            panelStatusStrip.BackColor = Color.Orange;
            panelStatusStrip.Dock = DockStyle.Left;
            panelStatusStrip.Location = new Point(0, 0);
            panelStatusStrip.Margin = new Padding(4, 5, 4, 5);
            panelStatusStrip.Name = "panelStatusStrip";
            panelStatusStrip.Size = new Size(20, 148);
            panelStatusStrip.TabIndex = 0;
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnViewMore);
            panelActions.Dock = DockStyle.Right;
            panelActions.Location = new Point(761, 0);
            panelActions.Margin = new Padding(4, 5, 4, 5);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(203, 148);
            panelActions.TabIndex = 2;
            // 
            // btnViewMore
            // 
            btnViewMore.BackColor = Color.White;
            btnViewMore.Cursor = Cursors.Hand;
            btnViewMore.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnViewMore.FlatAppearance.BorderSize = 4;
            btnViewMore.FlatStyle = FlatStyle.Flat;
            btnViewMore.Font = new Font("Arial Semibold", 9F, FontStyle.Bold);
            btnViewMore.ForeColor = Color.Black;
            btnViewMore.Location = new Point(33, 48);
            btnViewMore.Margin = new Padding(4, 5, 4, 5);
            btnViewMore.Name = "btnViewMore";
            btnViewMore.Size = new Size(140, 55);
            btnViewMore.TabIndex = 0;
            btnViewMore.Text = "DETAILS";
            btnViewMore.UseVisualStyleBackColor = false;
            btnViewMore.Click += btnViewMore_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(picUnitIcon);
            panelContent.Controls.Add(lblDetails);
            panelContent.Controls.Add(lblStatus);
            panelContent.Controls.Add(lblUnitCode);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(20, 0);
            panelContent.Margin = new Padding(4, 5, 4, 5);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(19, 15, 13, 15);
            panelContent.Size = new Size(741, 148);
            panelContent.TabIndex = 1;
            // 
            // picUnitIcon
            // 
            picUnitIcon.Image = Properties.Resources.unit_icon;
            picUnitIcon.Location = new Point(26, 46);
            picUnitIcon.Margin = new Padding(4, 5, 4, 5);
            picUnitIcon.Name = "picUnitIcon";
            picUnitIcon.Size = new Size(51, 61);
            picUnitIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picUnitIcon.TabIndex = 3;
            picUnitIcon.TabStop = false;
            // 
            // lblDetails
            // 
            lblDetails.AutoEllipsis = true;
            lblDetails.Font = new Font("Arial", 10F);
            lblDetails.ForeColor = Color.Gray;
            lblDetails.Location = new Point(90, 69);
            lblDetails.Margin = new Padding(4, 0, 4, 0);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(614, 38);
            lblDetails.TabIndex = 1;
            lblDetails.Text = "Floor 1  •  Studio";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(64, 64, 64);
            lblStatus.Location = new Point(90, 112);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(82, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "OCCUPIED";
            // 
            // lblUnitCode
            // 
            lblUnitCode.AutoEllipsis = true;
            lblUnitCode.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            lblUnitCode.ForeColor = Color.FromArgb(50, 50, 50);
            lblUnitCode.Location = new Point(90, 15);
            lblUnitCode.Margin = new Padding(4, 0, 4, 0);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(645, 54);
            lblUnitCode.TabIndex = 0;
            lblUnitCode.Text = "Unit: A101";
            // 
            // UnitItemControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelContent);
            Controls.Add(panelActions);
            Controls.Add(panelStatusStrip);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UnitItemControl";
            Padding = new Padding(0, 0, 0, 2);
            Size = new Size(964, 150);
            panelActions.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUnitIcon).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelStatusStrip;
        private System.Windows.Forms.Panel panelActions; // Container for Button
        private System.Windows.Forms.Panel panelContent; // Container for Text
        private System.Windows.Forms.Button btnViewMore;
        private System.Windows.Forms.Label lblUnitCode;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox picUnitIcon;
    }
}