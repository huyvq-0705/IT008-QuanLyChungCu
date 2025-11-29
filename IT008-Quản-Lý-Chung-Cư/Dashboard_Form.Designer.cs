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

            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnTicket = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonthlyBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnMeterReading = new Guna.UI2.WinForms.Guna2Button();
            this.btnHousehold = new Guna.UI2.WinForms.Guna2Button();
            this.btnUnit = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblAppSubtitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();

            this.panelSidebar.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelLogo.Controls.Add(this.lblAppSubtitle);
            this.panelLogo.Controls.Add(this.lblAppTitle);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(193, 100);
            this.panelLogo.TabIndex = 7;

            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(0, 20);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(193, 35);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "IT008";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblAppSubtitle
            // 
            this.lblAppSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblAppSubtitle.Location = new System.Drawing.Point(0, 55);
            this.lblAppSubtitle.Name = "lblAppSubtitle";
            this.lblAppSubtitle.Size = new System.Drawing.Size(193, 25);
            this.lblAppSubtitle.TabIndex = 1;
            this.lblAppSubtitle.Text = "Apartment Management";
            this.lblAppSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // 
            // panelButtons
            // 
            this.panelButtons.AutoScroll = true;
            this.panelButtons.Controls.Add(this.btnTicket);
            this.panelButtons.Controls.Add(this.btnMonthlyBill);
            this.panelButtons.Controls.Add(this.btnMeterReading);
            this.panelButtons.Controls.Add(this.btnHousehold);
            this.panelButtons.Controls.Add(this.btnUnit);
            this.panelButtons.Controls.Add(this.btnStaff);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(0, 100);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(15, 20, 15, 20);
            this.panelButtons.Size = new System.Drawing.Size(193, 638);
            this.panelButtons.TabIndex = 8;

            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSidebar.Controls.Add(this.panelButtons);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(195, 800);
            this.panelSidebar.TabIndex = 2;

            // 
            // btnStaff
            // 
            this.btnStaff.BorderRadius = 8;
            this.btnStaff.CustomizableEdges = customizableEdges13;
            this.btnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FillColor = System.Drawing.Color.White;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStaff.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnStaff.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::IT008_Quản_Lý_Chung_Cư.Properties.Resources.staff_icon;
            this.btnStaff.ImageSize = new System.Drawing.Size(32, 32);
            this.btnStaff.Location = new System.Drawing.Point(15, 20);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.ShadowDecoration.CustomizableEdges = customizableEdges14;
            this.btnStaff.Size = new System.Drawing.Size(163, 80);
            this.btnStaff.TabIndex = 0;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);

            // 
            // btnUnit
            // 
            this.btnUnit.BorderRadius = 8;
            this.btnUnit.CustomizableEdges = customizableEdges11;
            this.btnUnit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUnit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnit.FillColor = System.Drawing.Color.White;
            this.btnUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUnit.ForeColor = System.Drawing.Color.Black;
            this.btnUnit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUnit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnUnit.Image = global::IT008_Quản_Lý_Chung_Cư.Properties.Resources.unit_icon;
            this.btnUnit.ImageSize = new System.Drawing.Size(32, 32);
            this.btnUnit.Location = new System.Drawing.Point(15, 110);
            this.btnUnit.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.ShadowDecoration.CustomizableEdges = customizableEdges12;
            this.btnUnit.Size = new System.Drawing.Size(163, 80);
            this.btnUnit.TabIndex = 1;
            this.btnUnit.Text = "Unit";
            this.btnUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);

            // 
            // btnHousehold
            // 
            this.btnHousehold.BorderRadius = 8;
            this.btnHousehold.CustomizableEdges = customizableEdges9;
            this.btnHousehold.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHousehold.FillColor = System.Drawing.Color.White;
            this.btnHousehold.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHousehold.ForeColor = System.Drawing.Color.Black;
            this.btnHousehold.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnHousehold.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnHousehold.Image = global::IT008_Quản_Lý_Chung_Cư.Properties.Resources.household_icon;
            this.btnHousehold.ImageSize = new System.Drawing.Size(32, 32);
            this.btnHousehold.Location = new System.Drawing.Point(15, 200);
            this.btnHousehold.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnHousehold.Name = "btnHousehold";
            this.btnHousehold.ShadowDecoration.CustomizableEdges = customizableEdges10;
            this.btnHousehold.Size = new System.Drawing.Size(163, 80);
            this.btnHousehold.Text = "Household";
            this.btnHousehold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHousehold.Click += new System.EventHandler(this.btnHousehold_Click);

            // 
            // btnMeterReading
            // 
            this.btnMeterReading.BorderRadius = 8;
            this.btnMeterReading.CustomizableEdges = customizableEdges7;
            this.btnMeterReading.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMeterReading.FillColor = System.Drawing.Color.White;
            this.btnMeterReading.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMeterReading.ForeColor = System.Drawing.Color.Black;
            this.btnMeterReading.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnMeterReading.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnMeterReading.Image = global::IT008_Quản_Lý_Chung_Cư.Properties.Resources.meter_icon;
            this.btnMeterReading.ImageSize = new System.Drawing.Size(32, 32);
            this.btnMeterReading.Location = new System.Drawing.Point(15, 290);
            this.btnMeterReading.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnMeterReading.Name = "btnMeterReading";
            this.btnMeterReading.ShadowDecoration.CustomizableEdges = customizableEdges8;
            this.btnMeterReading.Size = new System.Drawing.Size(163, 80);
            this.btnMeterReading.Text = "Meter Reading";
            this.btnMeterReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMeterReading.Click += new System.EventHandler(this.btnMeterReading_Click);

            // 
            // btnMonthlyBill
            // 
            this.btnMonthlyBill.BorderRadius = 8;
            this.btnMonthlyBill.CustomizableEdges = customizableEdges5;
            this.btnMonthlyBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonthlyBill.FillColor = System.Drawing.Color.White;
            this.btnMonthlyBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMonthlyBill.ForeColor = System.Drawing.Color.Black;
            this.btnMonthlyBill.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnMonthlyBill.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnMonthlyBill.Image = global::IT008_Quản_Lý_Chung_Cư.Properties.Resources.bill_icon;
            this.btnMonthlyBill.ImageSize = new System.Drawing.Size(32, 32);
            this.btnMonthlyBill.Location = new System.Drawing.Point(15, 380);
            this.btnMonthlyBill.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnMonthlyBill.Name = "btnMonthlyBill";
            this.btnMonthlyBill.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.btnMonthlyBill.Size = new System.Drawing.Size(163, 80);
            this.btnMonthlyBill.Text = "Monthly Bill";
            this.btnMonthlyBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMonthlyBill.Click += new System.EventHandler(this.btnMonthlyBill_Click);

            // 
            // btnTicket
            // 
            this.btnTicket.BorderRadius = 8;
            this.btnTicket.CustomizableEdges = customizableEdges3;
            this.btnTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTicket.FillColor = System.Drawing.Color.White;
            this.btnTicket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTicket.ForeColor = System.Drawing.Color.Black;
            this.btnTicket.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTicket.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTicket.Image = global::IT008_Quản_Lý_Chung_Cư.Properties.Resources.ticket_icon;
            this.btnTicket.ImageSize = new System.Drawing.Size(32, 32);
            this.btnTicket.Location = new System.Drawing.Point(15, 470);
            this.btnTicket.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.btnTicket.Size = new System.Drawing.Size(163, 80);
            this.btnTicket.Text = "Ticket";
            this.btnTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);

            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 8;
            this.btnLogout.CustomizableEdges = customizableEdges1;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::IT008_Quản_Lý_Chung_Cư.Properties.Resources.logout_icon;
            this.btnLogout.ImageSize = new System.Drawing.Size(28, 28);
            this.btnLogout.Location = new System.Drawing.Point(0, 738);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnLogout.Size = new System.Drawing.Size(193, 60);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(195, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Size = new System.Drawing.Size(1205, 800);
            this.panelContent.TabIndex = 3;

            // 
            // Dashboard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Name = "Dashboard_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Form_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppSubtitle;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelContent;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Button btnUnit;
        private Guna.UI2.WinForms.Guna2Button btnHousehold;
        private Guna.UI2.WinForms.Guna2Button btnMeterReading;
        private Guna.UI2.WinForms.Guna2Button btnMonthlyBill;
        private Guna.UI2.WinForms.Guna2Button btnTicket;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}