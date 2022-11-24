using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryProject;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.ManagmentClasses;

namespace AdminBackups
{
    public partial class FormLogin : Form
    {
        Login login;
        Store store;

        public FormLogin()
        {
            InitializeComponent();

            login = new Login(new LoginManagment(new dbLoginManager()));
            store = new Store();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("'UserName' field is required.");
                return;
            }

            string password = tbxPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("'password' field is required.");
                return;
            }

            if (Login(username, password))
            {
                tbxUsername.Text = "";
                tbxPassword.Text = "";
            }
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("'UserName' field is required.");
                return;
            }

            string password = tbxPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("'password' field is required.");
                return;
            }

            if (Login(username, password))
            {
                tbxUsername.Text = "";
                tbxPassword.Text = "";
            }
        }
        private bool Login(string username, string password)
        {
            Employee employee = login.CheckLogin(username, password);

            if (employee != null)
            {
                if (employee is CEO)
                {
                    MessageBox.Show("Please use the CEO application");
                    return false;
                } else if (employee is Admin)
                {
                    FormAdmin formAdmin = new FormAdmin((Admin)employee, store);
                    formAdmin.Show();
                    this.Hide();
                    return true;
                }
                else if (employee is SalesManager)
                {
                    FormSalesManager formSalesManager = new FormSalesManager((SalesManager)employee, store);
                    formSalesManager.Show();
                    this.Hide();
                    return true;
                }
                else if (employee is OfficeManager)
                {
                    FormOfficeManager formOfficeManager = new FormOfficeManager((OfficeManager)employee, store);
                    formOfficeManager.Show();
                    this.Hide();
                    return true;
                }
                else if (employee is ProductManager)
                {
                    FormProductManager formProductManager = new FormProductManager((ProductManager)employee, store);
                    formProductManager.Show();
                    this.Hide();
                    return true;
                }
                else if (employee is DepotManager)
                {
                    FormDepotManager formDepotManager = new FormDepotManager((DepotManager)employee, store, this);
                    formDepotManager.Show();

                    Hide();

                    return true;
                }
                else if (employee is DepotEmployee)
                {
                    FormDepotEmployee formDepotEmployee = new FormDepotEmployee((DepotEmployee)employee, store, this);
                    formDepotEmployee.Show();

                    Hide();

                    return true;
                }
                else if (employee is SalesRepresentative)
                {
                    MessageBox.Show("Please use the Sales Representative remote application");
                    return false;
                }
            } else
            {
                MessageBox.Show("Wrong credentials");
                return false;
            }
            return false;
        }
    }
}
