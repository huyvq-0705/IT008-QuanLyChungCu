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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            mainLayout = new TableLayoutPanel();
            pnlHeader = new Panel();
            labelTitle = new Label();
            groupBoxInfo = new GroupBox();
            picAvatar = new PictureBox();
            btnSave = new Button();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            lblEmail = new Label();
            txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            lblPhone = new Label();
            txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            lblName = new Label();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            lblPass = new Label();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            lblUser = new Label();
            lblRoleValue = new Label();
            lblRoleLabel = new Label();
            lblIdValue = new Label();
            lblIdLabel = new Label();
            btn_Back = new Guna.UI2.WinForms.Guna2Button();
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
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 836F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayout.Controls.Add(pnlHeader, 1, 0);
            mainLayout.Controls.Add(groupBoxInfo, 1, 1);
            mainLayout.Controls.Add(btn_Back, 0, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Margin = new Padding(3, 5, 3, 5);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 123F));
            mainLayout.RowStyles.Add(new RowStyle());
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1158, 920);
            mainLayout.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(labelTitle);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(164, 5);
            pnlHeader.Margin = new Padding(3, 5, 3, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(830, 113);
            pnlHeader.TabIndex = 2;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(41, 50, 65);
            labelTitle.Location = new Point(271, 37);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(294, 46);
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
            groupBoxInfo.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxInfo.Location = new Point(165, 128);
            groupBoxInfo.Margin = new Padding(3, 5, 3, 5);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Padding = new Padding(26, 31, 26, 31);
            groupBoxInfo.Size = new Size(828, 657);
            groupBoxInfo.TabIndex = 1;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Edit Information";
            // 
            // picAvatar
            // 
            picAvatar.Image = Properties.Resources.User_Icon;
            picAvatar.Location = new Point(708, 37);
            picAvatar.Margin = new Padding(3, 5, 3, 5);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(82, 98);
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
            btnSave.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(38, 535);
            btnSave.Margin = new Padding(3, 5, 3, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(750, 77);
            btnSave.TabIndex = 14;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderColor = Color.LightGray;
            txtEmail.BorderRadius = 5;
            txtEmail.CustomizableEdges = customizableEdges1;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FillColor = Color.WhiteSmoke;
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(424, 447);
            txtEmail.Margin = new Padding(3, 5, 3, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtEmail.Size = new Size(364, 37);
            txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(44, 62, 80);
            lblEmail.Location = new Point(424, 414);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(67, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // txtPhone
            // 
            txtPhone.BorderColor = Color.LightGray;
            txtPhone.BorderRadius = 5;
            txtPhone.CustomizableEdges = customizableEdges3;
            txtPhone.DefaultText = "";
            txtPhone.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPhone.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPhone.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPhone.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPhone.FillColor = Color.WhiteSmoke;
            txtPhone.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.ForeColor = Color.Black;
            txtPhone.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhone.Location = new Point(38, 447);
            txtPhone.Margin = new Padding(3, 5, 3, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "";
            txtPhone.SelectedText = "";
            txtPhone.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPhone.Size = new Size(360, 37);
            txtPhone.TabIndex = 11;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(44, 62, 80);
            lblPhone.Location = new Point(38, 414);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(74, 20);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone:";
            // 
            // txtFullName
            // 
            txtFullName.BorderColor = Color.LightGray;
            txtFullName.BorderRadius = 5;
            txtFullName.CustomizableEdges = customizableEdges5;
            txtFullName.DefaultText = "";
            txtFullName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFullName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFullName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFullName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFullName.FillColor = Color.WhiteSmoke;
            txtFullName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.ForeColor = Color.Black;
            txtFullName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFullName.Location = new Point(38, 340);
            txtFullName.Margin = new Padding(3, 5, 3, 5);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "";
            txtFullName.SelectedText = "";
            txtFullName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtFullName.Size = new Size(750, 37);
            txtFullName.TabIndex = 9;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(44, 62, 80);
            lblName.Location = new Point(38, 307);
            lblName.Name = "lblName";
            lblName.Size = new Size(107, 20);
            lblName.TabIndex = 8;
            lblName.Text = "Full Name:";
            // 
            // txtPassword
            // 
            txtPassword.BorderColor = Color.LightGray;
            txtPassword.BorderRadius = 5;
            txtPassword.CustomizableEdges = customizableEdges7;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FillColor = Color.WhiteSmoke;
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(424, 233);
            txtPassword.Margin = new Padding(3, 5, 3, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "Leave blank to keep current";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPassword.Size = new Size(364, 37);
            txtPassword.TabIndex = 7;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            lblPass.ForeColor = Color.FromArgb(44, 62, 80);
            lblPass.Location = new Point(424, 199);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(146, 20);
            lblPass.TabIndex = 6;
            lblPass.Text = "New Password:";
            // 
            // txtUsername
            // 
            txtUsername.BorderColor = Color.LightGray;
            txtUsername.BorderRadius = 5;
            txtUsername.CustomizableEdges = customizableEdges9;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FillColor = Color.WhiteSmoke;
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Location = new Point(38, 233);
            txtUsername.Margin = new Padding(3, 5, 3, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtUsername.Size = new Size(360, 37);
            txtUsername.TabIndex = 5;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            lblUser.ForeColor = Color.FromArgb(44, 62, 80);
            lblUser.Location = new Point(38, 199);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(108, 20);
            lblUser.TabIndex = 4;
            lblUser.Text = "Username:";
            // 
            // lblRoleValue
            // 
            lblRoleValue.AutoSize = true;
            lblRoleValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRoleValue.ForeColor = Color.FromArgb(52, 152, 219);
            lblRoleValue.Location = new Point(476, 72);
            lblRoleValue.Name = "lblRoleValue";
            lblRoleValue.Size = new Size(36, 28);
            lblRoleValue.TabIndex = 3;
            lblRoleValue.Text = "---";
            // 
            // lblRoleLabel
            // 
            lblRoleLabel.AutoSize = true;
            lblRoleLabel.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            lblRoleLabel.ForeColor = Color.Gray;
            lblRoleLabel.Location = new Point(412, 77);
            lblRoleLabel.Name = "lblRoleLabel";
            lblRoleLabel.Size = new Size(56, 20);
            lblRoleLabel.TabIndex = 2;
            lblRoleLabel.Text = "Role:";
            // 
            // lblIdValue
            // 
            lblIdValue.AutoSize = true;
            lblIdValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblIdValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblIdValue.Location = new Point(128, 70);
            lblIdValue.Name = "lblIdValue";
            lblIdValue.Size = new Size(36, 28);
            lblIdValue.TabIndex = 1;
            lblIdValue.Text = "---";
            // 
            // lblIdLabel
            // 
            lblIdLabel.AutoSize = true;
            lblIdLabel.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            lblIdLabel.ForeColor = Color.Gray;
            lblIdLabel.Location = new Point(38, 77);
            lblIdLabel.Name = "lblIdLabel";
            lblIdLabel.Size = new Size(85, 20);
            lblIdLabel.TabIndex = 0;
            lblIdLabel.Text = "Staff ID:";
            // 
            // btn_Back
            // 
            btn_Back.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Back.Cursor = Cursors.Hand;
            btn_Back.CustomizableEdges = customizableEdges11;
            btn_Back.DisabledState.BorderColor = Color.DarkGray;
            btn_Back.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Back.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Back.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Back.FillColor = Color.Transparent;
            btn_Back.Font = new Font("Segoe UI", 9F);
            btn_Back.ForeColor = Color.White;
            btn_Back.HoverState.FillColor = Color.White;
            btn_Back.Image = Properties.Resources.Back;
            btn_Back.ImageAlign = HorizontalAlignment.Left;
            btn_Back.ImageSize = new Size(50, 25);
            btn_Back.Location = new Point(76, 60);
            btn_Back.Name = "btn_Back";
            btn_Back.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btn_Back.Size = new Size(82, 60);
            btn_Back.TabIndex = 3;
            btn_Back.Click += btn_Back_Click;
            // 
            // MyProfileControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainLayout);
            Margin = new Padding(3, 5, 3, 5);
            Name = "MyProfileControl";
            Size = new Size(1158, 920);
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
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private System.Windows.Forms.Label lblPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btn_Back;
    }
}