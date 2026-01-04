using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using Guna.UI2.WinForms;
using IT008_Quản_Lý_Chung_Cư.Controls;


namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    public partial class ViewProfile_Control : UserControl
    {
        private int _staffId;
        public ViewProfile_Control(int staffId)
        {
            InitializeComponent();
            _staffId = staffId;
            LoadProfile();

            btn_EditProfile.Click += btn_EditProfile_Click;
        }

        private void LoadProfile()
        {
            try
            {
                using (var conn = Db.Open())
                {
                    string sql = "SELECT id, username, full_name, phone, email, role FROM staff WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _staffId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_ID.Text = reader["id"].ToString();
                                lbl_RoleIs.Text = reader["role"].ToString();
                                txt_Username.Text = reader["username"].ToString();
                                txt_Phone.Text = reader.IsDBNull(3) ? "" : reader.GetString(3);
                                txt_Email.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);
                                txt_Password.Text = "**********";
                            }
                            else
                            {
                                MessageBox.Show("Staff profile not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_EditProfile_Click(object sender, EventArgs e)
        {
            if (this.Parent is Control parentContainer)
            {
                parentContainer.Controls.Clear();

                MyProfileControl editControl = new MyProfileControl(_staffId);
                editControl.Dock = DockStyle.Fill;
                parentContainer.Controls.Add(editControl);
            }
            else
            {
                MessageBox.Show("Could not find the parent container to switch screens.", "Switching Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pB_Username_Click(object sender, EventArgs e)
        {

        }
    }
}