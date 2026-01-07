namespace IT008_Quản_Lý_Chung_Cư
{
    partial class EditHousehold_Form
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
            lblUnitCode = new Label();
            label1 = new Label();
            dtpStartDate = new DateTimePicker();
            label2 = new Label();
            dtpEndDate = new DateTimePicker();
            chkEndDate = new CheckBox();
            label3 = new Label();
            txtNote = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Georgia", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(0, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(550, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Edit Household Information";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUnitCode
            // 
            lblUnitCode.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblUnitCode.ForeColor = Color.FromArgb(52, 152, 219);
            lblUnitCode.Location = new Point(0, 75);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(550, 25);
            lblUnitCode.TabIndex = 1;
            lblUnitCode.Text = "Unit: A101";
            lblUnitCode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.2F);
            label1.ForeColor = Color.FromArgb(80, 80, 80);
            label1.Location = new Point(35, 130);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Arial", 10F);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(35, 160);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(480, 30);
            dtpStartDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F);
            label2.ForeColor = Color.FromArgb(80, 80, 80);
            label2.Location = new Point(35, 220);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "End Date";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Enabled = false;
            dtpEndDate.Font = new Font("Arial", 10F);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(35, 280);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(480, 30);
            dtpEndDate.TabIndex = 5;
            // 
            // chkEndDate
            // 
            chkEndDate.AutoSize = true;
            chkEndDate.Font = new Font("Arial", 9.5F);
            chkEndDate.ForeColor = Color.FromArgb(80, 80, 80);
            chkEndDate.Location = new Point(35, 250);
            chkEndDate.Name = "chkEndDate";
            chkEndDate.Size = new Size(301, 25);
            chkEndDate.TabIndex = 6;
            chkEndDate.Text = "Set end date (leave unchecked if active)";
            chkEndDate.UseVisualStyleBackColor = true;
            chkEndDate.CheckedChanged += chkEndDate_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.2F);
            label3.ForeColor = Color.FromArgb(80, 80, 80);
            label3.Location = new Point(35, 340);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 7;
            label3.Text = "Note";
            // 
            // txtNote
            // 
            txtNote.Font = new Font("Arial", 10F);
            txtNote.Location = new Point(35, 370);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ScrollBars = ScrollBars.Vertical;
            txtNote.Size = new Size(480, 100);
            txtNote.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 123, 255);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(335, 510);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 55);
            btnSave.TabIndex = 9;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(248, 249, 250);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(222, 226, 230);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial", 10F);
            btnCancel.ForeColor = Color.FromArgb(80, 80, 80);
            btnCancel.Location = new Point(35, 510);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 55);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditHousehold_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 600);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNote);
            Controls.Add(label3);
            Controls.Add(chkEndDate);
            Controls.Add(dtpEndDate);
            Controls.Add(label2);
            Controls.Add(dtpStartDate);
            Controls.Add(label1);
            Controls.Add(lblUnitCode);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditHousehold_Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Household";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUnitCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.CheckBox chkEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}