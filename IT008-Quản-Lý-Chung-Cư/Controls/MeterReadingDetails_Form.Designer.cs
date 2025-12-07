namespace IT008_Quản_Lý_Chung_Cư
{
    partial class MeterReadingDetails_Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblReturn = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblUnitCode = new Label();
            pnlHistory = new FlowLayoutPanel();
            btnCreate = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // lblReturn
            // 
            lblReturn.BackColor = Color.Transparent;
            lblReturn.Cursor = Cursors.Hand;
            lblReturn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReturn.Location = new Point(26, 31);
            lblReturn.Name = "lblReturn";
            lblReturn.Size = new Size(89, 25);
            lblReturn.TabIndex = 0;
            lblReturn.Text = "← RETURN";
            lblReturn.Click += lblReturn_Click;
            // 
            // lblUnitCode
            // 
            lblUnitCode.AutoSize = true;
            lblUnitCode.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblUnitCode.ForeColor = Color.FromArgb(41, 50, 65);
            lblUnitCode.Location = new Point(26, 85);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(310, 46);
            lblUnitCode.TabIndex = 1;
            lblUnitCode.Text = "METER READINGS";
            // 
            // pnlHistory
            // 
            pnlHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlHistory.AutoScroll = true;
            pnlHistory.FlowDirection = FlowDirection.TopDown;
            pnlHistory.Location = new Point(32, 184);
            pnlHistory.Margin = new Padding(4, 5, 4, 5);
            pnlHistory.Name = "pnlHistory";
            pnlHistory.Padding = new Padding(5);
            pnlHistory.Size = new Size(964, 460);
            pnlHistory.TabIndex = 2;
            pnlHistory.WrapContents = false;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Bottom;
            btnCreate.BorderRadius = 12;
            btnCreate.CustomizableEdges = customizableEdges1;
            btnCreate.DisabledState.BorderColor = Color.DarkGray;
            btnCreate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCreate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCreate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCreate.FillColor = Color.ForestGreen;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(321, 690);
            btnCreate.Margin = new Padding(4, 5, 4, 5);
            btnCreate.Name = "btnCreate";
            btnCreate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCreate.Size = new Size(386, 77);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "CREATE NEW +";
            btnCreate.Click += btnCreate_Click;
            // 
            // MeterReadingDetails_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 813);
            Controls.Add(btnCreate);
            Controls.Add(pnlHistory);
            Controls.Add(lblUnitCode);
            Controls.Add(lblReturn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MeterReadingDetails_Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Meter Readings";
            ResumeLayout(false);
            PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2HtmlLabel lblReturn;
        private System.Windows.Forms.Label lblUnitCode;
        private System.Windows.Forms.FlowLayoutPanel pnlHistory;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
    }
}