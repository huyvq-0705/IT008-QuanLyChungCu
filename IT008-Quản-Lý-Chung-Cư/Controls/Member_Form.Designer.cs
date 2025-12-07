namespace IT008_Quản_Lý_Chung_Cư
{
    partial class Member_Form
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
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtRelation = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtCCCD = new TextBox();
            label5 = new Label();
            dtpDob = new DateTimePicker();
            chkPrimary = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(0, 31);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(494, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Member";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(32, 138);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(423, 30);
            txtName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.2F);
            label1.ForeColor = Color.FromArgb(80, 80, 80);
            label1.Location = new Point(32, 107);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F);
            label2.ForeColor = Color.FromArgb(80, 80, 80);
            label2.Location = new Point(32, 199);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(222, 20);
            label2.TabIndex = 3;
            label2.Text = "Relationship (Husband, etc)";
            // 
            // txtRelation
            // 
            txtRelation.Font = new Font("Segoe UI", 10F);
            txtRelation.Location = new Point(32, 230);
            txtRelation.Margin = new Padding(4, 5, 4, 5);
            txtRelation.Name = "txtRelation";
            txtRelation.Size = new Size(423, 30);
            txtRelation.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.2F);
            label3.ForeColor = Color.FromArgb(80, 80, 80);
            label3.Location = new Point(32, 291);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 5;
            label3.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(32, 322);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(423, 30);
            txtPhone.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.2F);
            label4.ForeColor = Color.FromArgb(80, 80, 80);
            label4.Location = new Point(32, 383);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 7;
            label4.Text = "CCCD / ID No";
            // 
            // txtCCCD
            // 
            txtCCCD.Font = new Font("Segoe UI", 10F);
            txtCCCD.Location = new Point(32, 414);
            txtCCCD.Margin = new Padding(4, 5, 4, 5);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(423, 30);
            txtCCCD.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.2F);
            label5.ForeColor = Color.FromArgb(80, 80, 80);
            label5.Location = new Point(32, 475);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 9;
            label5.Text = "Date of Birth";
            // 
            // dtpDob
            // 
            dtpDob.Font = new Font("Segoe UI", 10F);
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(32, 506);
            dtpDob.Margin = new Padding(4, 5, 4, 5);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(423, 30);
            dtpDob.TabIndex = 10;
            // 
            // chkPrimary
            // 
            chkPrimary.AutoSize = true;
            chkPrimary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkPrimary.ForeColor = Color.FromArgb(30, 30, 30);
            chkPrimary.Location = new Point(32, 583);
            chkPrimary.Margin = new Padding(4, 5, 4, 5);
            chkPrimary.Name = "chkPrimary";
            chkPrimary.Size = new Size(307, 27);
            chkPrimary.TabIndex = 11;
            chkPrimary.Text = "Is Primary Owner (Representative)";
            chkPrimary.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 123, 255);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(302, 659);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 61);
            btnSave.TabIndex = 12;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(248, 249, 250);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(222, 226, 230);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.ForeColor = Color.FromArgb(80, 80, 80);
            btnCancel.Location = new Point(32, 659);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 61);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Member_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(494, 767);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkPrimary);
            Controls.Add(dtpDob);
            Controls.Add(label5);
            Controls.Add(txtCCCD);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtRelation);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Member_Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Member";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRelation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.CheckBox chkPrimary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}