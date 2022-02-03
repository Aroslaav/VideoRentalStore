using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VideoRentalStore;

namespace VideoRentalStoreUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
#if DEBUG
            txtPassword.Text = "1";
            txtUserName.Text = "admin";

#endif
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CAuthentication.Login(txtUserName.Text, CUser.GetHashString(txtUserName.Text+txtPassword.Text)))
            {
               
                    DialogResult = DialogResult.OK;
                    this.Close();
            }
            else 
            {
                DialogResult = DialogResult.Cancel;
                MessageBox.Show("Authification is failed!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
