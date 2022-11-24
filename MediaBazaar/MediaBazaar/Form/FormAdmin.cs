using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class FormAdmin : Form
    {
        Admin admin;
        Store store;

        public FormAdmin(Admin a, Store s)
        {
            InitializeComponent();
            this.admin = a;
            this.store = s;

            if (admin.EmployeeManagerAdmin.AmountOfOfficeManagers() > 0)
            {
                gbMakeEmployee.Visible = false;
                labEmployeeAlreadyAdded.Visible = true;
            }
            else
            {
                gbMakeEmployee.Visible = true;
                labEmployeeAlreadyAdded.Visible = false;
            }

            AddDepartments();
        }

        //Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected override void OnClosed(EventArgs e)
        {
            var logout = Application.OpenForms.OfType<FormLogin>().FirstOrDefault();
            logout.Show();
        }

        //Create Employee
        private void BtnNewEmployee_Click(object sender, EventArgs e)
        {
            CreateEmployee();
            AddDepartments();
        }
        private void CreateEmployee()
        {
            // get all input 
            string firstName = tbxFirstName.Text;
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please enter a first name");
                return;
            }

            string lastName = tbxLastName.Text;
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter a last name");
                return;
            }


            string phoneNumber = tbxPhoneNumber.Text;
            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter a phone number");
                return;
            }
            if (!Regex.IsMatch(tbxPhoneNumber.Text, @"^(\+)316[0-9]{8}$"))
            {
                MessageBox.Show("Please enter a valid phone number");
                return;
            }

            string email = $"{char.ToLower(firstName[0])}{lastName.ToLower()}@mb.com";


            string zipCode = tbxZipCode.Text;
            if (string.IsNullOrEmpty(zipCode))
            {
                MessageBox.Show("Please enter a zip code");
                return;
            }
            if (!Regex.IsMatch(tbxZipCode.Text, @"^[0-9]{4}[A-Z]{2}$"))
            {
                MessageBox.Show("Please enter a valid zip code");
                return;
            }


            string streetName = tbxAddress.Text;
            if (string.IsNullOrEmpty(streetName))
            {
                MessageBox.Show("Please enter a street name");
                return;
            }

            string city = tbxCity.Text;
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please enter a city");
                return;
            }

            if (string.IsNullOrEmpty(tbxDateOfBirth.Text))
            {
                MessageBox.Show("Please enter a date of birth");
                return;
            }

            DateTime dateOfBirth = new DateTime(1000, 1, 1);
            try
            {
                DateTime MakeDate = Convert.ToDateTime(tbxDateOfBirth.Value.ToString());

                dateOfBirth = Convert.ToDateTime(MakeDate.ToString("yyyy/MM/dd"));

                DateTime firstBirthDay = DateTime.Now.AddYears(-16);
                if (dateOfBirth > firstBirthDay)
                {
                    MessageBox.Show("New employee should be at least 16 years old");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid date of birth");
                return;
            }

            if (string.IsNullOrEmpty(tbxBSN.Text))
            {
                MessageBox.Show("Please enter a BSN");
                return;
            }
            if (!Regex.IsMatch(tbxBSN.Text, @"\b[0-9]{8,9}\b"))
            {
                MessageBox.Show("Please enter a valid BSN");
                return;
            }

            int bsn = 0;
            try
            {
                bsn = Convert.ToInt32(tbxBSN.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid bsne");
                return;
            }

            string username = $"{char.ToLower(firstName[0])}{lastName.ToLower()}";
            string password = $"{char.ToLower(firstName[0])}{lastName.ToLower()}";

            string personalEmail = tbxPersonalEmail.Text;
            if (string.IsNullOrEmpty(personalEmail))
            {
                MessageBox.Show("Please enter a personal email");
                return;
            }
            if (!Regex.IsMatch(personalEmail, @"[a-z0-9]+(?:\.[a-z0-9]+)*@(?:[a-z](?:[a-z]*[a-z])?\.)nl|com"))
            {
                MessageBox.Show("Please enter a valid personal email");
                return;
            }

            // make the employee object

            Employee newEmployee;

            newEmployee = new OfficeManager(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
            if (admin.EmployeeManagerAdmin.CreateEmployee(newEmployee))
            {
                if (CreateContract())
                {
                    gbMakeEmployee.Visible = false;
                    labEmployeeAlreadyAdded.Visible = true;
                }
                else
                {
                    return;
                }
            }

        }
        private bool CreateContract()
        {
            // get employee id for contract

            // get email
            string firstName = tbxFirstName.Text;
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please enter a first name");
                return false;
            }

            string lastName = tbxLastName.Text;
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter a last name");
                return false;
            }

            string email = $"{char.ToLower(firstName[0])}{lastName.ToLower()}@mb.com";

            // get job title
            string jobTitle = cbxJobTitle.Text;

            Employee newEmployee = admin.EmployeeManagerAdmin.GetEmployeeID(email, jobTitle);

            // get input for contract
            if (string.IsNullOrEmpty(tbxWorkHours.Text))
            {
                MessageBox.Show("Please enter work hours per week");
                return false;
            }

            int workHoursPerWeek = 0;
            try
            {
                workHoursPerWeek = Convert.ToInt32(tbxWorkHours.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid work hours");
                return false;
            }
            if (workHoursPerWeek % 4 != 0)
            {
                MessageBox.Show("Work hours has to be a multiple of 4");
                return false;
            }
            if (workHoursPerWeek > 40)
            {
                MessageBox.Show("Ma xwork hours is 40");
                return false;
            }
            if (workHoursPerWeek == 0)
            {
                MessageBox.Show("Work hours must be at least 4 hours per week");
                return false;
            }

            if (string.IsNullOrEmpty(tbxSalary.Text))
            {
                MessageBox.Show("Please enter salary per hour");
                return false;
            }

            double salaryPerHour = 0;
            try
            {
                salaryPerHour = Convert.ToDouble(tbxSalary.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid work hours");
                return false;
            }

            DateTime startDate = new DateTime(1000, 1, 1);
            try
            {
                DateTime MakeDate = Convert.ToDateTime(tbxStartDate.Value.ToString());

                startDate = Convert.ToDateTime(MakeDate.ToString("yyyy/MM/dd"));

                if (startDate < DateTime.Now)
                {
                    MessageBox.Show("Start date must be in the future");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid start birth");
                return false;
            }

            DateTime endDate = new DateTime(1000, 1, 1);
            try
            {
                DateTime MakeDate = Convert.ToDateTime(tbxEndDate.Value.ToString());

                endDate = Convert.ToDateTime(MakeDate.ToString("yyyy/MM/dd"));

                if (endDate < DateTime.Now)
                {
                    MessageBox.Show("End date must be in the future");
                    return false;
                }

                if (startDate > endDate)
                {
                    MessageBox.Show("End date must be after start date");
                    return false;
                }

                var contractDays = (endDate - startDate).TotalDays;
                if (contractDays > 365)
                {
                    MessageBox.Show("Contract length can be max 1 year");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid start birth");
                return false;
            }

            string department = cbxDepartment.Text;
            if (string.IsNullOrEmpty(department))
            {
                MessageBox.Show("Please enter a department");
                return false;
            }

            Contract newContract = new Contract(newEmployee, jobTitle, workHoursPerWeek, salaryPerHour, startDate, endDate, department);

            return admin.ContractManager.CreateContract(newContract);
        }

        //Department
        private void AddDepartments()
        {
            cbxDepartment.Items.Clear();

            foreach (DataRow r in admin.departmentManagment.ViewAllDepartments().Rows)
            {
                {
                    if (cbxJobTitle.Text == "OFFICE MANAGER")
                    {
                        if (r[1].ToString() == "Office")
                        {
                            Department d = new Department(
                            r[0].ToString(),
                            r[1].ToString(),
                            r[2].ToString());

                            cbxDepartment.Items.Add(d);
                        }
                    }
                }
            }

            if (cbxDepartment.Items.Count == 0)
            {
                cbxDepartment.Items.Add("Office");
            }

            cbxDepartment.Text = cbxDepartment.Items[0].ToString();
        }
    }
}
