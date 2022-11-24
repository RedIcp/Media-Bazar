using ClassLibraryProject.Interfaces;
using System;
using System.Collections.Generic;
using ClassLibraryProject.Class;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace ClassLibraryProject.dbClasses.AutoSchedule
{
    public class DbEmployeesAvailibleManagment : IDbEmployeesAvailibleManagment
    {
        public List<int> EmployeesAvailible(string sql)
        {
            List<int> Employees = new List<int>();

            MySqlConnection conn = Utils.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employees.Add(Convert.ToInt32(reader[0]));
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
            return Employees;
        }  
    }
}
