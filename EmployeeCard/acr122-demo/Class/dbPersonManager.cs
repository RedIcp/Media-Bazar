using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace acr122_demo.Class
{
    public class DBPersonManager
    {
        private string CHANGE_CARD_INFO = "UPDATE Employee SET CardNumber = @CardNumber WHERE EmployeeID = @EmployeeID;";
        private string GET_EMPLOYEE_BY_CARDNUMBER = "SELECT `EmployeeID` FROM `employee` WHERE `CardNumber`= @CardNumber;";
        private string GET_EMPLOYEES = "SELECT * FROM Employee WHERE Active = 1 AND FirstName LIKE ' @Search %' OR Active = 1 AND LastName LIKE ' @Search %' ORDER BY Employee.EmployeeID;";

        public void changeID(string employeeID, string CardNumber)
        {
            MySqlConnection conn = Connection.GetConnection();
            string sql = CHANGE_CARD_INFO;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@CardNumber", CardNumber);

                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();

                if (numAffectedRows >= 1)
                {
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
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

        public int GetEmployeeID(string CardNumber)
        {
            MySqlConnection conn = Connection.GetConnection();

            string sql = GET_EMPLOYEE_BY_CARDNUMBER;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@CardNumber", CardNumber);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return Convert.ToInt32(reader[0]);
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

        public List<Person> ViewAllEmployees(string search)
        {
            List<Person> people = new List<Person>();

            MySqlConnection conn = Connection.GetConnection();

            string sql = $"SELECT * FROM Employee WHERE Active = 1 AND FirstName LIKE '{search}%' OR Active = 1 AND LastName LIKE '{search}%' ORDER BY Employee.EmployeeID;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Person employee;

                while (reader.Read())
                {
                    try
                    {
                        employee = new Person(
                            reader.GetInt32("EmployeeID"),
                            reader.GetString("FirstName"),
                            reader.GetString("LastName"),
                            reader.GetInt32("PhoneNumber"),
                            reader.GetString("Email"),
                            reader.GetString("city"),
                            reader.GetString("DateOfBirth"),
                            reader.GetInt32("BSN"),
                            reader.GetString("UserName"),
                            reader.GetString("Password"),
                            reader.GetString("CardNumber"));

                        people.Add(employee);
                    }
                    catch
                    {
                        employee = new Person(
                              reader.GetInt32("EmployeeID"),
                              reader.GetString("FirstName"),
                              reader.GetString("LastName"),
                              0,
                              reader.GetString("Email"),
                              reader.GetString("city"),
                              reader.GetString("DateOfBirth"),
                              reader.GetInt32("BSN"),
                              reader.GetString("UserName"),
                              reader.GetString("Password"),
                              "");

                        if (reader.GetString("CardNumber") != null)
                        {
                            employee.CardNumber = reader.GetString("CardNumber");
                        }

                        people.Add(employee);
                    }
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return people;
        }
    }
}
