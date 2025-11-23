using System;
using System.Windows.Forms;

namespace IT008_Quản_Lý_Chung_Cư
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Start with the Login Page
            Application.Run(new Login_Page());
        }
    }
}