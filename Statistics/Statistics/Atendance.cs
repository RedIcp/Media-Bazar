using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Statistics
{
    class Atendance
    {
       public List<EmployeeWorkTime> emp;

        public Atendance()
        {
            emp = new List<EmployeeWorkTime>();
        }
          
        public void GetAtendanceData(int year, int month)
        {
            emp.Clear();
            MySqlConnection conn = Utils.GetConnection();

            string sql = "SELECT employee.`EmployeeID`, HOUR(SEC_TO_TIME(SUM(TIME_TO_SEC(TIMEDIFF(`CheckOutTime`,`CheckInTime`))))), `WorkHoursPerWeek`, `FirstName`,`LastName` FROM `attendance` INNER JOIN employee ON attendance.EmployeeID = employee.EmployeeID INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE checkdate LIKE '" + year + "-0" + month + "%' AND employee.Active = 1 AND contract.Active = 1  group by contract.EmployeeID;";

            if (month > 9)
            {
                sql = "SELECT employee.`EmployeeID`, HOUR(SEC_TO_TIME(SUM(TIME_TO_SEC(TIMEDIFF(`CheckOutTime`,`CheckInTime`))))), `WorkHoursPerWeek`, `FirstName`,`LastName` FROM `attendance` INNER JOIN employee ON attendance.EmployeeID = employee.EmployeeID INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE checkdate LIKE '" + year + "-" + month + "%' AND employee.Active = 1 AND contract.Active = 1  group by contract.EmployeeID;";
            }
  
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                EmployeeWorkTime a;

                while (reader.Read())
                {
                    a = new EmployeeWorkTime(Convert.ToInt32(reader[0]), reader[3].ToString() + " " + reader[4].ToString(), new TimeSpan(Convert.ToInt32(reader[1]),0,0), Convert.ToInt32(reader[2]));
                          emp.Add(a);
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
