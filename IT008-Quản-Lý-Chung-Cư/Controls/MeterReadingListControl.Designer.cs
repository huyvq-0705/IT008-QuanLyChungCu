namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    partial class MeterReadingListControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(26, 31);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(299, 35);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "METER READING";
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
            // MeterReadingListControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(labelTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MeterReadingListControl";
            Size = new Size(1157, 920);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}