using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClassLibraryProject.ManagmentClasses
{
    public class PlanningManagment
    {
        public static string NEW_PLANNING = "INSERT INTO Planning (Year, Week, Day, Shift, EmployeeID) VALUES (@Year, @Week, @Day, @Shift, @EmployeeID);";
        public static string GET_PLANNING = "SELECT Shift,Day FROM Planning where EmployeeID =@EmployeeID;";
     
        public PlanningManagment()
        {

        }
        public void AddPlanning(int year, int week, string day, string shift, int employeeID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql;
            sql = NEW_PLANNING;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@Shift", shift);

                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
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
        }

        public List<PreferedWorkTime> GetPlanningForEmployee(string employeeID)
        {
            List<PreferedWorkTime> schedules = new List<PreferedWorkTime>();
            MySqlConnection conn = Utils.GetConnection();
            string sql;
            sql = GET_PLANNING;
            try
            {
                int id = Convert.ToInt32(employeeID);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", id);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string shift = reader.GetString("Shift");
                    string day = reader.GetString("Day");
                    PreferedWorkTime prefered = new PreferedWorkTime(shift, day);
                    schedules.Add(prefered);
                }
                return schedules;
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
    }

}
