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
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblUnitCode = new System.Windows.Forms.Label();
            this.pnlHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReturn.Location = new System.Drawing.Point(20, 20);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(78, 19);
            this.lblReturn.TabIndex = 0;
            this.lblReturn.Text = "← RETURN";
            this.lblReturn.Click += new System.EventHandler(this.lblReturn_Click);
            // 
            // lblUnitCode
            // 
            this.lblUnitCode.AutoSize = true;
            this.lblUnitCode.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblUnitCode.Location = new System.Drawing.Point(20, 60);
            this.lblUnitCode.Name = "lblUnitCode";
            this.lblUnitCode.Size = new System.Drawing.Size(195, 30);
            this.lblUnitCode.TabIndex = 1;
            this.lblUnitCode.Text = "UNIT_CODE: A101";
            // 
            // pnlHistory
            // 
            this.pnlHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHistory.AutoScroll = true;
            this.pnlHistory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlHistory.Location = new System.Drawing.Point(25, 120);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(750, 300);
            this.pnlHistory.TabIndex = 2;
            this.pnlHistory.WrapContents = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreate.BackColor = System.Drawing.Color.Black;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(250, 450);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(300, 50);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "CREATE NEW +";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // MeterReadingDetails_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pnlHistory);
            this.Controls.Add(this.lblUnitCode);
            this.Controls.Add(this.lblReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MeterReadingDetails_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Meter Readings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblUnitCode;
        private System.Windows.Forms.FlowLayoutPanel pnlHistory;
        private System.Windows.Forms.Button btnCreate;
    }
}