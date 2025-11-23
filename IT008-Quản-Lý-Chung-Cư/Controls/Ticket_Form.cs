using System;
using System.Windows.Forms;
using Npgsql;

namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class Ticket_Form : Form
    {
        public class UnitItem { public int Id; public string Code; public override string ToString() => Code; }

        private int _staffId;
        private int? _ticketId = null;

        // Constructor for Create
        public Ticket_Form(int staffId)
        {
            InitializeComponent();
            _staffId = staffId;
            LoadUnits();
            cbStatus.SelectedIndex = 0; // Default OPEN
        }

        // Constructor for Edit
        public Ticket_Form(int staffId, int ticketId) : this(staffId)
        {
            _ticketId = ticketId;
            this.Text = "Edit Ticket";
            lblTitle.Text = "Edit Ticket";
            btnSave.Text = "UPDATE TICKET";
            cbUnit.Enabled = false; // Cannot change unit of existing ticket
            LoadTicketData();
        }

        private void LoadUnits()
        {
            try
            {
                using (var conn = Db.Open())
                {
                    string sql = "SELECT id, unit_code FROM unit WHERE status = 'OCCUPIED' AND is_deleted = FALSE ORDER BY unit_code";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbUnit.Items.Add(new UnitItem { Id = reader.GetInt32(0), Code = reader.GetString(1) });
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error units: " + ex.Message); }
        }

        private void LoadTicketData()
        {
            try
            {
                using (var conn = Db.Open())
                {
                    string sql = "SELECT unit_id, title, description, status FROM ticket WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _ticketId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int unitId = reader.GetInt32(0);
                                txtTitle.Text = reader.GetString(1);
                                txtDesc.Text = reader.GetString(2);
                                string status = reader.GetString(3);

                                cbStatus.SelectedItem = status;

                                foreach (UnitItem item in cbUnit.Items)
                                {
                                    if (item.Id == unitId) { cbUnit.SelectedItem = item; break; }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading ticket: " + ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbUnit.SelectedItem == null) { MessageBox.Show("Select a unit."); return; }
            if (string.IsNullOrWhiteSpace(txtTitle.Text)) { MessageBox.Show("Enter a title."); return; }

            try
            {
                using (var conn = Db.Open())
                {
                    string status = cbStatus.SelectedItem.ToString();
                    string sql;

                    if (_ticketId == null) // INSERT
                    {
                        // FIXED: Removed "::ticket_status" cast. Now it just inserts the string directly.
                        sql = "INSERT INTO ticket (unit_id, title, description, status, created_by_staff_id) VALUES (@uid, @title, @desc, @status, @staff)";
                    }
                    else // UPDATE
                    {
                        // FIXED: Removed "::ticket_status" cast here too.
                        sql = "UPDATE ticket SET title=@title, description=@desc, status=@status, updated_at=now() WHERE id=@id";
                    }

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@desc", txtDesc.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@staff", _staffId);

                        if (_ticketId == null)
                        {
                            UnitItem u = (UnitItem)cbUnit.SelectedItem;
                            cmd.Parameters.AddWithValue("@uid", u.Id);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@id", _ticketId);
                        }

                        cmd.ExecuteNonQuery();
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error saving ticket: " + ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}