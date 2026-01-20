namespace IT008_Quản_Lý_Chung_Cư
{
    partial class MonthlyBill_Form
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlMain = new Panel();
            label1 = new Label();
            cbUnit = new ComboBox();
            label2 = new Label();
            dtpMonth = new DateTimePicker();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtRent = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtElecUsage = new TextBox();
            lblElecRate = new Label();
            label5 = new Label();
            txtElecTotal = new TextBox();
            groupBox3 = new GroupBox();
            label8 = new Label();
            txtWaterUsage = new TextBox();
            lblWaterRate = new Label();
            label7 = new Label();
            txtWaterTotal = new TextBox();
            pnlSummary = new Panel();
            label9 = new Label();
            txtAdjust = new TextBox();
            labelTotal = new Label();
            lblTotalAmount = new Label();
            pnlFooter = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            pnlSummary.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(700, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Georgia", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 100);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Monthly Bill";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.BackColor = Color.FromArgb(248, 249, 250);
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(cbUnit);
            pnlMain.Controls.Add(label2);
            pnlMain.Controls.Add(dtpMonth);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Controls.Add(groupBox2);
            pnlMain.Controls.Add(groupBox3);
            pnlMain.Controls.Add(pnlSummary);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 100);
            pnlMain.Margin = new Padding(4, 5, 4, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(40, 35, 40, 35);
            pnlMain.Size = new Size(700, 730);
            pnlMain.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10F);
            label1.ForeColor = Color.FromArgb(80, 80, 80);
            label1.Location = new Point(40, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "Unit";
            // 
            // cbUnit
            // 
            cbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnit.Font = new Font("Arial", 10.5F);
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(40, 65);
            cbUnit.Margin = new Padding(4, 5, 4, 5);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(200, 32);
            cbUnit.TabIndex = 1;
            cbUnit.SelectedIndexChanged += cbUnit_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10F);
            label2.ForeColor = Color.FromArgb(80, 80, 80);
            label2.Location = new Point(360, 35);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Month";
            // 
            // dtpMonth
            // 
            dtpMonth.CustomFormat = "MM/yyyy";
            dtpMonth.Font = new Font("Arial", 10.5F);
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.Location = new Point(360, 65);
            dtpMonth.Margin = new Padding(4, 5, 4, 5);
            dtpMonth.Name = "dtpMonth";
            dtpMonth.Size = new Size(180, 32);
            dtpMonth.TabIndex = 3;
            dtpMonth.ValueChanged += dtpMonth_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtRent);
            groupBox1.Font = new Font("Georgia", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(40, 40, 40);
            groupBox1.Location = new Point(40, 140);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(20, 18, 20, 25);
            groupBox1.Size = new Size(620, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Monthly Rent";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 9.5F);
            label3.ForeColor = Color.FromArgb(80, 80, 80);
            label3.Location = new Point(20, 60);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Amount";
            // 
            // txtRent
            // 
            txtRent.BackColor = Color.FromArgb(250, 250, 250);
            txtRent.Enabled = false;
            txtRent.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtRent.Location = new Point(170, 55);
            txtRent.Margin = new Padding(4, 5, 4, 5);
            txtRent.Name = "txtRent";
            txtRent.Size = new Size(420, 35);
            txtRent.TabIndex = 1;
            txtRent.TextAlign = HorizontalAlignment.Right;
            txtRent.TextChanged += CalculateTotal;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtElecUsage);
            groupBox2.Controls.Add(lblElecRate);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtElecTotal);
            groupBox2.Font = new Font("Georgia", 10F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(40, 40, 40);
            groupBox2.Location = new Point(40, 290);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(20, 18, 20, 25);
            groupBox2.Size = new Size(620, 175);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Electricity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 9.5F);
            label4.ForeColor = Color.FromArgb(80, 80, 80);
            label4.Location = new Point(20, 60);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 0;
            label4.Text = "Usage (kWh)";
            // 
            // txtElecUsage
            // 
            txtElecUsage.Font = new Font("Arial", 11F);
            txtElecUsage.Location = new Point(170, 55);
            txtElecUsage.Margin = new Padding(4, 5, 4, 5);
            txtElecUsage.Name = "txtElecUsage";
            txtElecUsage.PlaceholderText = "0";
            txtElecUsage.Size = new Size(150, 33);
            txtElecUsage.TabIndex = 1;
            txtElecUsage.TextAlign = HorizontalAlignment.Right;
            txtElecUsage.TextChanged += CalculateTotal;
            // 
            // lblElecRate
            // 
            lblElecRate.AutoSize = true;
            lblElecRate.Font = new Font("Arial", 8.5F, FontStyle.Italic);
            lblElecRate.ForeColor = Color.FromArgb(108, 117, 125);
            lblElecRate.Location = new Point(170, 105);
            lblElecRate.Margin = new Padding(4, 0, 4, 0);
            lblElecRate.Name = "lblElecRate";
            lblElecRate.Size = new Size(130, 20);
            lblElecRate.TabIndex = 2;
            lblElecRate.Text = "Rate: 0 VND/kWh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 9.5F);
            label5.ForeColor = Color.FromArgb(80, 80, 80);
            label5.Location = new Point(350, 60);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 3;
            label5.Text = "Total";
            // 
            // txtElecTotal
            // 
            txtElecTotal.BackColor = Color.FromArgb(250, 250, 250);
            txtElecTotal.Enabled = false;
            txtElecTotal.Font = new Font("Arial", 11F, FontStyle.Bold);
            txtElecTotal.Location = new Point(420, 55);
            txtElecTotal.Margin = new Padding(4, 5, 4, 5);
            txtElecTotal.Name = "txtElecTotal";
            txtElecTotal.Size = new Size(170, 33);
            txtElecTotal.TabIndex = 4;
            txtElecTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtWaterUsage);
            groupBox3.Controls.Add(lblWaterRate);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtWaterTotal);
            groupBox3.Font = new Font("Georgia", 10F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(40, 40, 40);
            groupBox3.Location = new Point(40, 490);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(20, 18, 20, 25);
            groupBox3.Size = new Size(620, 175);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Water";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 9.5F);
            label8.ForeColor = Color.FromArgb(80, 80, 80);
            label8.Location = new Point(20, 60);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 0;
            label8.Text = "Usage (m³)";
            // 
            // txtWaterUsage
            // 
            txtWaterUsage.Font = new Font("Arial", 11F);
            txtWaterUsage.Location = new Point(170, 55);
            txtWaterUsage.Margin = new Padding(4, 5, 4, 5);
            txtWaterUsage.Name = "txtWaterUsage";
            txtWaterUsage.PlaceholderText = "0";
            txtWaterUsage.Size = new Size(150, 33);
            txtWaterUsage.TabIndex = 1;
            txtWaterUsage.TextAlign = HorizontalAlignment.Right;
            txtWaterUsage.TextChanged += CalculateTotal;
            // 
            // lblWaterRate
            // 
            lblWaterRate.AutoSize = true;
            lblWaterRate.Font = new Font("Arial", 8.5F, FontStyle.Italic);
            lblWaterRate.ForeColor = Color.FromArgb(108, 117, 125);
            lblWaterRate.Location = new Point(170, 105);
            lblWaterRate.Margin = new Padding(4, 0, 4, 0);
            lblWaterRate.Name = "lblWaterRate";
            lblWaterRate.Size = new Size(119, 20);
            lblWaterRate.TabIndex = 2;
            lblWaterRate.Text = "Rate: 0 VND/m³";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 9.5F);
            label7.ForeColor = Color.FromArgb(80, 80, 80);
            label7.Location = new Point(350, 60);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 3;
            label7.Text = "Total";
            // 
            // txtWaterTotal
            // 
            txtWaterTotal.BackColor = Color.FromArgb(250, 250, 250);
            txtWaterTotal.Enabled = false;
            txtWaterTotal.Font = new Font("Arial", 11F, FontStyle.Bold);
            txtWaterTotal.Location = new Point(420, 55);
            txtWaterTotal.Margin = new Padding(4, 5, 4, 5);
            txtWaterTotal.Name = "txtWaterTotal";
            txtWaterTotal.Size = new Size(170, 33);
            txtWaterTotal.TabIndex = 4;
            txtWaterTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = Color.White;
            pnlSummary.Controls.Add(label9);
            pnlSummary.Controls.Add(txtAdjust);
            pnlSummary.Controls.Add(labelTotal);
            pnlSummary.Controls.Add(lblTotalAmount);
            pnlSummary.Location = new Point(40, 690);
            pnlSummary.Margin = new Padding(4, 5, 4, 5);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Padding = new Padding(20, 25, 20, 25);
            pnlSummary.Size = new Size(620, 135);
            pnlSummary.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 9.5F);
            label9.ForeColor = Color.FromArgb(80, 80, 80);
            label9.Location = new Point(20, 35);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 0;
            label9.Text = "Adjustments";
            // 
            // txtAdjust
            // 
            txtAdjust.Font = new Font("Arial", 11F);
            txtAdjust.Location = new Point(150, 30);
            txtAdjust.Margin = new Padding(4, 5, 4, 5);
            txtAdjust.Name = "txtAdjust";
            txtAdjust.PlaceholderText = "0";
            txtAdjust.Size = new Size(150, 33);
            txtAdjust.TabIndex = 1;
            txtAdjust.TextAlign = HorizontalAlignment.Right;
            txtAdjust.TextChanged += CalculateTotal;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Arial", 12F, FontStyle.Bold);
            labelTotal.ForeColor = Color.FromArgb(40, 40, 40);
            labelTotal.Location = new Point(20, 85);
            labelTotal.Margin = new Padding(4, 0, 4, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(77, 28);
            labelTotal.TabIndex = 2;
            labelTotal.Text = "TOTAL:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Font = new Font("Arial", 17F, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.FromArgb(0, 123, 255);
            lblTotalAmount.Location = new Point(150, 75);
            lblTotalAmount.Margin = new Padding(4, 0, 4, 0);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(450, 50);
            lblTotalAmount.TabIndex = 3;
            lblTotalAmount.Text = "0 VND";
            lblTotalAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.White;
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 830);
            pnlFooter.Margin = new Padding(4, 5, 4, 5);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new Padding(40, 25, 40, 25);
            pnlFooter.Size = new Size(700, 115);
            pnlFooter.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(248, 249, 250);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(222, 226, 230);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial", 10.5F);
            btnCancel.ForeColor = Color.FromArgb(80, 80, 80);
            btnCancel.Location = new Point(40, 25);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 65);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 123, 255);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(500, 25);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 65);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE BILL";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // MonthlyBill_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 945);
            Controls.Add(pnlMain);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MonthlyBill_Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Monthly Bill";
            pnlHeader.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtElecUsage;
        private System.Windows.Forms.Label lblElecRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtElecTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWaterUsage;
        private System.Windows.Forms.Label lblWaterRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWaterTotal;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAdjust;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}