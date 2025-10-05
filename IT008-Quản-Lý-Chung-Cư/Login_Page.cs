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
        }

        // Close the app
        private void btn_Close_LoginForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize window
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
