using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

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

                // Add Button
                Button btnAdd = new Button();
                btnAdd.Text = "ADD NEW MEMBER +";
                btnAdd.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btnAdd.BackColor = Color.Black;
                btnAdd.ForeColor = Color.White;
                btnAdd.FlatStyle = FlatStyle.Flat;
                btnAdd.FlatAppearance.BorderSize = 0;
                btnAdd.Size = new Size(200, 45);


                int leftMargin = (pnlMembers.ClientSize.Width - btnAdd.Width) / 2;
                if (leftMargin < 0) leftMargin = 0; // Prevent negative margin crash

                btnAdd.Margin = new Padding(leftMargin, 20, 0, 30);
                // -----------------------

                btnAdd.Cursor = Cursors.Hand;
                btnAdd.Click += BtnAddMember_Click;
                pnlMembers.Controls.Add(btnAdd);
            }
            catch (Exception ex) { MessageBox.Show("Error loading members: " + ex.Message); }
        }

        private Panel CreateMemberPanel(int id, string name, string rel, string phone, string cccd, DateTime dob, bool isPrimary)
        {
            // Main Card
            Panel p = new Panel();
            p.Size = new Size(640, 170);
            p.BackColor = Color.White;
            p.Margin = new Padding(0, 0, 0, 15);

            // Add a subtle bottom border
            Panel bottomBorder = new Panel();
            bottomBorder.Height = 1;
            bottomBorder.Dock = DockStyle.Bottom;
            bottomBorder.BackColor = Color.LightGray;
            p.Controls.Add(bottomBorder);

            // Colored Strip on Left (Gold for Owner, Blue for Member)
            Panel strip = new Panel();
            strip.Width = 5;
            strip.Dock = DockStyle.Left;
            strip.BackColor = isPrimary ? Color.Goldenrod : Color.CornflowerBlue;
            p.Controls.Add(strip);

            // Role Badge (Text Color)
            Color roleColor = isPrimary ? Color.Goldenrod : Color.CornflowerBlue;
            string role = isPrimary ? "PRIMARY OWNER" : "MEMBER";

            Label lblInfo = new Label();
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 11);
            lblInfo.ForeColor = Color.FromArgb(64, 64, 64);
            lblInfo.Location = new Point(20, 15);
            // Rich formatted text workaround using standard label
            lblInfo.Text = $"Fullname: {name.ToUpper()}\n" +
                           $"Relationship: {rel}\n" +
                           $"Phone: {phone}   |   CCCD: {cccd}\n" +
                           $"DOB: {dob:dd/MM/yyyy}\n" +
                           $"Role: {role}";
            p.Controls.Add(lblInfo);

            // Edit Button
            Button btnEdit = new Button();
            btnEdit.Text = "EDIT";
            btnEdit.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnEdit.ForeColor = Color.DimGray;
            btnEdit.BackColor = Color.WhiteSmoke;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Size = new Size(80, 30);
            btnEdit.Location = new Point(540, 20);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Click += (s, e) => EditMember(id);
            p.Controls.Add(btnEdit);

            return p;
        }

        private void EditMember(int memberId)
        {
            Member_Form f = new Member_Form(_householdId, memberId);
            if (f.ShowDialog() == DialogResult.OK) LoadMembers();
        }

        private void BtnAddMember_Click(object? sender, EventArgs e)
        {
            Member_Form f = new Member_Form(_householdId);
            if (f.ShowDialog() == DialogResult.OK) LoadMembers();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void lblStartDate_Click(object sender, EventArgs e)
        {

        }
    }
}