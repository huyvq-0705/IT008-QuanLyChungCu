namespace IT008_Quản_Lý_Chung_Cư
{
    partial class Ticket_Form
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            label1 = new Label();
            cbUnit = new ComboBox();
            label2 = new Label();
            txtTitle = new TextBox();
            label3 = new Label();
            txtDesc = new TextBox();
            label4 = new Label();
            cbStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(514, 77);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "New Ticket";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.8F);
            label1.Location = new Point(39, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 1;
            label1.Text = "Unit";
            // 
            // cbUnit
            // 
            cbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(39, 123);
            cbUnit.Margin = new Padding(4, 5, 4, 5);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(129, 31);
            cbUnit.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F);
            label2.Location = new Point(39, 184);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.Location = new Point(39, 215);
            txtTitle.Margin = new Padding(4, 5, 4, 5);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(423, 30);
            txtTitle.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.8F);
            label3.Location = new Point(39, 276);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 5;
            label3.Text = "Description";
            // 
            // txtDesc
            // 
            txtDesc.Font = new Font("Segoe UI", 10F);
            txtDesc.Location = new Point(39, 307);
            txtDesc.Margin = new Padding(4, 5, 4, 5);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(423, 151);
            txtDesc.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.8F);
            label4.Location = new Point(257, 92);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 7;
            label4.Text = "Status";
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "OPEN", "IN_PROGRESS", "CLOSED", "CANCELLED" });
            cbStatus.Location = new Point(257, 123);
            cbStatus.Margin = new Padding(4, 5, 4, 5);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(205, 31);
            cbStatus.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 123, 255);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(309, 506);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 61);
            btnSave.TabIndex = 9;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(39, 506);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 61);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Ticket_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(514, 613);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cbStatus);
            Controls.Add(label4);
            Controls.Add(txtDesc);
            Controls.Add(label3);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(cbUnit);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Ticket_Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ticket";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}