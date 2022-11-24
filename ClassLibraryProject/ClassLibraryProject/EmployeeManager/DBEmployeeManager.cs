using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.dbClasses.AutoSchedule;
using ClassLibraryProject.Interfaces;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace ClassLibraryProject
{
    public class DBEmployeeManager : IDBEmployeeManagerOffice, IDBEmployeeManagerAdmin, IDBEmployeeManagerAll
    {
        // sql
        public string CREATE_EMPLOYEE = "INSERT INTO Employee (FirstName, LastName, UserName, Password, BSN, Active, City, Email, PhoneNumber, DateOfBirth, StreetName, ZipCode, PersonalEmail) VALUES (@FirstName, @LastName, @Username, @Password, @BSN, @Active, @City, @Email, @PhoneNumber, @DateOfBirth, @StreetName, @ZipCode, @PersonalEmail);";
        public string READ_EMPLOYEES = "SELECT * FROM Employee as e INNER JOIN Contract as c on e.EmployeeID = c.EmployeeID WHERE e.Active = @Active GROUP BY e.FirstName, e.LastName LIMIT 100;";
        public string UPDATE_EMPLOYEE = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, City = @City, PhoneNumber = @PhoneNumber, StreetName = @StreetName, ZipCode = @ZipCode, PersonalEmail = @PersonalEmail WHERE EmployeeID = @EmployeeID;";
        public string DELETE_EMPLOYEE = "UPDATE Employee SET Active = @Active WHERE EmployeeID = @EmployeeID;";

        public string GET_EMPLOYEE_ID = "SELECT * FROM Employee WHERE Email = @Email AND Active = @Active;";
        public string GET_EMPLOYEE_BY_ID = "SELECT * FROM Employee as e INNER JOIN Contract as c on e.EmployeeID = c.EmployeeID WHERE e.EmployeeID = @EmployeeID AND e.Active = 1;";
        public string AMOUNT_OF_OFFICEMANAGERS = "SELECT COUNT(employee.EmployeeID) FROM employee INNER JOIN contract on contract.employeeID = employee.EmployeeID WHERE jobtitle = 'OFFICE MANAGER';";

        public string GET_EMPLOYEE_CONTRACTS = "SELECT * FROM Contract WHERE EmployeeID = @EmployeeID";
        public string SEARCH_EMPLOYEE = "SELECT * FROM Employee as e INNER JOIN Contract as c on e.EmployeeID = c.EmployeeID WHERE e.FirstName LIKE @Search  AND e.Active = @Active OR e.LastName LIKE @Search AND e.Active = @Active GROUP BY e.FirstName, e.LastName LIMIT 100;";

        //public string UPDATE_OWN_INFO = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName WHERE EmployeeID = @EmployeeID;";
        public string UPDATE_OWN_INFO = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, City = @City, PhoneNumber = @PhoneNumber, StreetName = @StreetName, ZipCode = @ZipCode, PersonalEmail = @PersonalEmail, Password = @Password WHERE EmployeeID = @EmployeeID;";
        public int AmountOfOfficeManagers()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = AMOUNT_OF_OFFICEMANAGERS;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();


                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    return Convert.ToInt16(reader[0]);
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
            return 0;
        }

        public bool CreateEmployee(Employee e)
        {


            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@FirstName", e.FirstName);
                cmd.Parameters.AddWithValue("@LastName", e.LastName);
                cmd.Parameters.AddWithValue("@Username", e.Username);
                cmd.Parameters.AddWithValue("@Password", e.Password);
                cmd.Parameters.AddWithValue("@BSN", e.BSN);
                cmd.Parameters.AddWithValue("@Active", 1);
                cmd.Parameters.AddWithValue("@City", e.City);
                cmd.Parameters.AddWithValue("@Email", e.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", e.PhoneNumber);
                cmd.Parameters.AddWithValue("@DateOfBirth", e.DateOfBirth);
                cmd.Parameters.AddWithValue("@StreetName", e.Address);
                cmd.Parameters.AddWithValue("@ZipCode", e.ZipCode);
                cmd.Parameters.AddWithValue("@PersonalEmail", e.PersonalEmail);

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows == 1)
                {
                    //SendEmail(e);
                    return true;
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

            return false;
        }
        public List<Employee> ReadEmployees()
        {
            List<Employee> employees = new List<Employee>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = READ_EMPLOYEES;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@Active", 1);

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
                    string jobTitle = reader.GetString(17);
                    string personalEmail = reader.GetString(14);

                    if (jobTitle == "ADMIN")
                    {
                        employee = new Admin(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    } else if (jobTitle == "CEO")
                    {
                        employee = new CEO(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    } else if (jobTitle == "DEPOT MANAGER")
                    {
                        employee = new DepotManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    } else if (jobTitle == "DEPOT EMPLOYEE")
                    {
                        employee = new DepotEmployee(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    } else if (jobTitle == "OFFICE MANAGER")
                    {
                        employee = new OfficeManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    } else if (jobTitle == "PRODUCT MANAGER")
                    {
                        employee = new ProductManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    } else if (jobTitle == "SALES MANAGER")
                    {
                        employee = new SalesManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "SALES REPRESENTATIVE")
                    {
                        employee = new SalesRepresentative(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
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

            return employees;
        }

        public bool DeleteEmployee(Employee e)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = DELETE_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@EmployeeID", e.EmployeeID);

                cmd.Parameters.AddWithValue("@Active", 0);

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows == 1)
                {
                    return true;
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

            return false;
        }

        public bool UpdateEmployee(Employee e)
        {
            if (!Regex.IsMatch(e.ZipCode, @"^[0-9]{4}[A-Z]{2}$"))
            {
                return false;
            }
            if (!Regex.IsMatch(e.PhoneNumber, @"^(\+)316[0-9]{8}$"))
            {
                return false;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@EmployeeID", e.EmployeeID);

                cmd.Parameters.AddWithValue("@FirstName", e.FirstName);
                cmd.Parameters.AddWithValue("@LastName", e.LastName);
                cmd.Parameters.AddWithValue("@City", e.City);
                cmd.Parameters.AddWithValue("@PhoneNumber", e.PhoneNumber);
                cmd.Parameters.AddWithValue("@StreetName", e.Address);
                cmd.Parameters.AddWithValue("@ZipCode", e.ZipCode);
                cmd.Parameters.AddWithValue("@PersonalEmail", e.PersonalEmail);

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows == 1)
                {
                    return true;
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

            return false;
        }

        public Employee GetEmployeeID(string givenEmail, string jobTitle)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_EMPLOYEE_ID;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@Active", 1);
                cmd.Parameters.AddWithValue("@Email", givenEmail);

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

                    if (jobTitle == "ADMIN")
                    {
                       
                        employee = new Admin(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        return employee;
                    }
                    else if (jobTitle == "CEO")
                    {
                        employee = new CEO(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        return employee;
                    }
                    else if (jobTitle == "DEPOT MANAGER")
                    {
                        IEmployeeManagerAll employeeManagerAll = new EmployeeManager();
                        AutoScheduleManagment autoSchedule = new AutoScheduleManagment(new AsignShiftManagment(new DbAsignShiftManagment()), new EmployeesAvailibleManagment(new DbEmployeesAvailibleManagment()), new DeletePlanningForTheWeekManagment(new DbDeletePlanningForTheWeekManagment()), new AmountOfEmployeesNeededManagment(new DbAmountOfEmployeesNeededManagment()));
                        employee = new DepotManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, new DepotDepartmentsManagment(new dbDepotDepartments()), autoSchedule, employeeManagerAll);
                        return employee;
                    }
                    else if (jobTitle == "DEPOT EMPLOYEE")
                    {
                        employee = new DepotEmployee(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        return employee;
                    }
                    else if (jobTitle == "OFFICE MANAGER")
                    {
                        employee = new OfficeManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        return employee;
                    }
                    else if (jobTitle == "PRODUCT MANAGER")
                    {
                        employee = new ProductManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        return employee;
                    }
                    else if (jobTitle == "SALES MANAGER")
                    {
                        AutoScheduleManagment autoSchedule = new AutoScheduleManagment(new AsignShiftManagment(new DbAsignShiftManagment()), new EmployeesAvailibleManagment(new DbEmployeesAvailibleManagment()), new DeletePlanningForTheWeekManagment(new DbDeletePlanningForTheWeekManagment()), new AmountOfEmployeesNeededManagment(new DbAmountOfEmployeesNeededManagment()));
                        employee = new SalesManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, new SalesDepartmentsManagment(new dbSalesDepartments()), autoSchedule);
                        return employee;
                    }
                    else if (jobTitle == "SALES REPRESENTATIVE")
                    {
                        employee = new SalesRepresentative(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        return employee;
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

            return null;
        }
        public Employee GetEmployeeByID(int givenEmployeeID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_EMPLOYEE_BY_ID;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@EmployeeID", givenEmployeeID);

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

                    IEmployeeManagerAll  employeeManagerAll = new EmployeeManager();

                    if (jobTitle == "ADMIN")
                    {
                        employee = new Admin(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        return employee;
                    }
                    else if (jobTitle == "CEO")
                    {
                        employee = new CEO(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        return employee;
                    }
                    else if (jobTitle == "DEPOT MANAGER")
                    {
                        employee = new DepotManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        return employee;
                    }
                    else if (jobTitle == "DEPOT EMPLOYEE")
                    {
                        employee = new DepotEmployee(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        return employee;
                    }
                    else if (jobTitle == "OFFICE MANAGER")
                    {
                        employee = new OfficeManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        return employee;
                    }
                    else if (jobTitle == "PRODUCT MANAGER")
                    {
                        employee = new ProductManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        return employee;
                    }
                    else if (jobTitle == "SALES MANAGER")
                    {
                        AutoScheduleManagment autoSchedule = new AutoScheduleManagment(new AsignShiftManagment(new DbAsignShiftManagment()), new EmployeesAvailibleManagment(new DbEmployeesAvailibleManagment()), new DeletePlanningForTheWeekManagment(new DbDeletePlanningForTheWeekManagment()), new AmountOfEmployeesNeededManagment(new DbAmountOfEmployeesNeededManagment()));
                        employee = new SalesManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, new SalesDepartmentsManagment(new dbSalesDepartments()), autoSchedule, employeeManagerAll);
                        return employee;
                    }
                    else if (jobTitle == "SALES REPRESENTATIVE")
                    {
                        employee = new SalesRepresentative(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        return employee;
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

            return null;
        }

        public bool UpdateOwnInfo(Employee e)
        {
            //if (!Regex.IsMatch(e.ZipCode, @"^[0-9]{4}[A-Z]{2}$"))
            //{
            //    return false;
            //}
            //if (!Regex.IsMatch(e.PhoneNumber, @"^(\+)316[0-9]{8}$"))
            //{
            //    return false;
            //}

            // regex for personal email

            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_OWN_INFO;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@EmployeeID", e.EmployeeID);

                cmd.Parameters.AddWithValue("@FirstName", e.FirstName);
                cmd.Parameters.AddWithValue("@LastName", e.LastName);
                cmd.Parameters.AddWithValue("@City", e.City);
                cmd.Parameters.AddWithValue("@PhoneNumber", e.PhoneNumber);
                cmd.Parameters.AddWithValue("@StreetName", e.Address);
                cmd.Parameters.AddWithValue("@ZipCode", e.ZipCode);
                cmd.Parameters.AddWithValue("@PersonalEmail", e.PersonalEmail);
                cmd.Parameters.AddWithValue("@Password", e.Password);

                int numCreatedRows = cmd.ExecuteNonQuery();
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

            return true;
        }

        public List<Contract> GetEmployeeContracts(Employee e)
        {
            List<Contract> contracts = new List<Contract>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_EMPLOYEE_CONTRACTS;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@EmployeeID", e.EmployeeID);

                MySqlDataReader reader = cmd.ExecuteReader();

                Contract contract;

                while (reader.Read())
                {
                    int contractID = reader.GetInt32(0);
                    string jobTitle = reader.GetString(2);
                    int workHoursPerWeek = reader.GetInt32(3);
                    double salaryPerHour = reader.GetDouble(4);
                    DateTime startDate = reader.GetDateTime(5);
                    DateTime endDate;
                    try
                    {
                        endDate = reader.GetDateTime(6);
                    }
                    catch
                    { 
                        endDate = new DateTime(1000,1,1); 
                    }
                    
                    string department = reader.GetString(8);
                    bool isActive = reader.GetBoolean(9);

                    contract = new Contract(contractID, e, jobTitle, workHoursPerWeek, salaryPerHour, startDate, endDate, department, isActive);
                    contracts.Add(contract);
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

            return contracts;
        }
        public List<Employee> SearchEmployee(string search)
        {
            List<Employee> employees = new List<Employee>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = SEARCH_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@Active", 1);
                cmd.Parameters.AddWithValue("@Search", search + "%");

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
                    string jobTitle = reader.GetString(17);
                    string personalEmail = reader.GetString(14);

                    if (jobTitle == "ADMIN")
                    {
                        employee = new Admin(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "CEO")
                    {
                        employee = new CEO(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "DEPOT MANAGER")
                    {
                        employee = new DepotManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "DEPOT EMPLOYEE")
                    {
                        employee = new DepotEmployee(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "OFFICE MANAGER")
                    {
                        employee = new OfficeManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "PRODUCT MANAGER")
                    {
                        employee = new ProductManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "SALES MANAGER")
                    {
                        employee = new SalesManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "SALES REPRESENTATIVE")
                    {
                        employee = new SalesRepresentative(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
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

            return employees;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = "SELECT * FROM Employee as e Inner JOIN Contract as c on e.EmployeeID = c.EmployeeID WHERE e.Active = 1  group by e.EmployeeID;";

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
                    string jobTitle = reader.GetString(17);
                    string personalEmail = reader.GetString(14);

                    if (jobTitle == "ADMIN")
                    {
                        employee = new Admin(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "CEO")
                    {
                        employee = new CEO(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "DEPOT MANAGER")
                    {
                        employee = new DepotManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "DEPOT EMPLOYEE")
                    {
                        employee = new DepotEmployee(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "OFFICE MANAGER")
                    {
                        employee = new OfficeManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "PRODUCT MANAGER")
                    {
                        employee = new ProductManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "SALES MANAGER")
                    {
                        employee = new SalesManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "SALES REPRESENTATIVE")
                    {
                        employee = new SalesRepresentative(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
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

            return employees;
        }
    }
}
