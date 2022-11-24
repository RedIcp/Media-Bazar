using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using MySql.Data.MySqlClient;

namespace ClassLibraryProject.dbClasses.AutoSchedule
{
    public class DbAsignShiftManagment : IDbAsignShiftManagment
    {
        public bool AssignEmployeeShift(string sql)
        {
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                int LinedAdded = cmd.ExecuteNonQuery();

                if (LinedAdded >= 1)
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
            return false;
        }
    }
}
