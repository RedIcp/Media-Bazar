using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.ManagmentClasses;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class FormLogin : Form
    {
        Login login;
        public FormLogin()
        {
            InitializeComponent();
            login = new Login(new LoginManagment(new dbLoginManager()));
        }

        //Close app
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        // Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = tbxUsername.Text;
            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("'UserName' field is required.");
                return;
            }

            string Password = tbxPassword.Text;
            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("'password' field is required.");
                return;
            }

            int ID = login.GetID(UserName, Password);
            if (ID != 0)
            {
                Employee employee = login.CheckLogin(UserName, Password);
                if (employee is Admin)
                {
                    MakeBackups admin = new MakeBackups(); Hide(); admin.Show();
                }
                else
                { 
                    MessageBox.Show("Wrong info!"); 
                }
            }
            else
            {
                MessageBox.Show("Wrong login information! Please try again.");
            }
        }
        private void btnLogin_Enter(object sender, EventArgs e)
        {
            string UserName = tbxUsername.Text;
            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("'UserName' field is required.");
                return;
            }

            string Password = tbxPassword.Text;
            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("'password' field is required.");
                return;
            }

            int ID = login.GetID(UserName, Password);
            if (ID != 0)
            {
                Employee employee = login.CheckLogin(UserName, Password);
                if (employee is Admin)
                {
                    MakeBackups admin = new MakeBackups(); Hide(); admin.Show();
                }
                else
                {
                    MessageBox.Show("Wrong info!");
                }
            }
            else
            {
                MessageBox.Show("Wrong login information! Please try again.");
            }
        }
    }
}
