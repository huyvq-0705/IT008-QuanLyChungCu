using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class Dashboard_Form : Form
    {
        private ProgressBar progressBarLoad;
        private Label lblLoadStatus;

        public Dashboard_Form()
        {
            InitializeComponent();

            progressBarLoad = new ProgressBar()
            {
                Name = "progressBarLoad",
                Minimum = 0,
                Maximum = 100,
                Value = 0,
                Size = new Size(300, 20),
                Location = new Point(210, 10),
                Style = ProgressBarStyle.Blocks,
                Visible = false
            };

            lblLoadStatus = new Label()
            {
                Name = "lblLoadStatus",
                Text = "",
                AutoSize = true,
                Location = new Point(progressBarLoad.Right + 8, progressBarLoad.Top - 2),
                Visible = false
            };

            this.Controls.Add(progressBarLoad);
            this.Controls.Add(lblLoadStatus);
            this.Load += Dashboard_Form_Load;
        }

        private async void Dashboard_Form_Load(object? sender, EventArgs e)
        {
            progressBarLoad.Visible = true;
            lblLoadStatus.Visible = true;
            progressBarLoad.Value = 0;
            lblLoadStatus.Text = "Loading 0%";

            var progress = new Progress<int>(percent =>
            {
                if (percent < progressBarLoad.Minimum) percent = progressBarLoad.Minimum;
                if (percent > progressBarLoad.Maximum) percent = progressBarLoad.Maximum;
                progressBarLoad.Value = percent;
                lblLoadStatus.Text = $"Loading {percent}%";
            });

            try
            {
                await Task.Run(() => LoadDashboardData(progress));
                lblLoadStatus.Text = "Load Complete!";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblLoadStatus.Text = "Load Failed!";
            }
            finally
            {
                await Task.Delay(500);
                progressBarLoad.Visible = false;
                lblLoadStatus.Visible = false;
            }
        }

        private void LoadDashboardData(IProgress<int> progress)
        {
            for (int i = 0; i <= 100; i += 10)
            {
                System.Threading.Thread.Sleep(200);
                progress.Report(i);
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff menu clicked", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Add your navigation logic here
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unit menu clicked", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Add your navigation logic here
        }

        private void btnHousehold_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Household menu clicked", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Add your navigation logic here
        }

        private void btnMeterReading_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meter reading menu clicked", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Add your navigation logic here
        }

        private void btnMonthlyBill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Monthly bill menu clicked", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Add your navigation logic here
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ticket menu clicked", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Add your navigation logic here
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Add your logout logic here
                this.Close();
            }
        }
    }
}