using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using BCrypt.Net;

namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    public partial class MyProfileControl : UserControl
    {
        private int _staffId;

        public MyProfileControl(int staffId)
        {
            InitializeComponent();
            _staffId = staffId;
            LoadProfile();
        }

        private void LoadProfile()
        {
            try
            {
                using (var conn = Db.Open())
                {
                    // We select specific columns to match the textboxes
                    string sql = "SELECT id, username, full_name, phone, email, role FROM staff WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _staffId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Read-only fields (Labels)
                                lblIdValue.Text = reader["id"].ToString();
                                lblRoleValue.Text = reader["role"].ToString();

                                // Editable fields (TextBoxes)
                                txtUsername.Text = reader["username"].ToString();
                                txtFullName.Text = reader["full_name"].ToString();
                                txtPhone.Text = reader.IsDBNull(3) ? "" : reader.GetString(3);
                                txtEmail.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Username and Full Name are required.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to update your profile?", "Confirm Update", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (var conn = Db.Open())
                {
                    bool updatePassword = !string.IsNullOrWhiteSpace(txtPassword.Text);
                    string sql;

                    if (updatePassword)
                    {
                        sql = @"UPDATE staff 
                                SET username = @user, full_name = @name, phone = @phone, email = @email, password_hash = @pass, updated_at = now() 
                                WHERE id = @id";
                    }
                    else
                    {
                        sql = @"UPDATE staff 
                                SET username = @user, full_name = @name, phone = @phone, email = @email, updated_at = now() 
                                WHERE id = @id";
                    }

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@id", _staffId);

                        if (updatePassword)
                        {
                            string hashed = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", hashed);
                        }

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Clear();
                btn_Back_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (this.Parent is Control parentContainer)
            {
                parentContainer.Controls.Clear();

                ViewProfile_Control viewControl = new ViewProfile_Control(_staffId);
                viewControl.Dock = DockStyle.Fill;
                parentContainer.Controls.Add(viewControl);
            }
            else
            {
                MessageBox.Show("Could not find the parent container to switch screens.", "Switching Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}