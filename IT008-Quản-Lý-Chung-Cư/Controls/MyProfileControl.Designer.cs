namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    partial class MyProfileControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            pnlHeader = new Panel();
            labelTitle = new Label();
            groupBoxInfo = new GroupBox();
            picAvatar = new PictureBox();
            btnSave = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtFullName = new TextBox();
            lblName = new Label();
            txtPassword = new TextBox();
            lblPass = new Label();
            txtUsername = new TextBox();
            lblUser = new Label();
            lblRoleValue = new Label();
            lblRoleLabel = new Label();
            lblIdValue = new Label();
            lblIdLabel = new Label();
            mainLayout.SuspendLayout();
            pnlHeader.SuspendLayout();
            groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(240, 244, 248);
            mainLayout.ColumnCount = 3;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 743F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayout.Controls.Add(pnlHeader, 1, 0);
            mainLayout.Controls.Add(groupBoxInfo, 1, 1);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Margin = new Padding(3, 4, 3, 4);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            mainLayout.RowStyles.Add(new RowStyle());
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1029, 800);
            mainLayout.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(labelTitle);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(146, 4);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(737, 99);
            pnlHeader.TabIndex = 2;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(41, 50, 65);
            labelTitle.Location = new Point(241, 33);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(252, 54);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "MY PROFILE";
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Anchor = AnchorStyles.Top;
            groupBoxInfo.BackColor = Color.White;
            groupBoxInfo.Controls.Add(picAvatar);
            groupBoxInfo.Controls.Add(btnSave);
            groupBoxInfo.Controls.Add(txtEmail);
            groupBoxInfo.Controls.Add(lblEmail);
            groupBoxInfo.Controls.Add(txtPhone);
            groupBoxInfo.Controls.Add(lblPhone);
            groupBoxInfo.Controls.Add(txtFullName);
            groupBoxInfo.Controls.Add(lblName);
            groupBoxInfo.Controls.Add(txtPassword);
            groupBoxInfo.Controls.Add(lblPass);
            groupBoxInfo.Controls.Add(txtUsername);
            groupBoxInfo.Controls.Add(lblUser);
            groupBoxInfo.Controls.Add(lblRoleValue);
            groupBoxInfo.Controls.Add(lblRoleLabel);
            groupBoxInfo.Controls.Add(lblIdValue);
            groupBoxInfo.Controls.Add(lblIdLabel);
            groupBoxInfo.Font = new Font("Segoe UI", 10F);
            groupBoxInfo.Location = new Point(146, 111);
            groupBoxInfo.Margin = new Padding(3, 4, 3, 4);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Padding = new Padding(23, 27, 23, 27);
            groupBoxInfo.Size = new Size(736, 571);
            groupBoxInfo.TabIndex = 1;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Edit Information";
            // 
            // picAvatar
            // 
            picAvatar.Image = Properties.Resources.User_Icon;
            picAvatar.Location = new Point(629, 32);
            picAvatar.Margin = new Padding(3, 4, 3, 4);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(73, 85);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 15;
            picAvatar.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(52, 152, 219);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(34, 465);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(667, 67);
            btnSave.TabIndex = 14;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(377, 389);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(324, 32);
            txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(44, 62, 80);
            lblEmail.Location = new Point(377, 360);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.WhiteSmoke;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.Location = new Point(34, 389);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(320, 32);
            txtPhone.TabIndex = 11;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(44, 62, 80);
            lblPhone.Location = new Point(34, 360);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(57, 20);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone:";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.WhiteSmoke;
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.Location = new Point(34, 296);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(667, 32);
            txtFullName.TabIndex = 9;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(44, 62, 80);
            lblName.Location = new Point(34, 267);
            lblName.Name = "lblName";
            lblName.Size = new Size(84, 20);
            lblName.TabIndex = 8;
            lblName.Text = "Full Name:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(377, 203);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "Leave blank to keep current";
            txtPassword.Size = new Size(324, 32);
            txtPassword.TabIndex = 7;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPass.ForeColor = Color.FromArgb(44, 62, 80);
            lblPass.Location = new Point(377, 173);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(116, 20);
            lblPass.TabIndex = 6;
            lblPass.Text = "New Password:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(34, 203);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(320, 32);
            txtUsername.TabIndex = 5;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUser.ForeColor = Color.FromArgb(44, 62, 80);
            lblUser.Location = new Point(34, 173);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(84, 20);
            lblUser.TabIndex = 4;
            lblUser.Text = "Username:";
            // 
            // lblRoleValue
            // 
            lblRoleValue.AutoSize = true;
            lblRoleValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRoleValue.ForeColor = Color.FromArgb(52, 152, 219);
            lblRoleValue.Location = new Point(423, 64);
            lblRoleValue.Name = "lblRoleValue";
            lblRoleValue.Size = new Size(36, 28);
            lblRoleValue.TabIndex = 3;
            lblRoleValue.Text = "---";
            // 
            // lblRoleLabel
            // 
            lblRoleLabel.AutoSize = true;
            lblRoleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRoleLabel.ForeColor = Color.Gray;
            lblRoleLabel.Location = new Point(366, 67);
            lblRoleLabel.Name = "lblRoleLabel";
            lblRoleLabel.Size = new Size(50, 23);
            lblRoleLabel.TabIndex = 2;
            lblRoleLabel.Text = "Role:";
            // 
            // lblIdValue
            // 
            lblIdValue.AutoSize = true;
            lblIdValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblIdValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblIdValue.Location = new Point(114, 64);
            lblIdValue.Name = "lblIdValue";
            lblIdValue.Size = new Size(36, 28);
            lblIdValue.TabIndex = 1;
            lblIdValue.Text = "---";
            // 
            // lblIdLabel
            // 
            lblIdLabel.AutoSize = true;
            lblIdLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIdLabel.ForeColor = Color.Gray;
            lblIdLabel.Location = new Point(34, 67);
            lblIdLabel.Name = "lblIdLabel";
            lblIdLabel.Size = new Size(78, 23);
            lblIdLabel.TabIndex = 0;
            lblIdLabel.Text = "Staff ID:";
            // 
            // MyProfileControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainLayout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MyProfileControl";
            Size = new Size(1029, 800);
            mainLayout.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblIdLabel;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label lblRoleLabel;
        private System.Windows.Forms.Label lblRoleValue;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSave;
    }
}