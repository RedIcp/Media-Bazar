using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite
{
    public class DBAvailabilityManager : IDBAvailabilityManager
    {
        //sql
        public string ENTER_AVAILABILITY = "INSERT INTO Availability (EmployeeID, Year, Week, Day) VALUES (@EmployeeID, @Year, @Week, @Day);";
        public string READ_AVAILABILITY = "SELECT * FROM Availability WHERE EmployeeID = @EmployeeID GROUP BY Year, Week, Day;";

        public bool EnterAvailability(Unavailability u)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = ENTER_AVAILABILITY;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@EmployeeID", u.Employee.EmployeeID);
                cmd.Parameters.AddWithValue("@Year", u.Year);
                cmd.Parameters.AddWithValue("@Week", u.Week);
                cmd.Parameters.AddWithValue("@Day", u.Day);

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

        public List<Unavailability> ReadAvailability(Employee e)
        {
            List<Unavailability> unavailabilities = new List<Unavailability>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = READ_AVAILABILITY;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@EmployeeID", e.EmployeeID);

                MySqlDataReader reader = cmd.ExecuteReader();

                Unavailability unavailability;

                while (reader.Read())
                {
                    int year = reader.GetInt32(2);
                    int week = reader.GetInt32(3);
                    string day = reader.GetString(4);

                    unavailability = new Unavailability(year, week, day, e);
                    unavailabilities.Add(unavailability);
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

            return unavailabilities;
        }
    }
}
