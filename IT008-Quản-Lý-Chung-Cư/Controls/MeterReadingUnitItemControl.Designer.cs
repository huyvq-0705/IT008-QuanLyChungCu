namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    partial class MeterReadingUnitItemControl
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
            picMeterIcon = new PictureBox();
            panelLeftStrip = new Panel();
            lblUnitCode = new Label();
            lblOwner = new Label();
            btnView = new Button();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMeterIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(picUserIcon);
            pnlCard.Controls.Add(picMeterIcon);
            pnlCard.Controls.Add(panelLeftStrip);
            pnlCard.Controls.Add(lblUnitCode);
            pnlCard.Controls.Add(lblOwner);
            pnlCard.Controls.Add(btnView);
            pnlCard.Dock = DockStyle.Fill;
            pnlCard.Location = new Point(0, 0);
            pnlCard.Margin = new Padding(3, 5, 3, 5);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(1092, 146);
            pnlCard.TabIndex = 0;
            // 
            // picUserIcon
            // 
            picUserIcon.Image = Properties.Resources.User_Icon;
            picUserIcon.Location = new Point(102, 74);
            picUserIcon.Margin = new Padding(3, 5, 3, 5);
            picUserIcon.Name = "picUserIcon";
            picUserIcon.Size = new Size(20, 24);
            picUserIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picUserIcon.TabIndex = 3;
            picUserIcon.TabStop = false;
            // 
            // picMeterIcon
            // 
            picMeterIcon.Image = Properties.Resources.meter_icon;
            picMeterIcon.Location = new Point(33, 33);
            picMeterIcon.Margin = new Padding(3, 5, 3, 5);
            picMeterIcon.Name = "picMeterIcon";
            picMeterIcon.Size = new Size(52, 61);
            picMeterIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picMeterIcon.TabIndex = 2;
            picMeterIcon.TabStop = false;
            // 
            // panelLeftStrip
            // 
            panelLeftStrip.BackColor = Color.FromArgb(52, 152, 219);
            panelLeftStrip.Dock = DockStyle.Left;
            panelLeftStrip.Location = new Point(0, 0);
            panelLeftStrip.Margin = new Padding(3, 5, 3, 5);
            panelLeftStrip.Name = "panelLeftStrip";
            panelLeftStrip.Size = new Size(8, 146);
            panelLeftStrip.TabIndex = 0;
            // 
            // lblUnitCode
            // 
            lblUnitCode.AutoSize = true;
            lblUnitCode.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblUnitCode.ForeColor = Color.FromArgb(44, 62, 80);
            lblUnitCode.Location = new Point(102, 28);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(182, 30);
            lblUnitCode.TabIndex = 1;
            lblUnitCode.Text = "Unit Code: A101";
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOwner.ForeColor = Color.Gray;
            lblOwner.Location = new Point(128, 70);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(173, 21);
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
            btnView.Location = new Point(919, 38);
            btnView.Margin = new Padding(3, 5, 3, 5);
            btnView.Name = "btnView";
            btnView.Size = new Size(154, 54);
            btnView.TabIndex = 2;
            btnView.Text = "VIEW MORE";
            btnView.UseVisualStyleBackColor = false;
            // 
            // MeterReadingUnitItemControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlCard);
            Margin = new Padding(0, 0, 0, 15);
            Name = "MeterReadingUnitItemControl";
            Size = new Size(1092, 146);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMeterIcon).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel panelLeftStrip;
        private System.Windows.Forms.Label lblUnitCode;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.PictureBox picMeterIcon;
        private System.Windows.Forms.PictureBox picUserIcon;
    }
}