namespace IT008_Quản_Lý_Chung_Cư
{
    partial class NewHousehold_Form
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
            cbUnits = new ComboBox();
            label2 = new Label();
            dtpStart = new DateTimePicker();
            label3 = new Label();
            txtNote = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(514, 92);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create New Household";
            lblTitle.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.2F);
            label1.ForeColor = Color.FromArgb(80, 80, 80);
            label1.Location = new Point(45, 123);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 1;
            label1.Text = "Select Unit";
            // 
            // cbUnits
            // 
            cbUnits.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnits.Font = new Font("Segoe UI", 10F);
            cbUnits.FormattingEnabled = true;
            cbUnits.Location = new Point(45, 153);
            cbUnits.Margin = new Padding(4, 5, 4, 5);
            cbUnits.Name = "cbUnits";
            cbUnits.Size = new Size(423, 31);
            cbUnits.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F);
            label2.ForeColor = Color.FromArgb(80, 80, 80);
            label2.Location = new Point(45, 215);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 3;
            label2.Text = "Contract Start Date";
            // 
            // dtpStart
            // 
            dtpStart.Font = new Font("Segoe UI", 10F);
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(45, 245);
            dtpStart.Margin = new Padding(4, 5, 4, 5);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(423, 30);
            dtpStart.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.2F);
            label3.ForeColor = Color.FromArgb(80, 80, 80);
            label3.Location = new Point(45, 307);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Note";
            // 
            // txtNote
            // 
            txtNote.Font = new Font("Segoe UI", 10F);
            txtNote.Location = new Point(45, 337);
            txtNote.Margin = new Padding(4, 5, 4, 5);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(423, 121);
            txtNote.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 123, 255);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(315, 506);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 61);
            btnSave.TabIndex = 7;
            btnSave.Text = "CREATE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(248, 249, 250);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(222, 226, 230);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.ForeColor = Color.FromArgb(80, 80, 80);
            btnCancel.Location = new Point(45, 506);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 61);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // NewHousehold_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(514, 613);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNote);
            Controls.Add(label3);
            Controls.Add(dtpStart);
            Controls.Add(label2);
            Controls.Add(cbUnits);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewHousehold_Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Household";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}