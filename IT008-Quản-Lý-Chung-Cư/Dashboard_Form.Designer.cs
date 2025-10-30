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
            Dashboard = new Label();
            btn_Close_Dashboard = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // Dashboard
            // 
            Dashboard.AutoSize = true;
            Dashboard.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Dashboard.Location = new Point(29, 37);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(195, 46);
            Dashboard.TabIndex = 0;
            Dashboard.Text = "Dashboard";
            // 
            // btn_Close_Dashboard
            // 
            btn_Close_Dashboard.CustomizableEdges = customizableEdges1;
            btn_Close_Dashboard.DisabledState.BorderColor = Color.DarkGray;
            btn_Close_Dashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Close_Dashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Close_Dashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Close_Dashboard.FillColor = Color.Transparent;
            btn_Close_Dashboard.Font = new Font("Segoe UI", 9F);
            btn_Close_Dashboard.ForeColor = Color.White;
            btn_Close_Dashboard.Image = Properties.Resources.X_button;
            btn_Close_Dashboard.ImageSize = new Size(30, 30);
            btn_Close_Dashboard.Location = new Point(1325, 21);
            btn_Close_Dashboard.Name = "btn_Close_Dashboard";
            btn_Close_Dashboard.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_Close_Dashboard.Size = new Size(45, 41);
            btn_Close_Dashboard.TabIndex = 1;
            btn_Close_Dashboard.Click += btn_Close_Dashboard_Click;
            // 
            // Dashboard_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 800);
            Controls.Add(btn_Close_Dashboard);
            Controls.Add(Dashboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard_Form";
            Text = "Dashboard_Form";
            Load += Dashboard_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Dashboard;
        private Guna.UI2.WinForms.Guna2Button btn_Close_Dashboard;
    }
}