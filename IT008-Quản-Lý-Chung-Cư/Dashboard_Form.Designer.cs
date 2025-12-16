namespace IT008_Quản_Lý_Chung_Cư
{
    partial class Dashboard_Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelSidebar = new Panel();
            panelButtons = new Panel();
            btnTicket = new Guna.UI2.WinForms.Guna2Button();
            btnMonthlyBill = new Guna.UI2.WinForms.Guna2Button();
            btnMeterReading = new Guna.UI2.WinForms.Guna2Button();
            btnHousehold = new Guna.UI2.WinForms.Guna2Button();
            btnUnit = new Guna.UI2.WinForms.Guna2Button();
            btnStaff = new Guna.UI2.WinForms.Guna2Button();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelContent = new Panel();
            panelSidebar.SuspendLayout();
            panelButtons.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(250, 250, 250);
            panelSidebar.BorderStyle = BorderStyle.FixedSingle;
            panelSidebar.Controls.Add(panelButtons);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(178, 696);
            panelSidebar.TabIndex = 2;
            // 
            // panelButtons
            // 
            panelButtons.AutoScroll = true;
            panelButtons.Controls.Add(btnTicket);
            panelButtons.Controls.Add(btnMonthlyBill);
            panelButtons.Controls.Add(btnMeterReading);
            panelButtons.Controls.Add(btnHousehold);
            panelButtons.Controls.Add(btnUnit);
            panelButtons.Controls.Add(btnStaff);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(0, 125);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(13, 17, 13, 17);
            panelButtons.Size = new Size(176, 517);
            panelButtons.TabIndex = 8;
            // 
            // btnTicket
            // 
            btnTicket.BorderRadius = 8;
            btnTicket.CustomizableEdges = customizableEdges1;
            btnTicket.Dock = DockStyle.Top;
            btnTicket.FillColor = Color.White;
            btnTicket.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnTicket.ForeColor = Color.Black;
            btnTicket.HoverState.FillColor = Color.Silver;
            btnTicket.HoverState.ForeColor = Color.White;
            btnTicket.Image = Properties.Resources.ticket_icon;
            btnTicket.ImageAlign = HorizontalAlignment.Left;
            btnTicket.ImageSize = new Size(32, 32);
            btnTicket.Location = new Point(13, 367);
            btnTicket.Margin = new Padding(0, 0, 0, 9);
            btnTicket.Name = "btnTicket";
            btnTicket.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnTicket.Size = new Size(150, 70);
            btnTicket.TabIndex = 0;
            btnTicket.Text = "Ticket";
            btnTicket.TextAlign = HorizontalAlignment.Left;
            btnTicket.Click += btnTicket_Click;
            // 
            // btnMonthlyBill
            // 
            btnMonthlyBill.BorderRadius = 8;
            btnMonthlyBill.CustomizableEdges = customizableEdges3;
            btnMonthlyBill.Dock = DockStyle.Top;
            btnMonthlyBill.FillColor = Color.White;
            btnMonthlyBill.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnMonthlyBill.ForeColor = Color.Black;
            btnMonthlyBill.HoverState.FillColor = Color.Silver;
            btnMonthlyBill.HoverState.ForeColor = Color.White;
            btnMonthlyBill.Image = Properties.Resources.bill_icon;
            btnMonthlyBill.ImageAlign = HorizontalAlignment.Left;
            btnMonthlyBill.ImageSize = new Size(32, 32);
            btnMonthlyBill.Location = new Point(13, 297);
            btnMonthlyBill.Margin = new Padding(0, 0, 0, 9);
            btnMonthlyBill.Name = "btnMonthlyBill";
            btnMonthlyBill.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnMonthlyBill.Size = new Size(150, 70);
            btnMonthlyBill.TabIndex = 1;
            btnMonthlyBill.Text = "Monthly Bill";
            btnMonthlyBill.TextAlign = HorizontalAlignment.Left;
            btnMonthlyBill.Click += btnMonthlyBill_Click;
            // 
            // btnMeterReading
            // 
            btnMeterReading.BorderRadius = 8;
            btnMeterReading.CustomizableEdges = customizableEdges5;
            btnMeterReading.Dock = DockStyle.Top;
            btnMeterReading.FillColor = Color.White;
            btnMeterReading.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnMeterReading.ForeColor = Color.Black;
            btnMeterReading.HoverState.FillColor = Color.Silver;
            btnMeterReading.HoverState.ForeColor = Color.White;
            btnMeterReading.Image = Properties.Resources.meter_icon;
            btnMeterReading.ImageAlign = HorizontalAlignment.Left;
            btnMeterReading.ImageSize = new Size(30, 30);
            btnMeterReading.Location = new Point(13, 227);
            btnMeterReading.Margin = new Padding(0, 0, 0, 9);
            btnMeterReading.Name = "btnMeterReading";
            btnMeterReading.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnMeterReading.Size = new Size(150, 70);
            btnMeterReading.TabIndex = 2;
            btnMeterReading.Text = "Meter Read";
            btnMeterReading.TextAlign = HorizontalAlignment.Left;
            btnMeterReading.Click += btnMeterReading_Click;
            // 
            // btnHousehold
            // 
            btnHousehold.BorderRadius = 8;
            btnHousehold.CustomizableEdges = customizableEdges7;
            btnHousehold.Dock = DockStyle.Top;
            btnHousehold.FillColor = Color.White;
            btnHousehold.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnHousehold.ForeColor = Color.Black;
            btnHousehold.HoverState.FillColor = Color.Silver;
            btnHousehold.HoverState.ForeColor = Color.White;
            btnHousehold.Image = Properties.Resources.household_icon;
            btnHousehold.ImageAlign = HorizontalAlignment.Left;
            btnHousehold.ImageSize = new Size(32, 32);
            btnHousehold.Location = new Point(13, 157);
            btnHousehold.Margin = new Padding(0, 0, 0, 9);
            btnHousehold.Name = "btnHousehold";
            btnHousehold.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnHousehold.Size = new Size(150, 70);
            btnHousehold.TabIndex = 3;
            btnHousehold.Text = "Household";
            btnHousehold.TextAlign = HorizontalAlignment.Left;
            btnHousehold.Click += btnHousehold_Click;
            // 
            // btnUnit
            // 
            btnUnit.BorderRadius = 8;
            btnUnit.CustomizableEdges = customizableEdges9;
            btnUnit.DisabledState.BorderColor = Color.DarkGray;
            btnUnit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUnit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUnit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUnit.Dock = DockStyle.Top;
            btnUnit.FillColor = Color.White;
            btnUnit.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnUnit.ForeColor = Color.Black;
            btnUnit.HoverState.FillColor = Color.Silver;
            btnUnit.HoverState.ForeColor = Color.White;
            btnUnit.Image = Properties.Resources.unit_icon;
            btnUnit.ImageAlign = HorizontalAlignment.Left;
            btnUnit.ImageSize = new Size(32, 32);
            btnUnit.Location = new Point(13, 87);
            btnUnit.Margin = new Padding(0, 0, 0, 9);
            btnUnit.Name = "btnUnit";
            btnUnit.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnUnit.Size = new Size(150, 70);
            btnUnit.TabIndex = 1;
            btnUnit.Text = "Unit";
            btnUnit.TextAlign = HorizontalAlignment.Left;
            btnUnit.Click += btnUnit_Click;
            // 
            // btnStaff
            // 
            btnStaff.BorderRadius = 8;
            btnStaff.CustomizableEdges = customizableEdges11;
            btnStaff.DisabledState.BorderColor = Color.DarkGray;
            btnStaff.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStaff.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStaff.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStaff.Dock = DockStyle.Top;
            btnStaff.FillColor = Color.White;
            btnStaff.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnStaff.ForeColor = Color.Black;
            btnStaff.HoverState.FillColor = Color.Silver;
            btnStaff.HoverState.ForeColor = Color.White;
            btnStaff.Image = Properties.Resources.staff_icon;
            btnStaff.ImageAlign = HorizontalAlignment.Left;
            btnStaff.ImageSize = new Size(32, 32);
            btnStaff.Location = new Point(13, 17);
            btnStaff.Margin = new Padding(0);
            btnStaff.Name = "btnStaff";
            btnStaff.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnStaff.Size = new Size(150, 70);
            btnStaff.TabIndex = 0;
            btnStaff.Text = "Staff";
            btnStaff.TextAlign = HorizontalAlignment.Left;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnLogout
            // 
            btnLogout.BorderRadius = 8;
            btnLogout.CustomizableEdges = customizableEdges13;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FillColor = Color.FromArgb(240, 240, 240);
            btnLogout.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(192, 0, 0);
            btnLogout.HoverState.FillColor = Color.FromArgb(255, 64, 64);
            btnLogout.HoverState.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.logout_icon;
            btnLogout.ImageSize = new Size(28, 28);
            btnLogout.Location = new Point(0, 642);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnLogout.Size = new Size(176, 52);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "LOGOUT";
            btnLogout.Click += btnLogout_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Transparent;
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(176, 125);
            panelLogo.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(234, 246, 255);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Logo1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(178, 0);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(9, 9, 9, 9);
            panelContent.Size = new Size(1066, 696);
            panelContent.TabIndex = 3;
            // 
            // Dashboard_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 696);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Name = "Dashboard_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Form_Load;
            panelSidebar.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelContent;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Button btnUnit;
        private Guna.UI2.WinForms.Guna2Button btnHousehold;
        private Guna.UI2.WinForms.Guna2Button btnMeterReading;
        private Guna.UI2.WinForms.Guna2Button btnMonthlyBill;
        private Guna.UI2.WinForms.Guna2Button btnTicket;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private PictureBox pictureBox1;
    }
}