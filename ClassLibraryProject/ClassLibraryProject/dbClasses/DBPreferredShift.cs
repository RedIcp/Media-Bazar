using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ClassLibraryProject.dbClasses
{
    public class DBPreferredShift : IDBPreferredShift
    {
        public string GET_ALL_EMPLOYEES = "SELECT * FROM Employee as e INNER JOIN Contract as c on e.EmployeeID = c.EmployeeID WHERE e.Active = 1 AND c.Active = 1;";

        private string GET_PREFERRED_SHIFTS = "SELECT * FROM preferedtime;";
        private string PREFER_SHIFT = "INSERT INTO preferedtime (Day, Shift, EmployeeID, Prefered) VALUES ('@Day', '@Shift', @EmployeeID, @Prefered);";
        private string UPDATE_PREFERRED_SHIFT = "UPDATE preferedtime SET Prefered = @Prefered WHERE Day = @Day AND Shift = @Shift AND EmployeeID = @EmployeeID;";
        private string DELETE_PREFERRED_SHIFT = "DELETE FROM preferedtime WHERE Week = @Week AND Day = @Day AND Shift = @Shift AND EmployeeID = @EmployeeID;";

        private List<PreferredShift> preferredShifts;
        private List<Employee> employees;

        public List<PreferredShift> GetPreferredShifts()
        {
            return preferredShifts;
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }
        public DBPreferredShift()
        {
            preferredShifts = new List<PreferredShift>();
            employees = new List<Employee>();

            GetAllEmployees();
            GetAllPreferredShifts();
        }
        private void GetAllPreferredShifts()
        {
            preferredShifts.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_PREFERRED_SHIFTS;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                PreferredShift preferredShift;

                while (reader.Read())
                {
                    string day = reader.GetString("Day");
                    string shift = reader.GetString("Shift");
                    int employeeID = reader.GetInt32("EmployeeID");
                    int preferred = reader.GetInt32("Prefered");

                    bool isPreferred = true;
                    if (preferred == 1)
                    {
                        isPreferred = true;
                    }
                    else
                    {
                        isPreferred = false;
                    }

                    if (PreferredShiftExist(day, shift) == true)
                    {
                        if (GetEmployee(employeeID) != null)
                        {
                            GetPreferredShift(day, shift).Employees.Add(GetEmployee(employeeID));
                        }
                    }
                    else
                    {
                        if (GetEmployee(employeeID) != null)
                        {
                            preferredShift = new PreferredShift(day, shift, isPreferred);
                            preferredShifts.Add(preferredShift);
                            preferredShift.Employees.Add(GetEmployee(employeeID));
                        }
                    }
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public Employee GetEmployee(int id)
        {
            foreach (Employee employee in employees)
            {
                if (employee.EmployeeID == id)
                {
                    return employee;
                }
            }
            return null;
        }
        private void GetAllEmployees()
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_ALL_EMPLOYEES;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Employee employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32(0);
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string username = reader.GetString(3);
                    string password = reader.GetString(4);
                    int bsn = reader.GetInt32(5);
                    string city = reader.GetString(7);
                    string email = reader.GetString(8);
                    string phoneNumber = reader.GetString(9);
                    DateTime dateOfBirth = reader.GetDateTime(10);
                    string streetName = reader.GetString(12);
                    string zipCode = reader.GetString(13);
                    string personalEmail = reader.GetString(14);
                    string jobTitle = reader.GetString(17);
                    string department = reader.GetString("Department");

                    IEmployeeManagerAll employeeManagerAll = new EmployeeManager();

                    if (jobTitle == "DEPOT EMPLOYEE")
                    {
                        employee = new DepotEmployee(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        Contract contract = new Contract(department);
                        employee.Contracts.Add(contract);
                        employees.Add(employee);
                    }
                    if (jobTitle == "SALES REPRESENTATIVE")
                    {
                        employee = new SalesRepresentative(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        Contract contract = new Contract(department);
                        employee.Contracts.Add(contract);
                        employees.Add(employee);
                    }
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public bool PreferAShift(string day, string shift, Employee employee, bool isPreferred)
        {
            MySqlConnection conn = Utils.GetConnection();
            
            int preferred = 0;
            if (isPreferred == true)
            {
                preferred = 1;
            }
            else
            {
                preferred = 0;
            }

            //string sql = PREFER_SHIFT;
          
            string sql = $"INSERT INTO preferedtime (Day, Shift, EmployeeID, Prefered) VALUES ('{day}', '{shift}', {employee.EmployeeID}, {preferred});";
           
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //cmd.Parameters.AddWithValue("@Day", day);
                //cmd.Parameters.AddWithValue("@Shift", shift);
                //cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);

                //int preferred = 0;
                //if (isPreferred == true)
                //{
                //    preferred = 1;
                //}
                //else
                //{
                //    preferred = 0;
                //}

                //cmd.Parameters.AddWithValue("@Prefered", preferred);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    if (PreferredShiftExist(day, shift) == true)
                    {
                        GetPreferredShift(day, shift).Employees.Add(employee);
                    }
                    else
                    {
                        PreferredShift preferredShift = new PreferredShift(day, shift, isPreferred);
                        preferredShifts.Add(preferredShift);
                        preferredShift.Employees.Add(employee);
                    }
                    return true;
                }
                return false;
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return false;
        }
        public bool UpdatePreferredShift(string day, string shift, Employee employee, bool isPreferred)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = UPDATE_PREFERRED_SHIFT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);
                cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);

                int preferred = 0;
                if (isPreferred == true)
                {
                    preferred = 1;
                }
                else
                {
                    preferred = 0;
                }

                cmd.Parameters.AddWithValue("@Prefered", preferred);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return false;
        }
        public bool DeletePreferredShift(string day, string shift, Employee employee)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = DELETE_PREFERRED_SHIFT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);
                cmd.Parameters.AddWithValue("@Employee", employee.EmployeeID);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    GetPreferredShift(day, shift).Employees.Remove(employee);
                    return true;
                }
                return false;
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return false;
        }
        public PreferredShift GetPreferredShift(string day, string shift)
        {
            foreach (PreferredShift ps in preferredShifts)
            {
                if (ps.Day == day && ps.Shift == shift)
                {
                    return ps;
                }
            }
            return null;
        }
        public bool PreferredShiftExist(string day, string shift)
        {
            if (GetPreferredShift(day, shift) != null)
            {
                return true;
            }
            return false;
        }
    }
}
