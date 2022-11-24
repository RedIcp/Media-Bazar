using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ClassLibraryProject.dbClasses
{
    public class DBRegisteredShift : IDBRegisteredShift
    {
        public string GET_ALL_EMPLOYEES = "SELECT * FROM Employee as e INNER JOIN Contract as c on e.EmployeeID = c.EmployeeID WHERE e.Active = 1 AND c.Active = 1;";

        private string GET_REGISTERED_SHIFTS = "SELECT * FROM planning;";
        private string REGISTER_EMPLOYEE = "INSERT INTO planning (Year, Week, Day, Shift, EmployeeID) VALUES (@Year, @Week, @Day, @Shift, @Employee);";
        private string DE_REGISTER_EMPLOYEE = "DELETE FROM planning WHERE Year = @Year AND Week = @Week AND Day = @Day AND Shift = @Shift AND EmployeeID = @Employee;";

        private List<RegisteredShift> registeredShifts;
        private List<Employee> employees;

        public DBRegisteredShift()
        {
            registeredShifts = new List<RegisteredShift>();
            employees = new List<Employee>();

            GetAllEmployees();
            GetAllRegisteredShifts();
        }
        public void GetAllRegisteredShifts()
        {
            registeredShifts.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_REGISTERED_SHIFTS;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                RegisteredShift registeredShift;

                while (reader.Read())
                {
                    int year = reader.GetInt32("Year");
                    int week = reader.GetInt32("Week");
                    string day = reader.GetString("Day");
                    string shift = reader.GetString("Shift");
                    int employeeID = reader.GetInt32("EmployeeID");

                    Employee employee = GetEmployee(employeeID);
                    if (employee != null)
                    {
                        if (RegisteredShiftExist(Department(employee), year, week, day, shift) == true)
                        {
                            GetRegisteredShift(Department(employee), year, week, day, shift).Employees.Add(GetEmployee(employeeID));
                        }
                        else
                        {
                            registeredShift = new RegisteredShift(Department(employee), year, week, day, shift);
                            registeredShifts.Add(registeredShift);
                            registeredShift.Employees.Add(GetEmployee(employeeID));
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

        public bool RegisterEmployee(string department, int year, int week, string day, string shift, int employeeID)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = REGISTER_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);
                cmd.Parameters.AddWithValue("@Employee", employeeID);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    Employee employee = GetEmployee(employeeID);
                    if (employee != null)
                    {
                        if (RegisteredShiftExist(department, year, week, day, shift) == true)
                        {
                            GetRegisteredShift(department, year, week, day, shift).Employees.Add(GetEmployee(employeeID));
                        }
                        else
                        {
                            RegisteredShift registeredShift = new RegisteredShift(department, year, week, day, shift);
                            registeredShifts.Add(registeredShift);
                            registeredShift.Employees.Add(GetEmployee(employeeID));
                        }
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
        public bool DeRegisterEmployee(string department, int year, int week, string day, string shift, int employeeID)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = DE_REGISTER_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);
                cmd.Parameters.AddWithValue("@Employee", employeeID);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    Employee employee = GetEmployee(employeeID);
                    GetRegisteredShift(department, year, week, day, shift).Employees.Remove(employee);
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

        public string Department(Employee employee)
        {
            foreach (Contract contract in employee.Contracts)
            {
                return contract.Department;
            }
            return "";
        }
        public RegisteredShift GetRegisteredShift(string department, int year, int week, string day, string shift)
        {
            foreach (RegisteredShift rs in registeredShifts)
            {
                if (rs.Department == department && rs.Year == year && rs.Week == week && rs.Day == day && rs.Shift == shift)
                {
                    return rs;
                }
            }
            return null;
        }
        public bool RegisteredShiftExist(string department, int year, int week, string day, string shift)
        {
            if (GetRegisteredShift(department, year, week, day, shift) != null)
            {
                return true;
            }
            return false;
        }
    }
}
