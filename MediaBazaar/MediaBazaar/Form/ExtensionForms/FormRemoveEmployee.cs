using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;


namespace AdminBackups
{
    public partial class FormRemoveEmployee : Form
    {
        OfficeManager officeManager;
        Employee selectedEmployee;
        Contract contract;
        public FormRemoveEmployee(OfficeManager om, Employee e, Contract c)
        {
            InitializeComponent();

            this.officeManager = om;
            this.selectedEmployee = e;
            this.contract = c;

            this.Text = $"Remove {e.FirstName} {e.LastName}";
            lblEmployee.Text = $"{e.EmployeeID} - {e.FirstName} {e.LastName}";

            tbxEndDate.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MakeEmployeeInactive())
            {
                if (officeManager.EmployeeManagerOffice.DeleteEmployee(selectedEmployee))
                {
                    var formOfficeManager = Application.OpenForms.OfType<FormOfficeManager>().FirstOrDefault();
                   
                    if (formOfficeManager.tbxSearchEmployee.Text == "")
                    {
                        formOfficeManager.ReadEmployees();
                    }
                    else
                    {
                        formOfficeManager.UserSearchBar();
                    }

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Contract dosn't exist");
            }
        }
        public bool MakeEmployeeInactive()
        {
            if (contract != null)
            {
                if (string.IsNullOrEmpty(tbxReasonTermination.Text))
                {
                    MessageBox.Show("Please enter a reason for termination");
                    return false;
                }
                contract.ReasonForTermination = tbxReasonTermination.Text;

                contract.EndDate = tbxEndDate.Value;
                // put some validation for the date: end date after start date, end date not in the past, end date max 1 month from DateTime.Now...
                contract.IsActive = false;

                return officeManager.ContractManager.UpdateContract(contract);
            }

            return false;
        }

        public bool UpdateContract()
        {

            string reasonForTermination = tbxReasonTermination.Text;
            if (string.IsNullOrEmpty(reasonForTermination))
            {
                MessageBox.Show("Please enter a reason for termination");
                return false;
            }

            string contractEndDate;
            if (Regex.IsMatch(tbxEndDate.Text, @"\d{4}\-(0[1-9]|1[012])\-(0[1-9]|[12][0-9]|3[01])$"))
            {
                contractEndDate = tbxEndDate.Text;
                if (string.IsNullOrEmpty(contractEndDate))
                {
                    MessageBox.Show("Please enter a contract end date");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid End date");
                return false;
            }

            return false;
        }
    }
}
