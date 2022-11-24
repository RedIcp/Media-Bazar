using ClassLibraryProject;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AdminBackups
{
    public partial class FormOfficeManager : Form
    {
        OfficeManager officeManager;
        Store store;

        public FormOfficeManager(OfficeManager officeManager, Store store)
        {
            InitializeComponent();

            this.officeManager = officeManager;
            this.store = store;

            cbHeadDepartments.Text = "Sales";
            cbHeadDepartments.Items.Add("Sales");
            cbHeadDepartments.Items.Add("Depot");
            cbHeadDepartments.Items.Add("Office");
            cbHeadDepartments.Items.Add("Other");

            labYear.Text = DateTime.Now.Year.ToString();
            labMonth.Text = DateTime.Now.Month.ToString();

            ViewCompany();
            ReadEmployees();
            GetAtendeance();
            ViewAllDepartments();

            AddDepartment();

            int year = 0;
            int month = 0;

            try
            {
                year = Convert.ToInt32(labYear.Text);
                month = Convert.ToInt32(labMonth.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid year and month");
            }
            dgvAtendance.DataSource = officeManager.checkinManagment.getAtendanceData(year, month);

        }

        protected override void OnClosed(EventArgs e)
        {
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    var FormNewEmployee = Application.OpenForms.OfType<FormNewEmployee>().FirstOrDefault();
                    if (FormNewEmployee != null)
                    {
                        FormNewEmployee.Close();
                    }
                }
            }
            catch { }

            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    var FormRemoveEmployee = Application.OpenForms.OfType<FormRemoveEmployee>().FirstOrDefault();
                    if (FormRemoveEmployee != null)
                    {
                        FormRemoveEmployee.Close();
                    }
                }
            }
            catch { }

            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    var FormViewEmployee = Application.OpenForms.OfType<FormViewEmployee>().FirstOrDefault();
                    if (FormViewEmployee != null)
                    {
                        FormViewEmployee.Close();
                    }
                }
            }
            catch { }

            var logout = Application.OpenForms.OfType<FormLogin>().FirstOrDefault();
            logout.Show();
        }

        //Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Start Employee */
        private void CreateEmployee()
        {
            FormNewEmployee formNewEmployee = new FormNewEmployee(officeManager, store);
            formNewEmployee.Show();
        }
        public void ReadEmployees()
        {
            List<Employee> employees = new List<Employee>();

            if (cbxEmployeeType.SelectedIndex == 0)
            {
                employees = officeManager.EmployeeManagerOffice.ReadEmployees();
            }
            else if (tbxSearchEmployee.Text != "")
            {
                employees = officeManager.EmployeeManagerOffice.SearchEmployee(tbxSearchEmployee.Text);
            }
            else if (cbxEmployeeType.SelectedIndex != 0)
            {
                employees = officeManager.EmployeeManagerOffice.GetAllEmployees();
            }

            List<Employee> departmentEmployees = new List<Employee>();

            if (cbxEmployeeType.SelectedIndex == 1)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is CEO)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            }
            else if (cbxEmployeeType.SelectedIndex == 2)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is Admin)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            }
            else if (cbxEmployeeType.SelectedIndex == 3)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is DepotManager)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            }
            else if (cbxEmployeeType.SelectedIndex == 4)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is DepotEmployee)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            }
            else if (cbxEmployeeType.SelectedIndex == 5)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is SalesManager)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            }
            else if (cbxEmployeeType.SelectedIndex == 6)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is SalesRepresentative)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            }
            else if (cbxEmployeeType.SelectedIndex == 7)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is ProductManager)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            }
            else if (cbxEmployeeType.SelectedIndex == 8)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is OfficeManager)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            }
            if (cbxEmployeeType.SelectedIndex != 0)
            {
                dgvEmployees.DataSource = departmentEmployees;
            }
            else if (cbxEmployeeType.SelectedIndex == 0)
            {
                dgvEmployees.DataSource = employees;
            }

            dgvEmployees.Columns["StreetName"].Visible = false;
            dgvEmployees.Columns["Password"].Visible = false;
            dgvEmployees.Columns["EmployeeManagerAll"].Visible = false;
        }
        private void UpdateEmployee()
        {
            int employeeID = 0;
            if (string.IsNullOrEmpty(tbxActiveEmployeeID.Text))
            {
                MessageBox.Show("Please select an employee");
                return;
            }
            try
            {
                // get selected employee
                employeeID = Convert.ToInt32(tbxActiveEmployeeID.Text);
            }
            catch
            {
                MessageBox.Show("Please select an employee");
                return;
            }


            Employee activeEmployee = officeManager.EmployeeManagerOffice.GetEmployeeByID(employeeID);

            // get active contract of employee
            Contract activeContract = officeManager.ContractManager.ReadContract(activeEmployee);

            // open new update employee form
            FormViewEmployee formViewEmployee = new FormViewEmployee(officeManager, activeEmployee, activeContract);
            formViewEmployee.Show();

        }
        private void DeleteEmployee()
        {
            int employeeID = 0;
            if (string.IsNullOrEmpty(tbxActiveEmployeeID.Text))
            {
                MessageBox.Show("Please select an employee");
                return;
            }

            try
            {
                employeeID = Convert.ToInt32(tbxActiveEmployeeID.Text);
            }
            catch
            {
                MessageBox.Show("Please select an employee");
                return;
            }


            Employee selectedEmployee = officeManager.EmployeeManagerOffice.GetEmployeeByID(employeeID);

            if (selectedEmployee != null)
            {
                Contract activeContract = officeManager.ContractManager.ReadContract(selectedEmployee);

                FormRemoveEmployee formRemoveEmployee = new FormRemoveEmployee(officeManager, selectedEmployee, activeContract);
                formRemoveEmployee.Show();
            }
            else
            {

            }

        }
        private void cbxEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadEmployees();
            AddDepartment();
        }
        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            CreateEmployee();
        }
        private void bntUpdateEmployee_Click(object sender, EventArgs e)
        {
            UpdateEmployee();
        }
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
        }
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];

                string employeeID = row.Cells["EmployeeID"].Value.ToString();

                tbxActiveEmployeeID.Text = employeeID;
            }
        }

        /* Search Bar for employees */
        private void tbxSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            UserSearchBar();
        }
        public void UserSearchBar()
        {
            string search = tbxSearchEmployee.Text;

            if (!string.IsNullOrEmpty(search))
            {
                List<Employee> employees = officeManager.EmployeeManagerOffice.SearchEmployee(search);
                List<Employee> departmentEmployees = new List<Employee>();

                if (cbxEmployeeType.SelectedIndex == 1)
                {
                    departmentEmployees.Clear();
                    foreach (Employee employee in employees)
                    {
                        if (employee is CEO)
                        {
                            departmentEmployees.Add(employee);
                        }
                    }
                }
                else if (cbxEmployeeType.SelectedIndex == 2)
                {
                    departmentEmployees.Clear();
                    foreach (Employee employee in employees)
                    {
                        if (employee is Admin)
                        {
                            departmentEmployees.Add(employee);
                        }
                    }
                }
                else if (cbxEmployeeType.SelectedIndex == 3)
                {
                    departmentEmployees.Clear();
                    foreach (Employee employee in employees)
                    {
                        if (employee is DepotManager)
                        {
                            departmentEmployees.Add(employee);
                        }
                    }
                }
                else if (cbxEmployeeType.SelectedIndex == 4)
                {
                    departmentEmployees.Clear();
                    foreach (Employee employee in employees)
                    {
                        if (employee is DepotEmployee)
                        {
                            departmentEmployees.Add(employee);
                        }
                    }
                }
                else if (cbxEmployeeType.SelectedIndex == 5)
                {
                    departmentEmployees.Clear();
                    foreach (Employee employee in employees)
                    {
                        if (employee is SalesManager)
                        {
                            departmentEmployees.Add(employee);
                        }
                    }
                }
                else if (cbxEmployeeType.SelectedIndex == 6)
                {
                    departmentEmployees.Clear();
                    foreach (Employee employee in employees)
                    {
                        if (employee is SalesRepresentative)
                        {
                            departmentEmployees.Add(employee);
                        }
                    }
                }
                else if (cbxEmployeeType.SelectedIndex == 7)
                {
                    departmentEmployees.Clear();
                    foreach (Employee employee in employees)
                    {
                        if (employee is ProductManager)
                        {
                            departmentEmployees.Add(employee);
                        }
                    }
                }
                else if (cbxEmployeeType.SelectedIndex == 8)
                {
                    departmentEmployees.Clear();
                    foreach (Employee employee in employees)
                    {
                        if (employee is OfficeManager)
                        {
                            departmentEmployees.Add(employee);
                        }
                    }
                }
                dgvEmployees.DataSource = departmentEmployees;

                if (cbxEmployeeType.SelectedIndex == 0)
                {
                    dgvEmployees.DataSource = employees;
                }

                dgvEmployees.Columns["Password"].Visible = false;
                dgvEmployees.Columns["EmployeeManagerAll"].Visible = false;

            }
            else
            {
                ReadEmployees();
            }
        }

        /* Departments for search */
        private void AddDepartment()
        {
            cbxDepartment.Items.Clear();

            // add All departments for overview of all sales or depot employees

            try
            {
                foreach (DataRow r in officeManager.departmentManagment.ViewAllDepartments().Rows)
                {
                    if (Convert.ToInt16(r[0]) > 4)
                    {
                        if (cbxEmployeeType.Text == "Sales Representatives" || cbxEmployeeType.Text == "Sales Managers")
                        {
                            if (r[1].ToString() == "Sales")
                            {
                                Department d = new Department(
                                r[0].ToString(),
                                r[1].ToString(),
                                r[2].ToString()); cbxDepartment.Items.Add(d);
                            }
                        }
                        else if (cbxEmployeeType.Text == "Depot Employees" || cbxEmployeeType.Text == "Depot Managers" || cbxEmployeeType.Text == "Product Managers")
                        {
                            if (r[1].ToString() == "Depot")
                            {
                                Department d = new Department(
                                r[0].ToString(),
                                r[1].ToString(),
                                r[2].ToString()); cbxDepartment.Items.Add(d);
                            }
                        }
                        else if (cbxEmployeeType.Text == "Office Managers")
                        {
                            if (r[1].ToString() == "Office")
                            {
                                Department d = new Department(
                                r[0].ToString(),
                                r[1].ToString(),
                                r[2].ToString()); cbxDepartment.Items.Add(d);
                            }
                        }
                        else if (cbxEmployeeType.Text == "CEOs" || cbxEmployeeType.Text == "Admins")
                        {
                            if (r[1].ToString() == "Other")
                            {
                                Department d = new Department(
                                r[0].ToString(),
                                r[1].ToString(),
                                r[2].ToString()); cbxDepartment.Items.Add(d);
                            }
                        }
                        else
                        {
                            Department d = new Department(
                                r[0].ToString(),
                                r[1].ToString(),
                                r[2].ToString()); cbxDepartment.Items.Add(d);
                        }
                    }
                }
                if (cbxEmployeeType.Text == "Sales Representatives" || cbxEmployeeType.Text == "Sales Managers")
                {
                    if (cbxDepartment.Items.Count == 0)
                    {
                        cbxDepartment.Items.Add("Sales");
                    }
                }
                else if (cbxEmployeeType.Text == "Depot Employees" || cbxEmployeeType.Text == "Depot Managers" || cbxEmployeeType.Text == "Product Managers")
                {
                    if (cbxDepartment.Items.Count == 0)
                    {
                        cbxDepartment.Items.Add("Depot");
                    }
                }
                else if (cbxEmployeeType.Text == "Office Managers")
                {
                    if (cbxDepartment.Items.Count == 0)
                    {
                        cbxDepartment.Items.Add("Office");
                    }
                }
                else if (cbxEmployeeType.Text == "CEOs" || cbxEmployeeType.Text == "Admins")
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

        /* End Employees*/


        //Atendance
        private void btnDecreaseYear_Click(object sender, EventArgs e)
        {
            int year = 2022;
            try
            {
                year = Convert.ToInt16(labYear.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid year and month");
                return;
            }
            year--;
            labYear.Text = year.ToString();
            GetAtendeance();
        }
        private void btnIncreaseYear_Click(object sender, EventArgs e)
        {
            int year = 2022;
            try
            {
                year = Convert.ToInt16(labYear.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid year and month");
                return;
            }

            year++;
            labYear.Text = year.ToString();
            GetAtendeance();
        }
        private void btnMonthDecrease_Click(object sender, EventArgs e)
        {
            int month = 2001;
            try
            {
                month = Convert.ToInt16(labMonth.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid year and month");
                return;
            }
            if (month == 1)
            {
                month = 12;
                labMonth.Text = month.ToString();
            }
            else
            {
                month--;
                labMonth.Text = month.ToString();
            }
            GetAtendeance();
        }
        private void btnMonthIncrease_Click(object sender, EventArgs e)
        {
            int month = 2001;
            try
            {
                month = Convert.ToInt16(labMonth.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid year and month");
                return;
            }

            if (month == 12)
            {
                month = 1;
                labMonth.Text = month.ToString();
            }
            else
            {
                month++;
                labMonth.Text = month.ToString();
            }
            GetAtendeance();
        }
        private void btnMakeExcelSheet_Click_1(object sender, EventArgs e)
        {
            try
            {
                Excel.Application oXL;
                Excel._Workbook oWB;
                Excel._Worksheet oSheet;
                Excel.Range oRng;


                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = " EmployeeID ";
                oSheet.Cells[1, 2] = " Name ";
                oSheet.Cells[1, 3] = " Hours worked ";
                oSheet.Cells[1, 4] = " Work hours per week ";
                oSheet.Cells[1, 5] = " Salary per hour ";
                oSheet.Cells[1, 6] = " Job ";
                oSheet.Cells[1, 7] = " Salary this Month ";

                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "G1").Font.Bold = true;
                oSheet.get_Range("A1", "G1").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oSheet.get_Range("A1", "G1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oSheet.get_Range("A1", "G1").Font.Size = 16;
                //AutoFit columns A:D.
                oRng = oSheet.get_Range("A1", "G1");
                oRng.EntireColumn.AutoFit();

                List<TimeWorked> c = null;
                
                c = officeManager.checkinManagment.getAllAtendanceTime(Convert.ToInt32(labYear.Text), Convert.ToInt32(labMonth.Text));

                bool Errors = false;

                for (int i = 0; i < c.Count; i++)
                {
                    try
                    {
                        int index = i + 2;

                        oSheet.get_Range("A" + index, "G" + index).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                        oSheet.get_Range("A" + index, "G" + index).Font.Size = 12;

                        if (rbColor.Checked)
                        {
                            if (Convert.ToInt32(c[i].TimeWork) >= Convert.ToInt32(c[i].WorkHoursPerWeek) * 4)
                            {
                                oSheet.get_Range("H" + index, "H" + index).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
                            }
                            else
                            {
                                oSheet.get_Range("H" + index, "H" + index).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                            }
                        }

                        oSheet.Cells[index, 1] = c[i].EmployeeID;
                        oSheet.Cells[index, 2] = c[i].Name;
                        oSheet.Cells[index, 3] = c[i].TimeWork;
                        oSheet.Cells[index, 4] = c[i].WorkHoursPerWeek;
                        oSheet.Cells[index, 5] = c[i].SalaryPerHour;
                        oSheet.Cells[index, 6] = c[i].JobTitle;
                        try
                        {
                            oSheet.Cells[index, 7] = Convert.ToInt32(c[i].SalaryPerHour) * Convert.ToInt32(c[i].TimeWork);
                        }
                        catch
                        {
                        }

                        //AutoFit columns A:F.
                        oRng = oSheet.get_Range("A" + index, "F" + index);
                        oRng.EntireColumn.AutoFit();

                    }
                    catch
                    {
                        Errors = true;
                    }
                }

                if (Errors)
                {
                    MessageBox.Show("A error occurred!");
                }
            }
            catch
            {
                MessageBox.Show("A error has occurred loading the data.");
                return;
            }

        }
        public void GetAtendeance()
        {
            int year, month;
            try
            {
                year = Convert.ToInt32(labYear.Text);
                month = Convert.ToInt32(labMonth.Text);

            }
            catch
            {
                MessageBox.Show("Please enter a valid year and month");
                return;
            }
            dgvAtendance.DataSource = officeManager.checkinManagment.getAtendanceData(year, month);

            officeManager.checkinManagment.getAllAtendanceTime(year, month);
        }

        //Departments
        public void ViewAllDepartments()
        {
            if (officeManager is OfficeManager)
            {
                ((OfficeManager)officeManager).departmentManagment.ViewAllDepartments();
                dgvDepartments.DataSource = ((OfficeManager)officeManager).departmentManagment.ViewAllDepartments();
            }
            else
            {
                MessageBox.Show("type casting failed");
            }
        }
        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            string Name = tbDepartmentName.Text;
            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("'Department name' field is required.");
                return;
            }

            string Head = cbHeadDepartments.Text;
            if (string.IsNullOrEmpty(Head))
            {
                MessageBox.Show("'Head Department' field is required.");
                return;
            }

            string CompanyID = tbID.Text;
            if (string.IsNullOrEmpty(CompanyID))
            {
                MessageBox.Show("Error please restart the aplication");
                return;
            }

            if (officeManager is OfficeManager)
            {
                ((OfficeManager)officeManager).departmentManagment.AddDepartment(Name, Head, CompanyID);
            }
            else
            {
                MessageBox.Show("type casting failed");
            }

            ViewAllDepartments();
        }
        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            string Name = tbDepartmentName.Text;
            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("'Department name' field is required.");
                return;
            }

            string Head = cbHeadDepartments.Text;
            if (string.IsNullOrEmpty(Head))
            {
                MessageBox.Show("'Head Department' field is required.");
                return;
            }

            string DepartmentID = labDepartmentID.Text;
            if (string.IsNullOrEmpty(DepartmentID))
            {
                MessageBox.Show("Make sure to select a department you want to edit");
                return;
            }

            try
            {
                if (Convert.ToInt32(DepartmentID) == 1 || Convert.ToInt32(DepartmentID) == 2 || Convert.ToInt32(DepartmentID) == 3 || Convert.ToInt32(DepartmentID) == 4)
                {
                    MessageBox.Show("You can't edit the head Departments");
                    return;
                }
                if (officeManager is OfficeManager)
                {
                    udResult.Value = ((OfficeManager)officeManager).departmentManagment.EditDepartment(Name, Head, DepartmentID.ToString());
                }
                else
                {
                    MessageBox.Show("type casting failed");
                }

                ViewAllDepartments();
            }
            catch { MessageBox.Show("Please select a department."); }
        }
        private void dgvDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDepartments.Rows[e.RowIndex];
                labDepartmentID.Text = row.Cells["departmentID"].Value.ToString();
                tbDepartmentName.Text = row.Cells["DepartmentName"].Value.ToString();
                cbHeadDepartments.Text = row.Cells["HeadDepatment"].Value.ToString();

                udResult.Value = 0;
            }
        }
        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(labDepartmentID.Text) > 4)
                {
                    if (officeManager is OfficeManager)
                    {
                        try
                        {
                            ((OfficeManager)officeManager).departmentManagment.DeleteDepartment(Convert.ToInt32(labDepartmentID.Text));
                        }
                        catch
                        {
                            MessageBox.Show("Select a department to delete");
                        }
                    }
                    else
                    {
                        MessageBox.Show("type casting failed");
                    }
                }
                else
                {
                    MessageBox.Show("You can't delete the head departments");
                }
                ViewAllDepartments();
            }
            catch { }
        }

        //Company
        private void ViewCompany()
        {
            Company company = new Company();
            if (officeManager is OfficeManager)
            {
                company = ((OfficeManager)officeManager).companyManagment.GetCompany(officeManager.EmployeeID);
            }
            else
            { MessageBox.Show("type casting failed."); }

            tbCompanyName.Text = company.CompanyName;
            tbAdress.Text = company.Address;
            tbBTW.Text = company.Btw;
            tbEmail.Text = company.Email;
            tbPhoneNumber.Text = company.PhoneNumber;
            tbKVK.Text = company.KVK;
            tbID.Text = company.CompanyID;
        }
        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            string ID = tbID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("'ID' field is required.");
                return;
            }

            string Name = tbCompanyName.Text;
            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("'name' field is required.");
                return;
            }

            string Adress = tbAdress.Text;
            if (string.IsNullOrEmpty(Adress))
            {
                MessageBox.Show("'Adress' field is required.");
                return;
            }

            string BTW = tbBTW.Text;
            if (string.IsNullOrEmpty(BTW))
            {
                MessageBox.Show("'BTW number' field is required.");
                return;
            }
            try
            {
                Convert.ToInt32(BTW);
            }
            catch
            {
                MessageBox.Show("'BTW number' field must be only numbers.");
                return;
            }

            string Email = tbEmail.Text;
            if (string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("'Email' field is required.");
                return;
            }

            string PhoneNumber = tbPhoneNumber.Text;
            if (string.IsNullOrEmpty(PhoneNumber))
            {
                MessageBox.Show("'PhoneNumber' field is required.");
                return;
            }
            try
            {
                Convert.ToInt32(PhoneNumber);
            }
            catch
            {
                MessageBox.Show("'PhoneNumber' field must be only numbers.");
                return;
            }

            string KVK = tbKVK.Text;
            if (string.IsNullOrEmpty(KVK))
            {
                MessageBox.Show("'KVK number' field is required.");
                return;
            }
            try
            {
                Convert.ToInt32(KVK);
            }
            catch
            {
                MessageBox.Show("'KVK number' field is required.");
                return;
            }
            if (officeManager is OfficeManager)
            {
                ((OfficeManager)officeManager).companyManagment.EditCompany(Name, Adress, PhoneNumber, Email, BTW, KVK, ID);
            }
            else
            { MessageBox.Show("type casting failed."); }
        }

        private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
