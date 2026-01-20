using System;
using System.Windows.Forms;
using Npgsql;

namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class EditHousehold_Form : Form
    {
        private int _householdId;

        public EditHousehold_Form(int householdId)
        {
            InitializeComponent();
            _householdId = householdId;
            LoadHouseholdData();
        }

        private void LoadHouseholdData()
        {
            try
            {
                using (var conn = Db.Open())
                {
                    string sql = @"
                        SELECT h.start_date, h.end_date, h.note, u.unit_code
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
                                lblUnitCode.Text = $"Unit: {reader.GetString(3)}";
                                dtpStartDate.Value = reader.GetDateTime(0);

                                if (reader.IsDBNull(1))
                                {
                                    chkEndDate.Checked = false;
                                    dtpEndDate.Enabled = false;
                                    dtpEndDate.Value = DateTime.Now;
                                }
                                else
                                {
                                    chkEndDate.Checked = true;
                                    dtpEndDate.Enabled = true;
                                    dtpEndDate.Value = reader.GetDateTime(1);
                                }

                                txtNote.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading household data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkEndDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpEndDate.Enabled = chkEndDate.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (dtpStartDate.Value > DateTime.Now)
            {
                MessageBox.Show("Start date cannot be in the future!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chkEndDate.Checked && dtpEndDate.Value <= dtpStartDate.Value)
            {
                MessageBox.Show("End date must be after start date!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = Db.Open())
                {
                    string sql = @"
                        UPDATE household 
                        SET start_date = @start, 
                            end_date = @end, 
                            note = @note,
                            updated_at = now()
                        WHERE id = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _householdId);
                        cmd.Parameters.AddWithValue("@start", dtpStartDate.Value.Date);

                        if (chkEndDate.Checked)
                            cmd.Parameters.AddWithValue("@end", dtpEndDate.Value.Date);
                        else
                            cmd.Parameters.AddWithValue("@end", DBNull.Value);

                        cmd.Parameters.AddWithValue("@note", string.IsNullOrWhiteSpace(txtNote.Text) ? DBNull.Value : txtNote.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Household updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating household: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}