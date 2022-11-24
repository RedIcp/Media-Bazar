using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ClassLibraryProject.ManagmentClasses
{
    public class EmployeeManagement
    {
        // fields

        // sql
        public string CREATE_EMPLOYEE = "INSERT INTO Employee (FirstName, LastName, UserName, Password, BSN, Active, City, Email, PhoneNumber, DateOfBirth) VALUES (@FirstName, @LastName, @Username, @Password, @BSN, @Active, @City, @Email, @PhoneNumber, @DateOfBirth);";
        public string GET_ALL_EMPLOYEES = "SELECT * FROM Employee ORDER BY EmployeeID LIMIT 25;";
        public string UPDATE_EMPLOYEE = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, City = @City, PhoneNumber = @PhoneNumber WHERE EmployeeID = @EmployeeID;";
        public string DELETE_EMPLOYEE_BY_ID = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";

        public string VIEW_EMPLOYEE = "SELECT * FROM Employee WHERE EmployeeID = @EmployeeID;";
        public string REMOVE_EMPLOYEE_BY_ID = "UPDATE Employee SET Active = @Active WHERE EmployeeID = @EmployeeID;";
       
        //Used in website
        public static string GET_EMPLOYEE_BY_USERNAME = "SELECT * FROM Employee WHERE UserName = @UserName;";
        public static string EDIT_EMPLOYEE_BY_ID = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, Password = @Password, UserName = @UserName,  BSN = @BSN, City = @City, PhoneNumber = @PhoneNumber, Email = @Email WHERE EmployeeID = @EmployeeID;";

        //MohammadStart
        private string GET_AVAILABLE_EMPLOYEE = "SELECT * FROM availability INNER JOIN employee ON availability.EmployeeID = employee.EmployeeID WHERE Week = @Week AND Day = @Day AND Shift = @Shift;";
        private string GET_ENLISTED_EMPLOYEE = "SELECT * FROM planning INNER JOIN employee ON planning.EmployeeID = employee.EmployeeID WHERE Year = @Year AND Week = @Week AND Day = @Day AND Shift = @Shift;";

        private List<Employee> availableEmployee;
        private List<Employee> enlistedEmployee;
        private List<Employee> employeeWorkingToday;

        public List<Employee> AvailableEmployee
        {
            get { return availableEmployee; }
            set { availableEmployee = value; }
        }
        public List<Employee> EnlistedEmployee
        {
            get { return enlistedEmployee; }
            set { enlistedEmployee = value; }
        }
        public List<Employee> EmployeeWorkingToday
        {
            get { return employeeWorkingToday; }
            set { employeeWorkingToday = value; }
        }
        public EmployeeManagement()
        {
            AvailableEmployee = new List<Employee>();
            EnlistedEmployee = new List<Employee>();
            EmployeeWorkingToday = new List<Employee>();
        }

        public void GetAvailableEmployees(int week, string day, string shift)
        {
            AvailableEmployee.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_AVAILABLE_EMPLOYEE;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);


                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Employee employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32("EmployeeID");
                    string lastName = reader.GetString("LastName");
                    string firstName = reader.GetString("FirstName");
                    int phoneNumber = reader.GetInt32("PhoneNumber");
                    string email = reader.GetString("Email");
                    string city = reader.GetString("Address");
                    string dateOfBirth = reader.GetString("DateOfBirth");
                    int bsn = reader.GetInt32("BSN");
                    string username = reader.GetString("Username");
                    string password = reader.GetString("Password");
                    int active = reader.GetInt32("Active");

                    GetEnlistedEmployees(2021, week, day, shift);
                    /*if (active == 1)
                    {
                        if (IsInList(employeeID) == true)
                        {
                            employee = new Admin(employeeID, lastName, firstName, phoneNumber, email, city, dateOfBirth, bsn, username, password);
                            AvailableEmployee.Add(employee);
                        }
                    }*/
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
        public void GetEnlistedEmployees(int year, int week, string day, string shift)
        {
            EnlistedEmployee.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ENLISTED_EMPLOYEE;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Employee employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32("EmployeeID");
                    string lastName = reader.GetString("LastName");
                    string firstName = reader.GetString("FirstName");
                    int phoneNumber = reader.GetInt32("PhoneNumber");
                    string email = reader.GetString("Email");
                    string city = reader.GetString("Address");
                    string dateOfBirth = reader.GetString("DateOfBirth");
                    int bsn = reader.GetInt32("BSN");
                    string username = reader.GetString("Username");
                    string password = reader.GetString("Password");
                    int active = reader.GetInt32("Active");

                    /*if (active == 1)
                    {
                        employee = new Admin(employeeID, lastName, firstName, phoneNumber, email, city, dateOfBirth, bsn, username, password);
                        EnlistedEmployee.Add(employee);
                    }*/
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
        //MohammadEnd

        // esther start
        public void CreateEmployee(string firstName, string lastName, int bsn, string city, string email, string dateOfBirth, string personalEmail, string username, string password, int phoneNumber, string jobTitle, int workHoursPerWeek, double salary, string startDate)
        {
            EmailManager em = new EmailManager();

            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_EMPLOYEE;

            DateTime DateOfBirth = Convert.ToDateTime(dateOfBirth);

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@BSN", bsn);
                cmd.Parameters.AddWithValue("@Active", 1);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth.ToString("yyyy-MM-dd")) ;

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();
                long id = cmd.LastInsertedId;

                int employeeID = Convert.ToInt32(id);
                CreateContract(employeeID, jobTitle, workHoursPerWeek, salary, startDate);

                em.Email(password, username, personalEmail);

                return;
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
        public void CreateContract(int employeeID, string jobTitle, int workHoursPerWeek, double salary, string startDate)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = ContractManagement.CREATE_CONTRACT;

            DateTime StartDate = Convert.ToDateTime(startDate);

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@JobTitle", jobTitle);
                cmd.Parameters.AddWithValue("@WorkHoursPerWeek", workHoursPerWeek);
                cmd.Parameters.AddWithValue("@SalaryPerHour", salary);
                cmd.Parameters.AddWithValue("@StartDate", StartDate.ToString("yyyy-MM-dd"));

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();
                //long id = cmd.LastInsertedId;
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
        public bool IsInList(int ID)
        {
            foreach (Employee e in EnlistedEmployee)
            {
                if (e.EmployeeID == ID)
                {
                    return false;
                }
            }
            return true;
        }
        private string GET_EMPLOYEE_WORKING_TODAY = "SELECT * FROM planning INNER JOIN employee ON planning.EmployeeID = employee.EmployeeID WHERE Year = @Year AND Week = @Week AND Day = @Day;";



        public void GetEmployeesWorkingToday(int year, int week, string day)
        {
            EnlistedEmployee.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_EMPLOYEE_WORKING_TODAY;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);



                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Day", day);



                conn.Open();



                MySqlDataReader reader = cmd.ExecuteReader();



                Employee employee;



                while (reader.Read())
                {
                    int employeeID = reader.GetInt32("EmployeeID");
                    string lastName = reader.GetString("LastName");
                    string firstName = reader.GetString("FirstName");
                    int phoneNumber = reader.GetInt32("PhoneNumber");
                    string email = reader.GetString("Email");
                    string city = reader.GetString("City");
                    string dateOfBirth = reader.GetString("DateOfBirth");
                    int bsn = reader.GetInt32("BSN");
                    string username = reader.GetString("Username");
                    string password = reader.GetString("Password");
                    int active = reader.GetInt32("Active");



                    /*if (active == 1)
                    {
                        employee = new Admin(employeeID, lastName, firstName, phoneNumber, email, city, dateOfBirth, bsn, username, password);
                        EmployeeWorkingToday.Add(employee);
                    }*/
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


    }
}
