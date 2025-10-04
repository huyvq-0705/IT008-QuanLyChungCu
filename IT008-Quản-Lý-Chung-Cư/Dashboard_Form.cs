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
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_Close_Dashboard_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
