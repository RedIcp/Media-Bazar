using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.Enum;
using ClassLibraryProject.ManagmentClasses.IDepotManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class FormDepotManager : Form
    {
        DepotManager depotManager;
        Store store;
        IDepotManagerControl c;
        FormLogin login;
        FormOrderRestock orderRestock;

        int i;
        int pi;
        DateTime date;
        public FormDepotManager(DepotManager depotManager, Store store, FormLogin login)
        {
            InitializeComponent();

            this.login = login;
            this.depotManager = depotManager;
            this.store = store;

            c = depotManager.Control;

            date = DateTime.Now;

            Initialize();
            UpdatePendingRequests();
            UpdateSchedule();
            UpdatePlanningSchedule();
            EmployeesWorkingToday();
        }

        //INITIALIZE----------------------------------------------------------------------
        public void Initialize()
        {
            lblWeek.Text = GetCurrentWeekOfYear(date).ToString();
            lblPlanningWeek.Text = GetCurrentWeekOfYear(date).ToString();

            try
            {
                i = Convert.ToInt32(lblWeek.Text);
                pi = Convert.ToInt32(lblPlanningWeek.Text);
            }
            catch
            {
                MessageBox.Show("Error");
                return;
            }

            txtYear.Value = date.Year;
            txtPlanningYear.Value = date.Year;

            if (depotManager is DepotManager)
            {
                foreach (Department d in ((DepotManager)depotManager).viewDepartments.ViewAllDepartments())
                {
                    cbSchebuleByDepartment.Items.Add(d);
                    cbDepartments.Items.Add(d);
                    cbOverviewDepartment.Items.Add(d);
                }
            }
            cbSchebuleByDepartment.Text = cbSchebuleByDepartment.Items[0].ToString();
            cbDepartments.Text = cbDepartments.Items[0].ToString();
            cbOverviewDepartment.Text = cbOverviewDepartment.Items[0].ToString();
        }
        public int GetCurrentWeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        private void EmployeesWorkingToday()
        {
            int year = date.Year;
            int week = GetCurrentWeekOfYear(date);
            string day = date.DayOfWeek.ToString();
            string department = cbOverviewDepartment.Text;

            lstEmployeesWorkingToday.Items.Clear();
            lstEmployeesWorkingToday.Items.Add("Morning:");
            lstEmployeesWorkingToday.Items.Add("----------------");
            if (c.GetRegisteredShift(department, year, week, day, "Morning") != null)
            {
                foreach (Employee employee in c.GetRegisteredShift(department, year, week, day, "Morning").Employees)
                {
                    if (DepartmentTrue(employee, department) == true)
                    {
                        lstEmployeesWorkingToday.Items.Add(employee);
                    }
                }
            }
            lstEmployeesWorkingToday.Items.Add("Afternoon:");
            lstEmployeesWorkingToday.Items.Add("----------------");
            if (c.GetRegisteredShift(department, year, week, day, "Afternoon") != null)
            {
                foreach (Employee employee in c.GetRegisteredShift(department, year, week, day, "Afternoon").Employees)
                {
                    if (DepartmentTrue(employee, department) == true)
                    {
                        lstEmployeesWorkingToday.Items.Add(employee);
                    }
                }
            }
            lstEmployeesWorkingToday.Items.Add("Evening:");
            lstEmployeesWorkingToday.Items.Add("----------------");
            if (c.GetRegisteredShift(department, year, week, day, "Evening") != null)
            {
                foreach (Employee employee in c.GetRegisteredShift(department, year, week, day, "Evening").Employees)
                {
                    if (DepartmentTrue(employee, department) == true)
                    {
                        lstEmployeesWorkingToday.Items.Add(employee);
                    }
                }
            }
        }
        private void cbOverviewDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeesWorkingToday();
        }


        //OVERVIEW-----------------------------------------------------------------------
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected override void OnClosed(EventArgs e)
        {
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    var FormOrderRestock = Application.OpenForms.OfType<FormOrderRestock>().FirstOrDefault();
                    if (FormOrderRestock != null)
                    {
                        FormOrderRestock.Close();
                    }
                }
            }
            catch { }

            login.Show();
        }
        private void FormDepotManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (orderRestock == null)
            {
                login.Show();
            }
            else
            {
                orderRestock.Close();
                login.Show();
            }
        }
        private void dgOverviewSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(2);
        }
        private void dgOverviewRestock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(1);
        }
        private void lstEmployeesWorkingToday_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControl1.SelectTab(3);
        }


        //RESTOCK-------------------------------------------------------------------------
        public void UpdatePendingRequests()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Barcode", typeof(string));
            table.Columns.Add("Amount", typeof(int));
            table.Columns.Add("Status", typeof(string));

            foreach (Restock restock in c.GetRestockRequests())
            {
                if (restock.Status == "Pending")
                {
                    table.Rows.Add(restock.ID, restock.Product.Barcode, restock.AmountRequested, restock.Status);
                }
            }

            dgRestock.DataSource = table;
            dgOverviewRestock.DataSource = table;
        }
        private void UpdateHistory()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Barcode", typeof(string));
            table.Columns.Add("Amount", typeof(int));
            table.Columns.Add("Status", typeof(string));

            foreach (Restock restock in c.GetRestockRequests())
            {
                if (restock.Status == "Fulfilled")
                {
                    table.Rows.Add(restock.ID, restock.Product.Barcode, restock.AmountRequested, restock.Status);
                }
            }

            dgRestock.DataSource = table;
        }
        private void rbPending_Click(object sender, EventArgs e)
        {
            UpdatePendingRequests();

            txtBarcode.Text = "";
            txtCurrentAmount.Text = "";
            txtRestockID.Text = "";

            btnOrderRestock.Show();
            btnDeleteRestockRequest.Show();
        }
        private void rbHistory_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHistory();

            txtBarcode.Text = "";
            txtCurrentAmount.Text = "";
            txtRestockID.Text = "";

            btnOrderRestock.Hide();
            btnDeleteRestockRequest.Hide();
        }
        private void dgRestock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgRestock.Rows[e.RowIndex];
                    txtRestockID.Text = row.Cells["ID"].Value.ToString();
                    txtBarcode.Text = row.Cells["Barcode"].Value.ToString();
                    txtCurrentAmount.Text = c.GetRestockByID(Convert.ToInt32(row.Cells["ID"].Value)).Product.AmountInDepot.ToString();
                }
                catch { }
            }
        }
        private void btnOrderRestock_Click(object sender, EventArgs e)
        {
            try
            {
                int restockID = Convert.ToInt32(txtRestockID.Text);

                if (c.GetRestockByID(restockID) != null)
                {
                    Restock restock = c.GetRestockByID(restockID);
                    orderRestock = new FormOrderRestock(restock, c, this);
                    orderRestock.Show();
                }
            }
            catch
            {
                MessageBox.Show("Select any restock request you want to finalize.");
            }
        }
        private void btnDeleteRestockRequest_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtRestockID.Text);
                if (c.DeleteRestock(id))
                {
                    UpdatePendingRequests();

                    txtBarcode.Text = "";
                    txtCurrentAmount.Text = "";
                    txtRestockID.Text = "";
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Select any restock request you want to reject.");
            }
        }


        //SCHEDULE------------------------------------------------------------------       
        private void UpdateSchedule()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Day", typeof(string));
            table.Columns.Add("Morning", typeof(int));
            table.Columns.Add("Afternoon", typeof(int));
            table.Columns.Add("Evening", typeof(int));

            try
            {
                string department = cbSchebuleByDepartment.Text;
                int year = Convert.ToInt32(txtYear.Value);
                int week = Convert.ToInt32(lblWeek.Text);

                if (!c.WeekExist(department, year, week))
                {
                    c.CreateWeek(department, year, week);
                }
                foreach (Schedule schedule in c.GetSchedules(department, year, week))
                {
                    table.Rows.Add(schedule.Day, schedule.MorningAmount, schedule.AfternoonAmount, schedule.EveningAmount);
                }

                dgSchedule.DataSource = table;
                dgOverviewSchedule.DataSource = table;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }

        }
        private void btnIncreaseWeek_Click(object sender, EventArgs e)
        {
            try
            {
                if (i < ISOWeek.GetWeeksInYear(Convert.ToInt32(txtYear.Value)))
                {
                    i++;
                }
                else if (i >= ISOWeek.GetWeeksInYear(Convert.ToInt32(txtYear.Value)))
                {
                    i = ISOWeek.GetWeeksInYear(Convert.ToInt32(txtYear.Value));
                }
                lblWeek.Text = i.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please insert year!");
            }
            UpdateSchedule();

        }
        private void btnDecreaseWeek_Click(object sender, EventArgs e)
        {
            if (i > 1)
            {
                i--;
            }
            else if (i <= 0)
            {
                i = 1;
            }
            lblWeek.Text = i.ToString();
            UpdateSchedule();

        }
        private void cbSchebuleByDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSchedule();
        }
        private void txtYear_ValueChanged(object sender, EventArgs e)
        {
            UpdateSchedule();
        }
        private void dgSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgSchedule.Rows[e.RowIndex];
                lbScheduleDay.Text = row.Cells["Day"].Value.ToString();
                lbScheduleEvening.Text = row.Cells["Evening"].Value.ToString();
                lbScheduleMorning.Text = row.Cells["Morning"].Value.ToString();
                lbScheduleAfternoon.Text = row.Cells["Afternoon"].Value.ToString();
            }

        }
        private void btnEditschedule_Click(object sender, EventArgs e)
        {
            try
            {
                string department = cbSchebuleByDepartment.Text;
                int year = Convert.ToInt32(txtYear.Value);
                int week = Convert.ToInt32(lblWeek.Text);
                string day = lbScheduleDay.Text;
                int morningAmount = Convert.ToInt32(lbScheduleMorning.Text);
                int afternoonAmount = Convert.ToInt32(lbScheduleAfternoon.Text);
                int eveningAmount = Convert.ToInt32(lbScheduleEvening.Text);

                if (c.UpdateSchedule(department, year, week, day, morningAmount, afternoonAmount, eveningAmount))
                {
                    lbScheduleDay.Text = "";
                    lbScheduleMorning.Text = "";
                    lbScheduleAfternoon.Text = "";
                    lbScheduleEvening.Text = "";

                    UpdateSchedule();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }

            UpdateSchedule();
            UpdatePlanningSchedule();
        }


        //PLANNING--------------------------------------------------------------------------
        private void UpdateEmployeeList()
        {
            int selectedrowindex = dgPlanningSchedule.SelectedCells[0].RowIndex;
            int selectedcolumnindex = dgPlanningSchedule.SelectedCells[0].ColumnIndex;
            DataGridViewRow selectedRow = dgPlanningSchedule.Rows[selectedrowindex];
            DataGridViewColumn selectedColumn = dgPlanningSchedule.Columns[selectedcolumnindex];
            int year = Convert.ToInt32(txtPlanningYear.Value);
            int week = Convert.ToInt32(lblPlanningWeek.Text);
            string day = Convert.ToString(selectedRow.Cells["Day"].Value);
            string shift = Convert.ToString(selectedColumn.Name);
            string department = cbDepartments.Text;

            lstEmpCanWork.Items.Clear();

            if (c.GetPreferredShift(day, shift) != null)
            {
                foreach (Employee employee in c.GetPreferredShift(day, shift).Employees)
                {
                    if (c.GetPreferredShift(day, shift).IsPreferred == true && DepartmentTrue(employee, department) == true && c.RegisteredEmployeeExist(department, year, week, day, shift, employee.EmployeeID) == false)
                    {
                        lstEmpCanWork.Items.Add(employee);
                    }
                }
            }

            lstEmpEnlisted.Items.Clear();

            if (c.GetRegisteredShift(department, year, week, day, shift) != null)
            {
                foreach (Employee employee in c.GetRegisteredShift(department, year, week, day, shift).Employees)
                {
                    lstEmpEnlisted.Items.Add(employee);
                }
            }

        }
        private void UpdateNotPreferredEmployeeList()
        {
            int selectedrowindex = dgPlanningSchedule.SelectedCells[0].RowIndex;
            int selectedcolumnindex = dgPlanningSchedule.SelectedCells[0].ColumnIndex;
            DataGridViewRow selectedRow = dgPlanningSchedule.Rows[selectedrowindex];
            DataGridViewColumn selectedColumn = dgPlanningSchedule.Columns[selectedcolumnindex];
            int year = Convert.ToInt32(txtPlanningYear.Value);
            int week = Convert.ToInt32(lblPlanningWeek.Text);
            string day = Convert.ToString(selectedRow.Cells["Day"].Value);
            string shift = Convert.ToString(selectedColumn.Name);
            string department = cbDepartments.Text;

            lstEmpCanWork.Items.Clear();

            if (c.GetPreferredShift(day, shift) != null)
            {
                foreach (Employee employee in c.GetPreferredShift(day, shift).Employees)
                {
                    if (c.GetPreferredShift(day, shift).IsPreferred == false && DepartmentTrue(employee, department) == true && c.RegisteredEmployeeExist(department, year, week, day, shift, employee.EmployeeID) == false)
                    {
                        lstEmpCanWork.Items.Add(employee);
                    }
                }
            }

            lstEmpEnlisted.Items.Clear();

            if (c.GetRegisteredShift(department, year, week, day, shift) != null)
            {
                foreach (Employee employee in c.GetRegisteredShift(department, year, week, day, shift).Employees)
                {
                    lstEmpEnlisted.Items.Add(employee);
                }
            }

        }
        private void UpdateNoPreferenceEmployeeList()
        {
            int selectedrowindex = dgPlanningSchedule.SelectedCells[0].RowIndex;
            int selectedcolumnindex = dgPlanningSchedule.SelectedCells[0].ColumnIndex;
            DataGridViewRow selectedRow = dgPlanningSchedule.Rows[selectedrowindex];
            DataGridViewColumn selectedColumn = dgPlanningSchedule.Columns[selectedcolumnindex];
            int year = Convert.ToInt32(txtPlanningYear.Value);
            int week = Convert.ToInt32(lblPlanningWeek.Text);
            string day = Convert.ToString(selectedRow.Cells["Day"].Value);
            string shift = Convert.ToString(selectedColumn.Name);
            string department = cbDepartments.Text;

            lstEmpCanWork.Items.Clear();

            if (c.GetPreferredShift(day, shift) != null)
            {
                foreach (Employee employee in c.EmployeesWithNoPreference(day, shift))
                {
                    if (DepartmentTrue(employee, department) == true && c.RegisteredEmployeeExist(department, year, week, day, shift, employee.EmployeeID) == false)
                    {
                        lstEmpCanWork.Items.Add(employee);
                    }
                }
            }

            lstEmpEnlisted.Items.Clear();

            if (c.GetRegisteredShift(department, year, week, day, shift) != null)
            {
                foreach (Employee employee in c.GetRegisteredShift(department, year, week, day, shift).Employees)
                {
                    lstEmpEnlisted.Items.Add(employee);
                }
            }

        }
        public bool DepartmentTrue(Employee employee, string department)
        {
            foreach (Contract contract in employee.Contracts)
            {
                if (contract.Department == department)
                {
                    return true;
                }
            }

            return false;
        }

        private void UpdatePlanningSchedule()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Day", typeof(string));
            table.Columns.Add("Morning", typeof(int));
            table.Columns.Add("Afternoon", typeof(int));
            table.Columns.Add("Evening", typeof(int));

            try
            {

                string department = cbDepartments.Text;
                int year = Convert.ToInt32(txtPlanningYear.Value);
                int week = Convert.ToInt32(lblPlanningWeek.Text);

                if (!c.WeekExist(department, year, week))
                {
                    c.CreateWeek(department, year, week);
                }
                foreach (Schedule schedule in c.GetSchedules(department, year, week))
                {
                    table.Rows.Add(schedule.Day, schedule.MorningAmount, schedule.AfternoonAmount, schedule.EveningAmount);
                }

                dgPlanningSchedule.DataSource = table;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }

        }
        private void btnIncreasePlanningWeek_Click(object sender, EventArgs e)
        {
            try
            {
                if (pi < ISOWeek.GetWeeksInYear(Convert.ToInt32(txtPlanningYear.Value)))
                {
                    pi++;
                }
                else if (pi >= ISOWeek.GetWeeksInYear(Convert.ToInt32(txtPlanningYear.Value)))
                {
                    pi = ISOWeek.GetWeeksInYear(Convert.ToInt32(txtPlanningYear.Value));
                }
                lblPlanningWeek.Text = pi.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please insert year!");
            }
            UpdatePlanningSchedule();

        }
        private void btnDecreasePlanningWeek_Click(object sender, EventArgs e)
        {
            if (pi > 1)
            {
                pi--;
            }
            else if (pi <= 0)
            {
                pi = 1;
            }
            lblPlanningWeek.Text = pi.ToString();
            UpdatePlanningSchedule();

        }
        private void cbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePlanningSchedule();

        }
        private void txtPlanningYear_ValueChanged(object sender, EventArgs e)
        {
            UpdatePlanningSchedule();

        }
        private void rbNotPreferred_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNotPreferredEmployeeList();

        }
        private void rbPreferred_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEmployeeList();

        }
        private void rdNoPreference_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNoPreferenceEmployeeList();

        }
        private void dgPlanningSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = dgPlanningSchedule.SelectedCells[0].RowIndex;
                int selectedcolumnindex = dgPlanningSchedule.SelectedCells[0].ColumnIndex;
                DataGridViewRow selectedRow = dgPlanningSchedule.Rows[selectedrowindex];
                DataGridViewColumn selectedColumn = dgPlanningSchedule.Columns[selectedcolumnindex];
                int year = Convert.ToInt32(txtPlanningYear.Value);
                int week = Convert.ToInt32(lblPlanningWeek.Text);
                string day = Convert.ToString(selectedRow.Cells["Day"].Value);
                string shift = Convert.ToString(selectedColumn.Name);

                if (rbNotPreferred.Checked)
                {
                    UpdateNotPreferredEmployeeList();
                }
                else
                {
                    if (rbPreferred.Checked)
                    {
                        UpdateEmployeeList();
                    }
                    else
                    {
                        if (rdNoPreference.Checked)
                        {
                            UpdateNoPreferenceEmployeeList();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong!");
            }

        }
        private void lstEmpCanWork_DoubleClick(object sender, EventArgs e)
        {
            Object EmployeeObject = lstEmpCanWork.SelectedItem;
            if (!(EmployeeObject is Employee))
            {
                return;
            }
            try
            {
                string department = cbDepartments.Text;
                Employee employee = (Employee)EmployeeObject;
                int selectedrowindex = dgPlanningSchedule.SelectedCells[0].RowIndex;
                int selectedcolumnindex = dgPlanningSchedule.SelectedCells[0].ColumnIndex;
                DataGridViewRow selectedRow = dgPlanningSchedule.Rows[selectedrowindex];
                DataGridViewColumn selectedColumn = dgPlanningSchedule.Columns[selectedcolumnindex];
                int year = Convert.ToInt32(txtPlanningYear.Value);
                int week = Convert.ToInt32(lblPlanningWeek.Text);
                string day = Convert.ToString(selectedRow.Cells["Day"].Value);
                string shift = Convert.ToString(selectedColumn.Name);

                if (shift == "Morning")
                {
                    if (c.GetSchedule(department, year, week, day).MorningAmount == 0)
                    {
                        MessageBox.Show("Limit reached! Update schedule if you want to add more employee.");
                        return;
                    }
                }
                if (shift == "Afternoon")
                {
                    if (c.GetSchedule(department, year, week, day).AfternoonAmount == 0)
                    {
                        MessageBox.Show("Limit reached! Update schedule if you want to add more employee.");
                        return;
                    }
                }
                if (shift == "Evening")
                {
                    if (c.GetSchedule(department, year, week, day).EveningAmount == 0)
                    {
                        MessageBox.Show("Limit reached! Update schedule if you want to add more employee.");
                        return;
                    }
                }

                if (c.GetRegisteredShift(department, year, week, day, shift) == null)
                {
                    if (c.RegisterEmployee(department, year, week, day, shift, employee))
                    {
                        if (rbNotPreferred.Checked)
                        {
                            UpdateNotPreferredEmployeeList();
                        }
                        else
                        {
                            if (rbPreferred.Checked)
                            {
                                UpdateEmployeeList();
                            }
                            else
                            {
                                if (rdNoPreference.Checked)
                                {
                                    UpdateNoPreferenceEmployeeList();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!");
                    }
                }
                else
                {
                    if (c.CheckAmount(department, year, week, day, shift) == false)
                    {
                        MessageBox.Show("Limit reached! Update schedule if you want to add more employee.");
                    }
                    else
                    {
                        if (c.RegisterEmployee(department, year, week, day, shift, employee))
                        {
                            if (rbNotPreferred.Checked)
                            {
                                UpdateNotPreferredEmployeeList();
                            }
                            else
                            {
                                if (rbPreferred.Checked)
                                {
                                    UpdateEmployeeList();
                                }
                                else
                                {
                                    if (rdNoPreference.Checked)
                                    {
                                        UpdateNoPreferenceEmployeeList();
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong!");
                        }
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }

        }
        private void btnRemoveFromSchedule_Click(object sender, EventArgs e)
        {
            Object EmployeeObject = lstEmpEnlisted.SelectedItem;
            if (!(EmployeeObject is Employee))
            {
                return;
            }
            try
            {
                string department = cbDepartments.Text;
                Employee employee = (Employee)EmployeeObject;
                int selectedrowindex = dgPlanningSchedule.SelectedCells[0].RowIndex;
                int selectedcolumnindex = dgPlanningSchedule.SelectedCells[0].ColumnIndex;
                DataGridViewRow selectedRow = dgPlanningSchedule.Rows[selectedrowindex];
                DataGridViewColumn selectedColumn = dgPlanningSchedule.Columns[selectedcolumnindex];
                int year = Convert.ToInt32(txtPlanningYear.Value);
                int week = Convert.ToInt32(lblPlanningWeek.Text);
                string day = Convert.ToString(selectedRow.Cells["Day"].Value);
                string shift = Convert.ToString(selectedColumn.Name);

                if (c.DeRegisterEmployee(department, year, week, day, shift, employee))
                {
                    if (rbNotPreferred.Checked)
                    {
                        UpdateNotPreferredEmployeeList();
                    }
                    else
                    {
                        if (rbPreferred.Checked)
                        {
                            UpdateEmployeeList();
                        }
                        else
                        {
                            if (rdNoPreference.Checked)
                            {
                                UpdateNoPreferenceEmployeeList();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }

        }


        //AUTOMATED SCHEDULE--------------------------------------------------------------------
        private void btnAutoSchedule_Click(object sender, EventArgs e)
        {
            UpdatePlanningSchedule();

            if (cbDepartments.Text == "")
            {
                MessageBox.Show("Please select a department");
                return;
            }

            int week = 0;
            int year = 0;
            string department = cbDepartments.Text;
            try
            {
                week = Convert.ToInt32(lblPlanningWeek.Text);
                year = Convert.ToInt32(txtPlanningYear.Value);
            }
            catch
            {
                MessageBox.Show("Please select a week and year");
                return;
            }

            depotManager.autoSchedule.deletePlanning.DeletePlaningThisWeek(week, year, department);

            progressBar1.Maximum = 63;

            Prefrance prefrance = Prefrance.Prefered;
            for (int loop = 0; loop < 3; loop++)
            {
                Days Day = Days.Monday;
                Shifts Shift = Shifts.Morning;
                for (int i = 0; i < 7; i++)
                {
                    Shift = Shifts.Morning;

                    for (int j = 0; j < 3; j++)
                    {
                        List<int> Employees = new List<int>();
                        int AmountToSchedule = depotManager.autoSchedule.amountOfEmployeesNeeded.AmountLeftToSchedule(Shift.ToString(), Day.ToString(), week, year, department);;

                        if (prefrance == Prefrance.Prefered)
                        {
                            if (AmountToSchedule != 0)
                            {
                                Employees = depotManager.autoSchedule.employeesAvailible.EmployeesAvailible(Shift, Day, week, year, department, prefrance);
                            }
                        }
                        else if (prefrance == Prefrance.No_Prefrance)
                        {
                            if (AmountToSchedule != 0)
                            {
                                Employees = depotManager.autoSchedule.employeesAvailible.EmployeesAvailible(Shift, Day, week, year, department, prefrance);
                            }
                        }
                        else if (prefrance == Prefrance.Not_Prefered)
                        {
                            if (AmountToSchedule != 0)
                            {
                               Employees = depotManager.autoSchedule.employeesAvailible.EmployeesAvailible(Shift, Day, week, year, department, prefrance); 
                            }
                        }

                        if (AmountToSchedule != 0)
                        {
                            if (Employees.Count < AmountToSchedule)
                            {
                                depotManager.autoSchedule.asignShift.ScheduleAllEmployees(Employees, AmountToSchedule, Shift.ToString(), Day.ToString(), week, year);
                            }
                            else
                            {
                                depotManager.autoSchedule.asignShift.ScheduleShift(Employees, AmountToSchedule, Shift.ToString(), Day.ToString(), week, year);
                            }
                        }

                        if (progressBar1.Value != 62)
                        {
                            progressBar1.Value++;
                        }
                        Shift++;
                    }
                    Day++;
                }
                prefrance++;
            }

            progressBar1.Value = 0;

            c.GetAllRegisteredShift();
            UpdateEmployeeList();


            MessageBox.Show("Schedule has been completed");
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int selectedrowindex = dgPlanningSchedule.SelectedCells[0].RowIndex;
            int selectedcolumnindex = dgPlanningSchedule.SelectedCells[0].ColumnIndex;
            DataGridViewRow selectedRow = dgPlanningSchedule.Rows[selectedrowindex];
            DataGridViewColumn selectedColumn = dgPlanningSchedule.Columns[selectedcolumnindex];
            int year = Convert.ToInt32(txtPlanningYear.Value);
            int week = Convert.ToInt32(lblPlanningWeek.Text);
            string day = Convert.ToString(selectedRow.Cells["Day"].Value);
            string shift = Convert.ToString(selectedColumn.Name);
            string department = cbDepartments.Text;

            lstEmpCanWork.Items.Clear();

            if (c.GetPreferredShift(day, shift) != null)
            {
                if (rdNoPreference.Checked)
                {
                    foreach (Employee employee in c.EmployeesWithNoPreference(day, shift))
                    {
                        if (DepartmentTrue(employee, department) == true && c.RegisteredEmployeeExist(department, year, week, day, shift, employee.EmployeeID) == false)
                        {
                            if (employee.FirstName.Contains(txtSearch.Text) || employee.LastName.Contains(txtSearch.Text))
                            {
                                lstEmpCanWork.Items.Add(employee);
                            }
                        }
                    }
                }
                else
                {
                    if (rbPreferred.Checked)
                    {
                        foreach (Employee employee in c.GetPreferredShift(day, shift).Employees)
                        {
                            if (c.GetPreferredShift(day, shift).IsPreferred == true && DepartmentTrue(employee, department) == true && c.RegisteredEmployeeExist(department, year, week, day, shift, employee.EmployeeID) == false)
                            {
                                if (employee.FirstName.Contains(txtSearch.Text) || employee.LastName.Contains(txtSearch.Text))
                                {
                                    lstEmpCanWork.Items.Add(employee);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (rbNotPreferred.Checked)
                        {
                            foreach (Employee employee in c.GetPreferredShift(day, shift).Employees)
                            {
                                if (c.GetPreferredShift(day, shift).IsPreferred == false && DepartmentTrue(employee, department) == true && c.RegisteredEmployeeExist(department, year, week, day, shift, employee.EmployeeID) == false)
                                {
                                    if (employee.FirstName.Contains(txtSearch.Text) || employee.LastName.Contains(txtSearch.Text))
                                    {
                                        lstEmpCanWork.Items.Add(employee);
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
        private void btnClearWeek_Click(object sender, EventArgs e)
        {
            if (cbDepartments.Text == "")
            {
                MessageBox.Show("Please select a department");
                return;
            }

            int week = 0;
            int year = 0;
            string department = cbDepartments.Text;
            try
            {
                week = Convert.ToInt32(lblPlanningWeek.Text);
                year = Convert.ToInt32(txtPlanningYear.Value);
            }
            catch
            {
                MessageBox.Show("Please select a week and year");
                return;
            }

            depotManager.autoSchedule.deletePlanning.DeletePlaningThisWeek(week, year, department);

            UpdatePlanningSchedule();

            c.GetAllRegisteredShift();
            UpdateEmployeeList();

        }
        private void ShiftsThatNeedEmployee()
        {
            try
            {
                if (cbDepartments.Text == "")
                {
                    MessageBox.Show("Please select a department");
                    return;
                }

                cbUnregisteredShift.Items.Clear();
                cbUnregisteredShift.Text = "";

                int week = 0;
                int year = 0;
                string department = cbDepartments.Text;
                try
                {
                    week = Convert.ToInt32(lblPlanningWeek.Text);
                    year = Convert.ToInt32(txtPlanningYear.Value);
                }
                catch
                {
                    MessageBox.Show("Please select a week and year");
                    return;
                }

                Days Day = Days.Monday;
                Shifts Shift = Shifts.Morning;
                for (int i = 0; i < 7; i++)
                {
                    Shift = Shifts.Morning;
                    for (int loop = 0; loop < 3; loop++)
                    {
                        if (depotManager.autoSchedule.amountOfEmployeesNeeded.AmountLeftToSchedule(Shift.ToString(), Day.ToString(), week, year, department) > 0)
                        {
                            cbUnregisteredShift.Items.Add($"{Day} - {Shift}");
                        }
                        Shift++;
                    }
                    Day++;
                }

                if (cbUnregisteredShift.Items.Count > 0)
                {
                    cbUnregisteredShift.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    cbUnregisteredShift.BackColor = System.Drawing.Color.White;
                    cbUnregisteredShift.Text = "Nothing left to shedule.";
                }
            }
            catch { }
        }
        private void btnCheckForShifts_Click(object sender, EventArgs e)
        {
            ShiftsThatNeedEmployee();
        }
    }
}

