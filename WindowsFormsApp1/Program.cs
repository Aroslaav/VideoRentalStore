using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoRentalStore;

namespace VideoRentalStoreUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginDlg = new LoginForm();
            DialogResult result = loginDlg.ShowDialog();
            if(result== DialogResult.OK)
                Application.Run(new MainForm());
        }
    }
}
