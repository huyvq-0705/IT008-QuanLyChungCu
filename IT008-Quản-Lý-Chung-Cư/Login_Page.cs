// Updated Login_Page.cs
using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using BCrypt.Net;

namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class Login_Page : Form
    {
        private bool isPasswordVisible = false;

        public Login_Page()
        {
            InitializeComponent();
            txt_Password.UseSystemPasswordChar = true; // Set default to hide password
            this.Resize += Login_Page_Resize;
            UpdateFormAppearance(); // Initial setup
        }

        private void Login_Page_Resize(object sender, EventArgs e)
        {
            UpdateFormAppearance();
        }

        private void UpdateFormAppearance()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                BackgroundImage = null;
                BackColor = SystemColors.Control;
                guna2GradientPanel1.Left = (ClientSize.Width - guna2GradientPanel1.Width) / 2;
                guna2GradientPanel1.Top = (ClientSize.Height - guna2GradientPanel1.Height) / 2;
            }
            else
            {
                BackgroundImage = Properties.Resources.BackGround_1000x600;
                guna2GradientPanel1.Left = ClientSize.Width - guna2GradientPanel1.Width;
                guna2GradientPanel1.Top = 0;
            }
        }

        // Handle Login
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text.Trim();
            string password = txt_Password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ShowError("Please enter your Username and Password!");
                return;
            }

            this.Cursor = Cursors.WaitCursor; // Show loading cursor
            try
            {
                using var conn = Db.Open();
                string sql = @"
                    SELECT full_name, password_hash
                    FROM staff
                    WHERE username = @username
                      AND is_active = TRUE
                      AND is_deleted = FALSE
                    LIMIT 1;";

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string fullName = reader.GetString(0);
                    string storedHash = reader.GetString(1);

                    if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                    {
                        lbl_IncorrectPass.Visible = false;
                        MessageBox.Show(
                            $"Welcome, {fullName}!",
                            "Login Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        new Dashboard_Form().Show();
                        Hide();
                        this.Cursor = Cursors.Default; // Reset cursor
                        return;
                    }
                }

                ShowError("Username or Password is incorrect!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $" Database error:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                this.Cursor = Cursors.Default; // Always reset cursor
            }
        }

        // Helper for showing errors
        private void ShowError(string message)
        {
            lbl_IncorrectPass.Text = message;
            lbl_IncorrectPass.Visible = true;
        }

        // Toggle password visibility
        private void txt_Password_IconRightClick(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txt_Password.UseSystemPasswordChar = !isPasswordVisible;
            txt_Password.IconRight = isPasswordVisible
                ? Properties.Resources.Closed_Eye
                : Properties.Resources.Eye;
        }
    }
}