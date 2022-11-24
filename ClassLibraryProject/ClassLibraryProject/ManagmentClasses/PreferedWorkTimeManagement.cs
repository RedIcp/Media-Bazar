
using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClassLibraryProject.ManagmentClasses
{
    public class PreferedWorkTimeManagement
    {
        // prefered time
        public static string CREATE_PWT = "INSERT INTO preferedtime (EmployeeID, Prefered, Day, Time) VALUES (@EmployeeID, @Prefered, @Day, @Time) WHERE EmployeeID = @EmployeeID;";
        public static string GET_PWT = "SELECT Shift, Day, Prefered FROM preferedtime  WHERE EmployeeID = EmployeeID;";
        public static string UPDATE_PWT = "UPDATE preferedtime SET Shift = @Shift, Prefered = @Prefered WHERE EmployeeID = @EmployeeID and Day = @Day;";
        public static string DELETE_PWT_BY_ID = "DELETE FROM preferedtime WHERE EmployeeID = @EmployeeID";

        public static string VIEW_PWT_BY_ID = "SELECT * FROM preferedtime WHERE EmployeeID = @EmployeeID;";

        // Availability
        public static string GET_AVAILABLE = "SELECT Year, Week, Day, Shift FROM availability  WHERE EmployeeID = @EmployeeID;";
        public static string UPDATE_AVAILABLE = "UPDATE availability SET Year =@Year, Week = @Week, Shift = @Shift, Day = @Day WHERE EmployeeID = @EmployeeID where Day = @Day;";



        // constructor
        public PreferedWorkTimeManagement()
        {

        }


        // methods for prefered work time
        public List<PreferedWorkTime> GetPreferedWorkTimeForEmployee(string employeeId)
        {
            List<PreferedWorkTime> preferedWorks = new List<PreferedWorkTime>();
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                int id = Convert.ToInt32(employeeId);
                MySqlCommand cmd = new MySqlCommand(GET_PWT, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", id);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    string day = reader.GetString("Day");
                    string shift = reader.GetString("Shift");
                    bool preferd = reader.GetBoolean("Prefered");

                    PreferedWorkTime preferedwork = new PreferedWorkTime(shift, day);
                    preferedWorks.Add(preferedwork);

                }
                return preferedWorks;
            }
            catch (MySqlException)
            {

            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public void EditPreferedWorkTimeForEmployee(int employeeID,string day, string shift, bool prefered)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = UPDATE_PWT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);
                cmd.Parameters.AddWithValue("@Prefered", prefered);

                conn.Open();
                int numAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
        }


        // Availability

        public List<PreferedWorkTime> GetAvailableEmployee(string employeeId)
        {
            List<PreferedWorkTime> preferedWorks = new List<PreferedWorkTime>();
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                int id = Convert.ToInt32(employeeId);
                MySqlCommand cmd = new MySqlCommand(GET_AVAILABLE, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", id);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    int year  = reader.GetInt32("Year");
                    int week = reader.GetInt32("Week");
                    string day = reader.GetString("Day");
                    string shift = reader.GetString("Shift");

                    PreferedWorkTime preferedwork = new PreferedWorkTime(year, week, shift, day);
                    preferedWorks.Add(preferedwork);

                }
                return preferedWorks;
            }
            catch (MySqlException)
            {

            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public void EditAvailableEmployee(int year, int week, string day, string shift)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = UPDATE_AVAILABLE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);
                

                conn.Open();
                int numAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
        }

    }
}
