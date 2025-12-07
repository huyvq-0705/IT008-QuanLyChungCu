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
            catch (Exception ex) { MessageBox.Show("Error loading details: " + ex.Message); }
        }

        private void LoadMembers()
        {
            pnlMembers.Controls.Clear();

            try
            {
                using (var conn = Db.Open())
                {
                    string sql = "SELECT id, full_name, relationship, phone, cccd, dob, is_primary FROM household_member WHERE household_id = @hid ORDER BY is_primary DESC, id";
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

                Guna2Button btnAdd = new Guna2Button();
                btnAdd.Text = "ADD NEW MEMBER +";
                btnAdd.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                btnAdd.FillColor = Color.FromArgb(46, 204, 113);
                btnAdd.ForeColor = Color.White;
                btnAdd.BorderRadius = 10;
                btnAdd.Size = new Size(250, 50);
                btnAdd.Cursor = Cursors.Hand;

                int leftMargin = (pnlMembers.ClientSize.Width - btnAdd.Width) / 2;
                if (leftMargin < 0) leftMargin = 0;

                btnAdd.Margin = new Padding(leftMargin, 20, 0, 30);

                btnAdd.Click += BtnAddMember_Click;
                pnlMembers.Controls.Add(btnAdd);
            }
            catch (Exception ex) { MessageBox.Show("Error loading members: " + ex.Message); }
        }

        private Guna2Panel CreateMemberPanel(int id, string name, string rel, string phone, string cccd, DateTime dob, bool isPrimary)
        {
            Guna2Panel p = new Guna2Panel();
            p.Size = new Size(850, 100);
            p.Margin = new Padding(0, 0, 0, 10);
            p.FillColor = Color.White;
            p.BorderRadius = 12;
            p.ShadowDecoration.Enabled = true;
            p.ShadowDecoration.Depth = 5;
            p.ShadowDecoration.BorderRadius = 12;
            p.ShadowDecoration.Color = Color.LightGray;

            Color primaryColor = isPrimary ? Color.FromArgb(255, 193, 7) : Color.FromArgb(52, 152, 219);
            string role = isPrimary ? "PRIMARY OWNER" : "MEMBER";

            Guna2Panel strip = new Guna2Panel();
            strip.Width = 8;
            strip.Dock = DockStyle.Left;
            strip.FillColor = primaryColor;
            p.Controls.Add(strip);

            Guna2HtmlLabel lblName = new Guna2HtmlLabel();
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(41, 50, 65);
            lblName.Location = new Point(25, 10);
            lblName.Text = name.ToUpper();
            p.Controls.Add(lblName);

            Guna2HtmlLabel lblRole = new Guna2HtmlLabel();
            lblRole.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRole.ForeColor = primaryColor;
            lblRole.Location = new Point(25, 38);
            lblRole.Text = $"Role: {role}";
            p.Controls.Add(lblRole);

            Guna2HtmlLabel lblDetails = new Guna2HtmlLabel();
            lblDetails.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblDetails.ForeColor = Color.Gray;
            lblDetails.Location = new Point(25, 65);
            lblDetails.Text = $"Relationship: {rel} | Phone: {phone} | CCCD: {cccd} | DOB: {dob:dd/MM/yyyy}";
            p.Controls.Add(lblDetails);

            Guna2Button btnEdit = new Guna2Button();
            btnEdit.Text = "EDIT";
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.FillColor = Color.FromArgb(52, 152, 219);
            btnEdit.BorderRadius = 8;
            btnEdit.Size = new Size(90, 40);
            btnEdit.Location = new Point(p.Width - 110, 30);
            btnEdit.Cursor = Cursors.Hand;

            btnEdit.Click += (s, e) => EditMember(id);
            p.Controls.Add(btnEdit);

            return p;
        }

        private void EditMember(int memberId)
        {
            Form f = new Member_Form(_householdId, memberId);
            if (f.ShowDialog() == DialogResult.OK) LoadMembers();
        }

        private void BtnAddMember_Click(object? sender, EventArgs e)
        {
            Form f = new Member_Form(_householdId);
            if (f.ShowDialog() == DialogResult.OK) LoadMembers();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void lblStartDate_Click(object sender, EventArgs e)
        {

        }
    }
}