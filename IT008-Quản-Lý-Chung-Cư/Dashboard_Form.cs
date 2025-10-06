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
                Location = new Point(10, 10),
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

        private void btn_Close_Dashboard_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
