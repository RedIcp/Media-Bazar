using ClassLibraryProject.Interfaces;
using System;
using MySql.Data.MySqlClient;
using ClassLibraryProject.Class;
using System.Diagnostics;

namespace ClassLibraryProject.dbClasses.AutoSchedule
{
    public class DbDeletePlanningForTheWeekManagment : IDbDeletePlanningForTheWeekManagment
    {
        public bool DeletePlaningThisWeek(int week, int year, string department)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = $"DELETE FROM `planning` WHERE `Year` = {year} and `Week`= {week} AND (EmployeeID) IN (SELECT EmployeeID FROM contract WHERE department = '{department}');";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                int AmountDeleted = cmd.ExecuteNonQuery();

                if (AmountDeleted > 1)
                {
                    return true;
                }
            }
            catch (MySqlException a)
            { Debug.WriteLine(a.Message); }
            catch (Exception a)
            { Debug.WriteLine(a.Message); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return true;
        }
    }
}
