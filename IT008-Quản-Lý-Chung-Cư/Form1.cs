using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
namespace IT008_Quản_Lý_Chung_Cư
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Close_LoginForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text.Trim();
            string password = txt_Password.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lbl_IncorrectPass.Text = "Please enter your Username and Password!";
                lbl_IncorrectPass.Location = new Point(115, 400);
                lbl_IncorrectPass.Visible = true;
                return;
            }
            if (username != "admin" || password != "123456")
            {
                lbl_IncorrectPass.Text = "Username or Passwerod is incorrect!";
                lbl_IncorrectPass.Location = new Point(135, 400);
                lbl_IncorrectPass.Visible = true;
                return;
            }
            lbl_IncorrectPass.Visible = false;
            Dashboard_Form dashboard = new Dashboard_Form();
            dashboard.Show();
            this.Hide();
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {


        }
        bool isPasswordVisible = false;
        private void txt_Password_IconRightClick(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                txt_Password.UseSystemPasswordChar = false;
                txt_Password.IconRight = Properties.Resources.Eye;
                isPasswordVisible = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
                txt_Password.IconRight = Properties.Resources.Closed_Eye;
                isPasswordVisible = true;
            }
        }


    }
}
