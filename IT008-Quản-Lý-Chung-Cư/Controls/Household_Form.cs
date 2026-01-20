using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using Guna.UI2.WinForms;

namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class Household_Form : Form
    {
        private int _householdId;

        public Household_Form(int householdId)
        {
            InitializeComponent();
            _householdId = householdId;
            this.Load += Household_Form_Load;

            // Add hover effect for Return button
            btnClose.MouseEnter += (s, e) => btnClose.ForeColor = Color.FromArgb(52, 152, 219);
            btnClose.MouseLeave += (s, e) => btnClose.ForeColor = Color.FromArgb(100, 100, 100);

            // Add hover effect for Edit button
            btnEditHousehold.MouseEnter += (s, e) => btnEditHousehold.ForeColor = Color.FromArgb(41, 128, 185);
            btnEditHousehold.MouseLeave += (s, e) => btnEditHousehold.ForeColor = Color.FromArgb(52, 152, 219);
        }

        private void Household_Form_Load(object? sender, EventArgs e)
        {
            LoadDetails();
            LoadMembers();
        }

        private void LoadDetails()
        {
            try
            {
                using (var conn = Db.Open())
                {
                    string sql = @"
                        SELECT u.unit_code, h.start_date, h.end_date, h.note 
                        FROM household h
                        JOIN unit u ON h.unit_id = u.id
                        WHERE h.id = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _householdId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblUnitCode.Text = $"Unit Code: {reader["unit_code"]}";

                                DateTime start = reader.GetDateTime(1);
                                lblStartDate.Text = $"Start Date: {start:dd/MM/yyyy}";

                                if (reader.IsDBNull(2))
                                {
                                    lblEndDate.Text = "End Date: Present";
                                    lblEndDate.ForeColor = Color.SeaGreen;
                                }
                                else
                                {
                                    lblEndDate.Text = $"End Date: {reader.GetDateTime(2):dd/MM/yyyy}";
                                    lblEndDate.ForeColor = Color.Gray;
                                }

                                txtNote.Text = reader.IsDBNull(3) ? "" : reader.GetString(3);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading details: " + ex.Message);
            }
        }

        private void LoadMembers()
        {
            pnlMembers.Controls.Clear();

            try
            {
                using (var conn = Db.Open())
                {
                    string sql = "SELECT id, full_name, relationship, phone, cccd, dob, is_primary FROM household_member WHERE household_id = @hid AND is_deleted = FALSE ORDER BY is_primary DESC, id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@hid", _householdId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int memId = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                string rel = reader.GetString(2);
                                string phone = reader.IsDBNull(3) ? "N/A" : reader.GetString(3);
                                string cccd = reader.IsDBNull(4) ? "N/A" : reader.GetString(4);
                                DateTime dob = reader.GetDateTime(5);
                                bool isPrimary = reader.GetBoolean(6);

                                pnlMembers.Controls.Add(CreateMemberPanel(memId, name, rel, phone, cccd, dob, isPrimary));
                            }
                        }
                    }
                }

                // Add "ADD NEW MEMBER" button
                Guna2Button btnAdd = new Guna2Button();
                btnAdd.Text = "ADD NEW MEMBER +";
                btnAdd.Font = new Font("Arial", 11, FontStyle.Bold);
                btnAdd.FillColor = Color.FromArgb(46, 204, 113);
                btnAdd.ForeColor = Color.White;
                btnAdd.BorderRadius = 10;
                btnAdd.Size = new Size(280, 55);
                btnAdd.Cursor = Cursors.Hand;

                // Calculate center margin for the button
                int availableWidth = pnlMembers.ClientSize.Width - pnlMembers.Padding.Left - pnlMembers.Padding.Right;
                int leftMargin = Math.Max(0, (availableWidth - btnAdd.Width) / 2);

                btnAdd.Margin = new Padding(leftMargin, 25, 0, 35);
                btnAdd.Click += BtnAddMember_Click;
                pnlMembers.Controls.Add(btnAdd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members: " + ex.Message);
            }
        }

        private Guna2Panel CreateMemberPanel(int id, string name, string rel, string phone, string cccd, DateTime dob, bool isPrimary)
        {
            // Main panel - increased height for better spacing
            Guna2Panel p = new Guna2Panel();
            p.Size = new Size(1100, 120);
            p.Margin = new Padding(0, 0, 0, 15);
            p.FillColor = Color.White;
            p.BorderRadius = 12;
            p.ShadowDecoration.Enabled = true;
            p.ShadowDecoration.Depth = 8;
            p.ShadowDecoration.BorderRadius = 12;
            p.ShadowDecoration.Color = Color.FromArgb(200, 200, 200);

            Color primaryColor = isPrimary ? Color.FromArgb(255, 193, 7) : Color.FromArgb(52, 152, 219);
            string role = isPrimary ? "PRIMARY OWNER" : "MEMBER";

            // Left color strip
            Guna2Panel strip = new Guna2Panel();
            strip.Width = 10;
            strip.Dock = DockStyle.Left;
            strip.FillColor = primaryColor;
            p.Controls.Add(strip);

            // Member name - adjusted positioning
            Guna2HtmlLabel lblName = new Guna2HtmlLabel();
            lblName.Font = new Font("Arial", 13F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(30, 30, 30);
            lblName.Location = new Point(30, 15);
            lblName.Text = name.ToUpper();
            lblName.AutoSize = true;
            p.Controls.Add(lblName);

            // Role label
            Guna2HtmlLabel lblRole = new Guna2HtmlLabel();
            lblRole.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblRole.ForeColor = primaryColor;
            lblRole.Location = new Point(30, 45);
            lblRole.Text = $"Role: {role}";
            lblRole.AutoSize = true;
            p.Controls.Add(lblRole);

            // Details label - split into two lines for better readability
            Guna2HtmlLabel lblDetails1 = new Guna2HtmlLabel();
            lblDetails1.Font = new Font("Arial", 9.5F, FontStyle.Regular);
            lblDetails1.ForeColor = Color.FromArgb(100, 100, 100);
            lblDetails1.Location = new Point(30, 72);
            lblDetails1.Text = $"Relationship: {rel} | Phone: {phone}";
            lblDetails1.AutoSize = true;
            p.Controls.Add(lblDetails1);

            Guna2HtmlLabel lblDetails2 = new Guna2HtmlLabel();
            lblDetails2.Font = new Font("Arial", 9.5F, FontStyle.Regular);
            lblDetails2.ForeColor = Color.FromArgb(100, 100, 100);
            lblDetails2.Location = new Point(30, 92);
            lblDetails2.Text = $"CCCD: {cccd} | DOB: {dob:dd/MM/yyyy}";
            lblDetails2.AutoSize = true;
            p.Controls.Add(lblDetails2);

            // Edit button - repositioned
            Guna2Button btnEdit = new Guna2Button();
            btnEdit.Text = "EDIT";
            btnEdit.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.FillColor = Color.FromArgb(52, 152, 219);
            btnEdit.BorderRadius = 8;
            btnEdit.Size = new Size(100, 45);
            btnEdit.Location = new Point(p.Width - 120, 38);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Click += (s, e) => EditMember(id);
            p.Controls.Add(btnEdit);

            // Delete button - repositioned
            Guna2Button btnDelete = new Guna2Button();
            btnDelete.Text = "DEL";
            btnDelete.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.FillColor = Color.FromArgb(231, 76, 60);
            btnDelete.BorderRadius = 8;
            btnDelete.Size = new Size(70, 45);
            btnDelete.Location = new Point(p.Width - 205, 38);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Click += (s, e) => DeleteMember(id);
            p.Controls.Add(btnDelete);

            return p;
        }

        private void EditMember(int memberId)
        {
            Form f = new Member_Form(_householdId, memberId);
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadMembers();
            }
        }

        private void DeleteMember(int memberId)
        {
            if (MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (var conn = Db.Open())
                    {
                        string sql = "UPDATE household_member SET is_deleted = TRUE, deleted_at = now() WHERE id = @id";
                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", memberId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMembers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting member: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAddMember_Click(object? sender, EventArgs e)
        {
            Form f = new Member_Form(_householdId);
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadMembers();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditHousehold_Click(object sender, EventArgs e)
        {
            Form f = new EditHousehold_Form(_householdId);
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDetails(); // Refresh the details after editing
            }
        }

        private void lblStartDate_Click(object sender, EventArgs e)
        {
            // Reserved for future functionality
        }
    }
}