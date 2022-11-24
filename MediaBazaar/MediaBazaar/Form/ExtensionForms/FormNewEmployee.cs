using ClassLibraryProject;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace AdminBackups
{
    public partial class FormNewEmployee : Form
    {
        OfficeManager officeManager;
        Store store;

        public FormNewEmployee(OfficeManager officeManager, Store s)
        {
            InitializeComponent();

            this.officeManager = officeManager;
            store = s;
            AddDepartment();
        }

        protected override void OnClosed(EventArgs e)
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
        }

        //Create employee
        private void BtnNewEmployee_Click(object sender, EventArgs e)
        {
            CreateEmployee();
        }
        private bool CreateEmployee()
        {
            // get all input 
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

            bool employeeEmailUnique = true;
            // check if info is unique


            foreach (Employee e in officeManager.EmployeeManagerOffice.GetAllEmployees())
            {
                try
                {
                    if (e.BSN == Convert.ToInt32(tbxBSN.Text))
                    {
                        MessageBox.Show("This BSN is already in use.");
                        return false;
                    }
                    if (e.PersonalEmail == tbxPersonalEmail.Text)
                    {
                        MessageBox.Show("This PersonalEmail is already in use.");
                        return false;
                    }
                    if (e.Email == $"{char.ToLower(firstName[0])}{lastName.ToLower()}@mb.com")
                    {
                        employeeEmailUnique = false;
                    }
                }
                catch
                {

                }
            }

            string phoneNumber = tbxPhoneNumber.Text;
            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter a phone number");
                return false;
            }
            if (!Regex.IsMatch(tbxPhoneNumber.Text, @"^(\+)316[0-9]{8}$"))
            {
                MessageBox.Show("Please enter a valid phone number");
                return false;
            }

            string email = "";


            if (employeeEmailUnique)
            {
                email = $"{char.ToLower(firstName[0])}{lastName.ToLower()}@mb.com";
            }
            else
            {
                Random r = new Random();
                email = $"{ char.ToLower(firstName[0])}{lastName.ToLower()}{r.Next(1, 1000)}@mb.com";
            }


            string zipCode = tbxZipCode.Text;
            if (string.IsNullOrEmpty(zipCode))
            {
                MessageBox.Show("Please enter a zip code");
                return false;
            }
            if (!Regex.IsMatch(tbxZipCode.Text, @"^[0-9]{4}[A-Z]{2}$"))
            {
                MessageBox.Show("Please enter a valid zip code");
                return false;
            }


            string streetName = tbxAddress.Text;
            if (string.IsNullOrEmpty(streetName))
            {
                MessageBox.Show("Please enter a street name");
                return false;
            }

            string city = tbxCity.Text;
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please enter a city");
                return false;
            }

            if (string.IsNullOrEmpty(tbxDateOfBirth.Text))
            {
                MessageBox.Show("Please enter a date of birth");
                return false;
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
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid date of birth");
                return false;
            }

            if (string.IsNullOrEmpty(tbxBSN.Text))
            {
                MessageBox.Show("Please enter a BSN");
                return false;
            }
            if (!Regex.IsMatch(tbxBSN.Text, @"\b[0-9]{8,9}\b"))
            {
                MessageBox.Show("Please enter a valid BSN");
                return false;
            }

            int bsn = 0;
            try
            {
                bsn = Convert.ToInt32(tbxBSN.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid BSN");
                return false;
            }

            string username = $"{char.ToLower(firstName[0])}{lastName.ToLower()}";
            string password = $"{char.ToLower(firstName[0])}{lastName.ToLower()}";

            string personalEmail = tbxPersonalEmail.Text;
            if (string.IsNullOrEmpty(personalEmail))
            {
                MessageBox.Show("Please enter a personal email");
                return false;
            }
            if (!Regex.IsMatch(personalEmail, @"[a-z0-9]+(?:\.[a-z0-9]+)*@(?:[a-z](?:[a-z]*[a-z])?\.)nl|com"))
            {
                MessageBox.Show("Please enter a valid personal email");
                return false;
            }




            // make the employee object

            Employee newEmployee;

            if (cbxJobTitle.Text == "ADMIN")
            {
                newEmployee = new Admin(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract(email))
                    {
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (cbxJobTitle.Text == "CEO")
            {
                newEmployee = new CEO(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract(email))
                    {
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (cbxJobTitle.Text == "SALES REPRESENTATIVE")
            {
                newEmployee = new SalesRepresentative(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract(email))
                    {
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (cbxJobTitle.Text == "SALES MANAGER")
            {
                newEmployee = new SalesManager(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract(email))
                    {
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (cbxJobTitle.Text == "DEPOT EMPLOYEE")
            {
                newEmployee = new DepotEmployee(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract(email))
                    {
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (cbxJobTitle.Text == "DEPOT MANAGER")
            {
                newEmployee = new DepotManager(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract(email))
                    {
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (cbxJobTitle.Text == "OFFICE MANAGER")
            {
                newEmployee = new OfficeManager(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract(email))
                    {
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (cbxJobTitle.Text == "PRODUCT MANAGER")
            {
                newEmployee = new ProductManager(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract(email))
                    {
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        private bool CreateContract(string email)
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

            // get job title
            string jobTitle = cbxJobTitle.Text;

            // get employee 
            Employee newEmployee = officeManager.EmployeeManagerOffice.GetEmployeeID(email, jobTitle);

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
                MessageBox.Show("Please enter valid work hours per week");
                return false;
            }

            if (workHoursPerWeek < 8)
            {
                MessageBox.Show("Work hours has to be atleast 8");
                return false;
            }
            if (workHoursPerWeek > 40)
            {
                MessageBox.Show("Max work hours is 40");
                return false;
            }
            if (workHoursPerWeek % 4 != 0)
            {
                MessageBox.Show("Work hours has to be a multiple of 4");
                return false;
            }

            if (string.IsNullOrEmpty(tbxSalary.Text))
            {
                MessageBox.Show("Please enter salary per hour");
                return false;
            }
            double salaryPerHour = Convert.ToDouble(tbxSalary.Text);

            if (salaryPerHour > 200)
            {
                MessageBox.Show("Max salary is 200");
                return false;
            }
            if (string.IsNullOrEmpty(tbxStartDate.Text))
            {
                MessageBox.Show("Please enter a start date");
                return false;
            }

            DateTime dateOfBirth = new DateTime(1000, 1, 1);
            try
            {
                DateTime MakeDate = Convert.ToDateTime(tbxDateOfBirth.Value.ToString());

                dateOfBirth = Convert.ToDateTime(MakeDate.ToString("yyyy/MM/dd"));

                double minWage = CalculateMinWage(dateOfBirth);
                tbxSalary.PlaceholderText = minWage.ToString();
                if (salaryPerHour < minWage)
                {
                    MessageBox.Show("The salary for this employee should be at least " + minWage.ToString());
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid date of birth");
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
                MessageBox.Show("Please enter a valid start date");
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
                if (contractDays > 3650)
                {
                    MessageBox.Show("Contract length can be max 10 year");
                    return false;
                }

                var contractMonth = (endDate.Month - startDate.Month);
                if (contractDays < 3)
                {
                    MessageBox.Show("Contract length can be min 3 months");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid end date");
                return false;
            }

            string department = cbxDepartment.Text;
            if (string.IsNullOrEmpty(department))
            {
                MessageBox.Show("Please enter a department");
                return false;
            }

            Contract newContract = new Contract(newEmployee, jobTitle, workHoursPerWeek, salaryPerHour, startDate, endDate, department);

            return officeManager.ContractManager.CreateContract(newContract);
        }

        //Departments
        private void AddDepartment()
        {
            cbxDepartment.Items.Clear();

            try
            {
                foreach (DataRow r in officeManager.departmentManagment.ViewAllDepartments().Rows)
                {
                    if (Convert.ToInt16(r[0]) > 4)
                    {
                        if (cbxJobTitle.Text == "SALES REPRESENTATIVE" || cbxJobTitle.Text == "SALES MANAGER")
                        {
                            if (r[1].ToString() == "Sales")
                            {
                                Department d = new Department(
                                r[0].ToString(),
                                r[1].ToString(),
                                r[2].ToString()); cbxDepartment.Items.Add(d);
                            }
                        }
                        else if (cbxJobTitle.Text == "DEPOT EMPLOYEE" || cbxJobTitle.Text == "DEPOT MANAGER" || cbxJobTitle.Text == "PRODUCT MANAGER")
                        {
                            if (r[1].ToString() == "Depot")
                            {
                                Department d = new Department(
                                r[0].ToString(),
                                r[1].ToString(),
                                r[2].ToString()); cbxDepartment.Items.Add(d);
                            }
                        }
                        else if (cbxJobTitle.Text == "OFFICE MANAGER")
                        {
                            if (r[1].ToString() == "Office")
                            {
                                Department d = new Department(
                                r[0].ToString(),
                                r[1].ToString(),
                                r[2].ToString()); cbxDepartment.Items.Add(d);
                            }
                        }
                        else if (cbxJobTitle.Text == "CEO" || cbxJobTitle.Text == "ADMIN")
                        {
                            if (r[1].ToString() == "Other")
                            {
                                Department d = new Department(
                                r[0].ToString(),
                                r[1].ToString(),
                                r[2].ToString()); cbxDepartment.Items.Add(d);
                            }
                        }
                    }
                }

                if (cbxJobTitle.Text == "SALES REPRESENTATIVE" || cbxJobTitle.Text == "SALES MANAGER")
                {
                    if (cbxDepartment.Items.Count == 0)
                    {
                        cbxDepartment.Items.Add("Sales");
                    }
                }
                else if (cbxJobTitle.Text == "DEPOT EMPLOYEE" || cbxJobTitle.Text == "DEPOT MANAGER" || cbxJobTitle.Text == "PRODUCT MANAGER")
                {
                    if (cbxDepartment.Items.Count == 0)
                    {
                        cbxDepartment.Items.Add("Depot");
                    }
                }
                else if (cbxJobTitle.Text == "OFFICE MANAGER")
                {
                    if (cbxDepartment.Items.Count == 0)
                    {
                        cbxDepartment.Items.Add("Office");
                    }
                }
                else if (cbxJobTitle.Text == "CEO" || cbxJobTitle.Text == "ADMIN")
                {
                    if (cbxDepartment.Items.Count == 0)
                    {
                        cbxDepartment.Items.Add("Other");
                    }
                }
                cbxDepartment.Text = cbxDepartment.Items[0].ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }
        private void cbxJobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDepartment();
        }
        private double CalculateMinWage(DateTime dateOfBirth)
        {
            /* 21: 11.06
             * 20: 8.85
             * 19: 6.64
             * 18: 5.53
             * 17: 4.37
             * 16: 3.82
             */

            // check age of employee
            DateTime today = DateTime.Now;
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age))
            {
                age--;
            }

            // calculate min wage based on info above
            double minWage;

            if (age == 16)
            {
                minWage = 3.82;
                return minWage;
            }
            else if (age == 17)
            {
                minWage = 4.37;
                return minWage;
            }
            else if (age == 18)
            {
                minWage = 5.53;
                return minWage;
            }
            else if (age == 19)
            {
                minWage = 6.64;
                return minWage;
            }
            else if (age == 20)
            {
                minWage = 8.85;
                return minWage;
            }
            else if (age >= 21)
            {
                minWage = 11.06;
                return minWage;
            }

            return 0;
        }
    }
}
