using System;
using System.Windows.Forms;
using Npgsql;

namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class Member_Form : Form
    {
        private int _householdId;
        private int? _memberId = null; // Null means "Add New", Value means "Edit"

        // Constructor for ADDING a new member
        public Member_Form(int householdId)
        {
            InitializeComponent();
            _householdId = householdId;
            this.Text = "Add New Member";
            lblTitle.Text = "Add New Member";
            dtpDob.Value = new DateTime(1990, 1, 1); // Default sensible date
        }

        // Constructor for EDITING an existing member
        public Member_Form(int householdId, int memberId) : this(householdId)
        {
            _memberId = memberId;
            this.Text = "Edit Member";
            lblTitle.Text = "Edit Member";
            LoadMemberData();
        }

        private void LoadMemberData()
        {
            try
            {
                using (var conn = Db.Open())
                {
                    string sql = "SELECT full_name, relationship, phone, cccd, dob, is_primary FROM household_member WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _memberId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader.GetString(0);
                                txtRelation.Text = reader.GetString(1);
                                txtPhone.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                                txtCCCD.Text = reader.IsDBNull(3) ? "" : reader.GetString(3);
                                dtpDob.Value = reader.GetDateTime(4);
                                chkPrimary.Checked = reader.GetBoolean(5);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtRelation.Text))
            {
                MessageBox.Show("Name and Relationship are required!");
                return;
            }

            try
            {
                using (var conn = Db.Open())
                {
                    string sql;
                    if (_memberId == null) // INSERT
                    {
                        sql = @"INSERT INTO household_member (household_id, full_name, relationship, phone, cccd, dob, is_primary)
                                VALUES (@hid, @name, @rel, @phone, @cccd, @dob, @primary)";
                    }
                    else // UPDATE
                    {
                        sql = @"UPDATE household_member 
                                SET full_name=@name, relationship=@rel, phone=@phone, cccd=@cccd, dob=@dob, is_primary=@primary, updated_at=now()
                                WHERE id=@id";
                    }

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@hid", _householdId);
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@rel", txtRelation.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@cccd", txtCCCD.Text.Trim() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@dob", dtpDob.Value);
                        cmd.Parameters.AddWithValue("@primary", chkPrimary.Checked);

                        if (_memberId != null) cmd.Parameters.AddWithValue("@id", _memberId);

                        cmd.ExecuteNonQuery();
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving member: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}