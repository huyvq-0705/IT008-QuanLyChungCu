namespace IT008_Quản_Lý_Chung_Cư
{
    partial class Dashboard_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            Dashboard = new Label();
            panelSidebar = new Panel();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            btnTicket = new Guna.UI2.WinForms.Guna2Button();
            btnMonthlyBill = new Guna.UI2.WinForms.Guna2Button();
            btnMeterReading = new Guna.UI2.WinForms.Guna2Button();
            btnHousehold = new Guna.UI2.WinForms.Guna2Button();
            btnUnit = new Guna.UI2.WinForms.Guna2Button();
            btnStaff = new Guna.UI2.WinForms.Guna2Button();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // Dashboard
            // 
            Dashboard.AutoSize = true;
            Dashboard.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard.Location = new Point(600, 80);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(181, 46);
            Dashboard.TabIndex = 0;
            Dashboard.Text = "WELCOME";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(250, 250, 250);
            panelSidebar.BorderStyle = BorderStyle.FixedSingle;
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnTicket);
            panelSidebar.Controls.Add(btnMonthlyBill);
            panelSidebar.Controls.Add(btnMeterReading);
            panelSidebar.Controls.Add(btnHousehold);
            panelSidebar.Controls.Add(btnUnit);
            panelSidebar.Controls.Add(btnStaff);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(195, 800);
            panelSidebar.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.CustomizableEdges = customizableEdges1;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FillColor = Color.White;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.ForeColor = Color.Black;
            btnLogout.HoverState.FillColor = Color.FromArgb(230, 230, 230);
            btnLogout.Location = new Point(0, 738);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogout.Size = new Size(193, 60);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "LOGOUT";
            btnLogout.TextAlign = HorizontalAlignment.Left;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnTicket
            // 
            btnTicket.CustomizableEdges = customizableEdges3;
            btnTicket.DisabledState.BorderColor = Color.DarkGray;
            btnTicket.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTicket.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTicket.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTicket.Dock = DockStyle.Top;
            btnTicket.FillColor = Color.White;
            btnTicket.Font = new Font("Segoe UI", 10F);
            btnTicket.ForeColor = Color.Black;
            btnTicket.HoverState.FillColor = Color.FromArgb(230, 230, 230);
            btnTicket.Location = new Point(0, 360);
            btnTicket.Name = "btnTicket";
            btnTicket.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnTicket.Size = new Size(193, 60);
            btnTicket.TabIndex = 5;
            btnTicket.Text = "Ticket";
            btnTicket.TextAlign = HorizontalAlignment.Left;
            btnTicket.Click += btnTicket_Click;
            // 
            // btnMonthlyBill
            // 
            btnMonthlyBill.CustomizableEdges = customizableEdges5;
            btnMonthlyBill.DisabledState.BorderColor = Color.DarkGray;
            btnMonthlyBill.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMonthlyBill.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMonthlyBill.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMonthlyBill.Dock = DockStyle.Top;
            btnMonthlyBill.FillColor = Color.White;
            btnMonthlyBill.Font = new Font("Segoe UI", 10F);
            btnMonthlyBill.ForeColor = Color.Black;
            btnMonthlyBill.HoverState.FillColor = Color.FromArgb(230, 230, 230);
            btnMonthlyBill.Location = new Point(0, 300);
            btnMonthlyBill.Name = "btnMonthlyBill";
            btnMonthlyBill.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnMonthlyBill.Size = new Size(193, 60);
            btnMonthlyBill.TabIndex = 4;
            btnMonthlyBill.Text = "Monthly bill";
            btnMonthlyBill.TextAlign = HorizontalAlignment.Left;
            btnMonthlyBill.Click += btnMonthlyBill_Click;
            // 
            // btnMeterReading
            // 
            btnMeterReading.CustomizableEdges = customizableEdges7;
            btnMeterReading.DisabledState.BorderColor = Color.DarkGray;
            btnMeterReading.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMeterReading.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMeterReading.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMeterReading.Dock = DockStyle.Top;
            btnMeterReading.FillColor = Color.White;
            btnMeterReading.Font = new Font("Segoe UI", 10F);
            btnMeterReading.ForeColor = Color.Black;
            btnMeterReading.HoverState.FillColor = Color.FromArgb(230, 230, 230);
            btnMeterReading.Location = new Point(0, 240);
            btnMeterReading.Name = "btnMeterReading";
            btnMeterReading.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnMeterReading.Size = new Size(193, 60);
            btnMeterReading.TabIndex = 3;
            btnMeterReading.Text = "Meter reading";
            btnMeterReading.TextAlign = HorizontalAlignment.Left;
            btnMeterReading.Click += btnMeterReading_Click;
            // 
            // btnHousehold
            // 
            btnHousehold.CustomizableEdges = customizableEdges9;
            btnHousehold.DisabledState.BorderColor = Color.DarkGray;
            btnHousehold.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHousehold.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHousehold.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHousehold.Dock = DockStyle.Top;
            btnHousehold.FillColor = Color.White;
            btnHousehold.Font = new Font("Segoe UI", 10F);
            btnHousehold.ForeColor = Color.Black;
            btnHousehold.HoverState.FillColor = Color.FromArgb(230, 230, 230);
            btnHousehold.Location = new Point(0, 180);
            btnHousehold.Name = "btnHousehold";
            btnHousehold.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnHousehold.Size = new Size(193, 60);
            btnHousehold.TabIndex = 2;
            btnHousehold.Text = "Household";
            btnHousehold.TextAlign = HorizontalAlignment.Left;
            btnHousehold.Click += btnHousehold_Click;
            // 
            // btnUnit
            // 
            btnUnit.CustomizableEdges = customizableEdges11;
            btnUnit.DisabledState.BorderColor = Color.DarkGray;
            btnUnit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUnit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUnit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUnit.Dock = DockStyle.Top;
            btnUnit.FillColor = Color.White;
            btnUnit.Font = new Font("Segoe UI", 10F);
            btnUnit.ForeColor = Color.Black;
            btnUnit.HoverState.FillColor = Color.FromArgb(230, 230, 230);
            btnUnit.Location = new Point(0, 120);
            btnUnit.Name = "btnUnit";
            btnUnit.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnUnit.Size = new Size(193, 60);
            btnUnit.TabIndex = 1;
            btnUnit.Text = "Unit";
            btnUnit.TextAlign = HorizontalAlignment.Left;
            btnUnit.Click += btnUnit_Click;
            // 
            // btnStaff
            // 
            btnStaff.CustomizableEdges = customizableEdges13;
            btnStaff.DisabledState.BorderColor = Color.DarkGray;
            btnStaff.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStaff.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStaff.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStaff.Dock = DockStyle.Top;
            btnStaff.FillColor = Color.White;
            btnStaff.Font = new Font("Segoe UI", 10F);
            btnStaff.ForeColor = Color.Black;
            btnStaff.HoverState.FillColor = Color.FromArgb(230, 230, 230);
            btnStaff.Location = new Point(0, 60);
            btnStaff.Name = "btnStaff";
            btnStaff.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnStaff.Size = new Size(193, 60);
            btnStaff.TabIndex = 0;
            btnStaff.Text = "Staff";
            btnStaff.TextAlign = HorizontalAlignment.Left;
            btnStaff.Click += btnStaff_Click;
            // 
            // Dashboard_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 800);
            Controls.Add(Dashboard);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.Sizable;
            Name = "Dashboard_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Form_Load;
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Dashboard;
        private Panel panelSidebar;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Button btnUnit;
        private Guna.UI2.WinForms.Guna2Button btnHousehold;
        private Guna.UI2.WinForms.Guna2Button btnMeterReading;
        private Guna.UI2.WinForms.Guna2Button btnMonthlyBill;
        private Guna.UI2.WinForms.Guna2Button btnTicket;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}