using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Statistics
{
    public partial class Login : Form
    {
        LoginManagement loginManagment = new LoginManagement();
        public Login()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = tbUsername.Text;
            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("'UserName' field is required.");
                return;
            }

            string Password = tbPassword.Text;
            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("'password' field is required.");
                return;
            }

            int ID = loginManagment.GetID(UserName, Password);
            if (ID != 0)
            {
                switch (loginManagment.checkLogin(UserName, Password))
                {
                    case "CEO": Statistics stat = new Statistics(); Hide(); stat.Show(); break;
                    case "Wrong info!": MessageBox.Show("Wrong info!"); break;
                }
            }
            else
            {
                MessageBox.Show("Wrong login information! Please try again.");
            }
        }
    }
}
