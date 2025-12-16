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
            pnlHeader.Size = new Size(643, 92);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(643, 92);
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
            pnlMain.Location = new Point(0, 92);
            pnlMain.Margin = new Padding(4, 5, 4, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(39, 31, 39, 31);
            pnlMain.Size = new Size(643, 752);
            pnlMain.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 9F);
            label1.ForeColor = Color.FromArgb(80, 80, 80);
            label1.Location = new Point(39, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 18);
            label1.TabIndex = 0;
            label1.Text = "Unit";
            // 
            // cbUnit
            // 
            cbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnit.Font = new Font("Arial", 10F);
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(39, 61);
            cbUnit.Margin = new Padding(4, 5, 4, 5);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(169, 31);
            cbUnit.TabIndex = 1;
            cbUnit.SelectedIndexChanged += cbUnit_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 9F);
            label2.ForeColor = Color.FromArgb(80, 80, 80);
            label2.Location = new Point(347, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 2;
            label2.Text = "Month";
            // 
            // dtpMonth
            // 
            dtpMonth.CustomFormat = "MM/yyyy";
            dtpMonth.Font = new Font("Arial", 10F);
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.Location = new Point(347, 61);
            dtpMonth.Margin = new Padding(4, 5, 4, 5);
            dtpMonth.Name = "dtpMonth";
            dtpMonth.Size = new Size(156, 30);
            dtpMonth.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtRent);
            groupBox1.Font = new Font("Georgia", 9F);
            groupBox1.ForeColor = Color.FromArgb(40, 40, 40);
            groupBox1.Location = new Point(39, 130);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(19, 15, 19, 23);
            groupBox1.Size = new Size(527, 115);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Monthly Rent";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 9F);
            label3.ForeColor = Color.FromArgb(80, 80, 80);
            label3.Location = new Point(19, 54);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 18);
            label3.TabIndex = 0;
            label3.Text = "Amount";
            // 
            // txtRent
            // 
            txtRent.Enabled = false;
            txtRent.Font = new Font("Arial", 11F, FontStyle.Bold);
            txtRent.Location = new Point(154, 49);
            txtRent.Margin = new Padding(4, 5, 4, 5);
            txtRent.Name = "txtRent";
            txtRent.Size = new Size(346, 32);
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
            groupBox2.Font = new Font("Georgia", 9F);
            groupBox2.ForeColor = Color.FromArgb(40, 40, 40);
            groupBox2.Location = new Point(39, 268);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(19, 15, 19, 23);
            groupBox2.Size = new Size(527, 161);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Electricity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 9F);
            label4.ForeColor = Color.FromArgb(80, 80, 80);
            label4.Location = new Point(19, 54);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 18);
            label4.TabIndex = 0;
            label4.Text = "Usage (kWh)";
            // 
            // txtElecUsage
            // 
            txtElecUsage.Font = new Font("Arial", 10F);
            txtElecUsage.Location = new Point(154, 49);
            txtElecUsage.Margin = new Padding(4, 5, 4, 5);
            txtElecUsage.Name = "txtElecUsage";
            txtElecUsage.PlaceholderText = "0";
            txtElecUsage.Size = new Size(127, 30);
            txtElecUsage.TabIndex = 1;
            txtElecUsage.TextAlign = HorizontalAlignment.Right;
            txtElecUsage.TextChanged += CalculateTotal;
            // 
            // lblElecRate
            // 
            lblElecRate.AutoSize = true;
            lblElecRate.Font = new Font("Arial", 8F, FontStyle.Italic);
            lblElecRate.ForeColor = Color.FromArgb(108, 117, 125);
            lblElecRate.Location = new Point(154, 95);
            lblElecRate.Margin = new Padding(4, 0, 4, 0);
            lblElecRate.Name = "lblElecRate";
            lblElecRate.Size = new Size(120, 19);
            lblElecRate.TabIndex = 2;
            lblElecRate.Text = "Rate: 0 VND/kWh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F);
            label5.ForeColor = Color.FromArgb(80, 80, 80);
            label5.Location = new Point(309, 54);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 3;
            label5.Text = "Total";
            // 
            // txtElecTotal
            // 
            txtElecTotal.Enabled = false;
            txtElecTotal.Font = new Font("Arial", 10F, FontStyle.Bold);
            txtElecTotal.Location = new Point(360, 49);
            txtElecTotal.Margin = new Padding(4, 5, 4, 5);
            txtElecTotal.Name = "txtElecTotal";
            txtElecTotal.Size = new Size(140, 30);
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
            groupBox3.Font = new Font("Georgia", 9F);
            groupBox3.ForeColor = Color.FromArgb(40, 40, 40);
            groupBox3.Location = new Point(39, 452);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(19, 15, 19, 23);
            groupBox3.Size = new Size(527, 161);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Water";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 9F);
            label8.ForeColor = Color.FromArgb(80, 80, 80);
            label8.Location = new Point(19, 54);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(87, 18);
            label8.TabIndex = 0;
            label8.Text = "Usage (m³)";
            // 
            // txtWaterUsage
            // 
            txtWaterUsage.Font = new Font("Arial", 10F);
            txtWaterUsage.Location = new Point(154, 49);
            txtWaterUsage.Margin = new Padding(4, 5, 4, 5);
            txtWaterUsage.Name = "txtWaterUsage";
            txtWaterUsage.PlaceholderText = "0";
            txtWaterUsage.Size = new Size(127, 30);
            txtWaterUsage.TabIndex = 1;
            txtWaterUsage.TextAlign = HorizontalAlignment.Right;
            txtWaterUsage.TextChanged += CalculateTotal;
            // 
            // lblWaterRate
            // 
            lblWaterRate.AutoSize = true;
            lblWaterRate.Font = new Font("Arial", 8F, FontStyle.Italic);
            lblWaterRate.ForeColor = Color.FromArgb(108, 117, 125);
            lblWaterRate.Location = new Point(154, 95);
            lblWaterRate.Margin = new Padding(4, 0, 4, 0);
            lblWaterRate.Name = "lblWaterRate";
            lblWaterRate.Size = new Size(109, 19);
            lblWaterRate.TabIndex = 2;
            lblWaterRate.Text = "Rate: 0 VND/m³";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F);
            label7.ForeColor = Color.FromArgb(80, 80, 80);
            label7.Location = new Point(309, 54);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 3;
            label7.Text = "Total";
            // 
            // txtWaterTotal
            // 
            txtWaterTotal.Enabled = false;
            txtWaterTotal.Font = new Font("Arial", 10F, FontStyle.Bold);
            txtWaterTotal.Location = new Point(360, 49);
            txtWaterTotal.Margin = new Padding(4, 5, 4, 5);
            txtWaterTotal.Name = "txtWaterTotal";
            txtWaterTotal.Size = new Size(140, 30);
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
            pnlSummary.Location = new Point(39, 636);
            pnlSummary.Margin = new Padding(4, 5, 4, 5);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Padding = new Padding(19, 23, 19, 23);
            pnlSummary.Size = new Size(527, 123);
            pnlSummary.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 9F);
            label9.ForeColor = Color.FromArgb(80, 80, 80);
            label9.Location = new Point(19, 31);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(91, 18);
            label9.TabIndex = 0;
            label9.Text = "Adjustments";
            // 
            // txtAdjust
            // 
            txtAdjust.Font = new Font("Arial", 10F);
            txtAdjust.Location = new Point(135, 26);
            txtAdjust.Margin = new Padding(4, 5, 4, 5);
            txtAdjust.Name = "txtAdjust";
            txtAdjust.PlaceholderText = "0";
            txtAdjust.Size = new Size(127, 30);
            txtAdjust.TabIndex = 1;
            txtAdjust.TextAlign = HorizontalAlignment.Right;
            txtAdjust.TextChanged += CalculateTotal;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Arial", 12F, FontStyle.Bold);
            labelTotal.ForeColor = Color.FromArgb(40, 40, 40);
            labelTotal.Location = new Point(19, 77);
            labelTotal.Margin = new Padding(4, 0, 4, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(77, 28);
            labelTotal.TabIndex = 2;
            labelTotal.Text = "TOTAL:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.FromArgb(0, 123, 255);
            lblTotalAmount.Location = new Point(135, 69);
            lblTotalAmount.Margin = new Padding(4, 0, 4, 0);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(366, 46);
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
            pnlFooter.Location = new Point(0, 844);
            pnlFooter.Margin = new Padding(4, 5, 4, 5);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new Padding(39, 23, 39, 23);
            pnlFooter.Size = new Size(643, 107);
            pnlFooter.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(248, 249, 250);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(222, 226, 230);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial", 10F);
            btnCancel.ForeColor = Color.FromArgb(80, 80, 80);
            btnCancel.Location = new Point(39, 23);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 61);
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
            btnSave.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(450, 23);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 61);
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
            ClientSize = new Size(643, 951);
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

        private System.Windows.Forms.ComboBox cmbMonthFilter;

    }
}
