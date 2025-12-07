namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    partial class TicketListControl
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(26, 31);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(285, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "SERVICE TICKETS";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(26, 107);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1106, 782);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.BackColor = Color.ForestGreen;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(900, 23);
            btnCreate.Margin = new Padding(4, 5, 4, 5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(231, 61);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "CREATE NEW +";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // TicketListControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(btnCreate);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(labelTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TicketListControl";
            Size = new Size(1157, 920);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCreate;
    }
}