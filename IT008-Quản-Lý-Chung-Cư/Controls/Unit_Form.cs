using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class Unit_Form : Form
    {
        private int _selectedUnitId = -1;
        private bool _isViewOnly = false;

        public Unit_Form()
        {
            InitializeComponent();
            _isViewOnly = false;
        }

        public Unit_Form(int unitId)
        {
            InitializeComponent();
            _selectedUnitId = unitId;
            _isViewOnly = true;
            SetupViewOnlyMode();
        }

        private void Unit_Form_Load(object? sender, EventArgs e)
        {
            if (!_isViewOnly)
            {
                LoadUnits();
                ResetForm();
            }
            else
            {
                LoadUnitDetails(_selectedUnitId);
            }
        }

        // ==================== VIEW ONLY SETUP (UPDATED) ====================

        private void SetupViewOnlyMode()
        {
            // 1. Window Style: Standard Dialog look
            this.Text = "Unit Details";
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Standard "Normal" Popup border
            this.StartPosition = FormStartPosition.CenterParent;

            // 2. Hide the Grid/Right Side
            panelFill.Visible = false;

            // 3. Hide Action Buttons
            btnAdd.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnClear.Visible = false;

            // 4. Resize: Use ClientSize to fit the panel exactly without guessing borders
            // We use panelLeft dimensions directly so it fits tight and looks clean
            panelLeft.Dock = DockStyle.Fill;
            this.ClientSize = new Size(panelLeft.Width, panelLeft.Height);

            // 5. Lock Inputs
            LockControls(panelLeft);
        }

        private void LockControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox tb)
                {
                    tb.ReadOnly = true;
                    tb.BackColor = Color.White; // Keep white background so it's easy to read
                    tb.ForeColor = Color.Black;
                    tb.BorderStyle = BorderStyle.None; // Optional: makes it look more like a label
                }
                else if (c is NumericUpDown nud)
                {
                    // This disables the up/down arrows so they are "non-clickable"
                    nud.Enabled = false;
                    // Fix formatting so it doesn't look too "grayed out"
                    nud.Controls[0].Visible = false; // Hack to hide the arrows visually if needed (optional)
                }
                else if (c is ComboBox cb)
                {
                    cb.Enabled = false;
                }
            }
        }

        // ==================== DATA LOADING ====================

        private void LoadUnits()
        {
            try
            {
                using (var conn = Db.Open())
                {
                    string sql = "SELECT id, unit_code, floor_no, area_m2, bedrooms, bathrooms, unit_type, monthly_rent, status FROM unit WHERE is_deleted = FALSE ORDER BY unit_code";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        var dt = new DataTable();
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                        dgvUnits.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading units: " + ex.Message);
            }
        }

        private void LoadUnitDetails(int id)
        {
            try
            {
                using (var conn = Db.Open())
                {
                    string sql = "SELECT * FROM unit WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCode.Text = reader["unit_code"].ToString();
                                numFloor.Value = Convert.ToDecimal(reader["floor_no"]);
                                txtArea.Text = reader["area_m2"].ToString();
                                numBed.Value = Convert.ToDecimal(reader["bedrooms"]);
                                numBath.Value = Convert.ToDecimal(reader["bathrooms"]);
                                txtRent.Text = reader["monthly_rent"].ToString();

                                string? type = reader["unit_type"].ToString();
                                if (!string.IsNullOrEmpty(type) && cmbType.Items.Contains(type))
                                    cmbType.SelectedItem = type;

                                string? status = reader["status"].ToString();
                                if (!string.IsNullOrEmpty(status) && cmbStatus.Items.Contains(status))
                                    cmbStatus.SelectedItem = status;
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

        // ==================== CRUD OPERATIONS ====================

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (_isViewOnly) return;
            if (!ValidateInput()) return;

            try
            {
                using (var conn = Db.Open())
                {
                    string sql = @"INSERT INTO unit (unit_code, floor_no, area_m2, bedrooms, bathrooms, unit_type, monthly_rent, status)
                                   VALUES (@code, @floor, @area, @bed, @bath, @type, @rent, @status)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@code", txtCode.Text.Trim());
                        cmd.Parameters.AddWithValue("@floor", (int)numFloor.Value);
                        cmd.Parameters.AddWithValue("@area", decimal.Parse(txtArea.Text.Trim()));
                        cmd.Parameters.AddWithValue("@bed", (int)numBed.Value);
                        cmd.Parameters.AddWithValue("@bath", (int)numBath.Value);
                        cmd.Parameters.AddWithValue("@type", cmbType.SelectedItem?.ToString() ?? "Studio");
                        cmd.Parameters.AddWithValue("@rent", decimal.Parse(txtRent.Text.Trim()));
                        cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem?.ToString() ?? "VACANT");
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Unit added!");
                LoadUnits();
                ResetForm();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (_isViewOnly || _selectedUnitId == -1) return;
            if (!ValidateInput()) return;

            try
            {
                using (var conn = Db.Open())
                {
                    string sql = @"UPDATE unit SET unit_code = @code, floor_no = @floor, area_m2 = @area, 
                                   bedrooms = @bed, bathrooms = @bath, unit_type = @type, 
                                   monthly_rent = @rent, status = @status, updated_at = now()
                                   WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@code", txtCode.Text.Trim());
                        cmd.Parameters.AddWithValue("@floor", (int)numFloor.Value);
                        cmd.Parameters.AddWithValue("@area", decimal.Parse(txtArea.Text.Trim()));
                        cmd.Parameters.AddWithValue("@bed", (int)numBed.Value);
                        cmd.Parameters.AddWithValue("@bath", (int)numBath.Value);
                        cmd.Parameters.AddWithValue("@type", cmbType.SelectedItem?.ToString() ?? "Studio");
                        cmd.Parameters.AddWithValue("@rent", decimal.Parse(txtRent.Text.Trim()));
                        cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem?.ToString() ?? "VACANT");
                        cmd.Parameters.AddWithValue("@id", _selectedUnitId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Unit updated!");
                LoadUnits();
                ResetForm();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (_isViewOnly || _selectedUnitId == -1) return;
            if (MessageBox.Show("Delete this unit?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var conn = Db.Open())
                    {
                        new NpgsqlCommand($"UPDATE unit SET is_deleted = TRUE WHERE id = {_selectedUnitId}", conn).ExecuteNonQuery();
                    }
                    MessageBox.Show("Unit deleted!");
                    LoadUnits();
                    ResetForm();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void dgvUnits_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (_isViewOnly) return;
            if (e.RowIndex >= 0)
            {
                _selectedUnitId = Convert.ToInt32(dgvUnits.Rows[e.RowIndex].Cells["id"].Value);
                LoadUnitDetails(_selectedUnitId);
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnClear_Click(object? sender, EventArgs e) { ResetForm(); }

        private void ResetForm()
        {
            _selectedUnitId = -1;
            txtCode.Clear(); numFloor.Value = 0; txtArea.Clear(); numBed.Value = 0; numBath.Value = 0; txtRent.Clear();
            if (cmbType.Items.Count > 0) cmbType.SelectedIndex = 0;
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
            btnAdd.Enabled = true; btnUpdate.Enabled = false; btnDelete.Enabled = false;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) || !decimal.TryParse(txtArea.Text, out _) || !decimal.TryParse(txtRent.Text, out _))
            {
                MessageBox.Show("Invalid input.");
                return false;
            }
            return true;
        }
    }
}