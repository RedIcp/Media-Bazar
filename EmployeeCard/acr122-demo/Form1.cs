using CardReader;
using CardReader.Class;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace acr122_demo
{
    public partial class Form1 : Form
    {
        LoginManagement loginManagment;
        public Form1()
        {
            InitializeComponent();
            loginManagment = new LoginManagement();
        }

        //Close app
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        //Login

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string UserName = tbUsername.Text;
            string Password = tbPassword.Text;

            if (checkLogin(UserName, Password))
            {
                EmployeeCard emp = new EmployeeCard(); Hide(); emp.Show();
            }
            else
            {
                MessageBox.Show("Wrong login information! Please try again.");
            }
        }

        private void btnLogin_Enter_1(object sender, EventArgs e)
        {
            string UserName = tbUsername.Text;
            string Password = tbPassword.Text;

            if (checkLogin(UserName, Password))
            {
                EmployeeCard emp = new EmployeeCard(); Hide(); emp.Show();
            }
            else
            {
                MessageBox.Show("Wrong login information! Please try again.");
            }
        }


        //Check login info
        private bool checkLogin( string UserName, string Password)
        {
            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("'UserName' field is required.");
                return false;
            }

            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("'password' field is required.");
                return false;
            }

            int ID = loginManagment.GetID(UserName, Password);
            if (ID != 0)
            {
                switch (loginManagment.checkLogin(UserName, Password))
                {
                    case "OFFICE MANAGER": return true; 
                    case "Wrong info!": return false; 
                }
            }
            return false;
        }
    }
}
