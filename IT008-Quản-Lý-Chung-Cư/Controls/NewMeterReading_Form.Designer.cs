namespace IT008_Quản_Lý_Chung_Cư
{
    partial class NewMeterReading_Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            label1 = new Label();
            dtpMonth = new DateTimePicker();
            label2 = new Label();
            txtElec = new TextBox();
            label3 = new Label();
            txtWater = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(450, 77);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "New Meter Reading";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.2F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(39, 107);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 1;
            label1.Text = "Select Month";
            // 
            // dtpMonth
            // 
            dtpMonth.CustomFormat = "MM/yyyy";
            dtpMonth.Font = new Font("Arial", 10F);
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.Location = new Point(39, 138);
            dtpMonth.Margin = new Padding(4, 5, 4, 5);
            dtpMonth.Name = "dtpMonth";
            dtpMonth.Size = new Size(359, 30);
            dtpMonth.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(39, 215);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(247, 20);
            label2.TabIndex = 3;
            label2.Text = "Electricity Consumption (KWh)";
            // 
            // txtElec
            // 
            txtElec.Font = new Font("Arial", 10F);
            txtElec.Location = new Point(39, 245);
            txtElec.Margin = new Padding(4, 5, 4, 5);
            txtElec.Name = "txtElec";
            txtElec.Size = new Size(359, 30);
            txtElec.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.2F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(39, 322);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(202, 20);
            label3.TabIndex = 5;
            label3.Text = "Water Consumption (m3)";
            // 
            // txtWater
            // 
            txtWater.Font = new Font("Arial", 10F);
            txtWater.Location = new Point(39, 353);
            txtWater.Margin = new Padding(4, 5, 4, 5);
            txtWater.Name = "txtWater";
            txtWater.Size = new Size(359, 30);
            txtWater.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 123, 255);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(244, 460);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 61);
            btnSave.TabIndex = 7;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial", 10F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(39, 460);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 61);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // NewMeterReading_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 583);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtWater);
            Controls.Add(label3);
            Controls.Add(txtElec);
            Controls.Add(label2);
            Controls.Add(dtpMonth);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewMeterReading_Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Reading";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtElec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWater;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}