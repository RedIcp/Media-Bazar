using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace ClassLibraryProject.dbClasses
{
   public class dbCheckinManagment : ICheckinManagment
    {
        private string GET_TIME_WORKED = "SELECT employee.`EmployeeID`,`FirstName`,`LastName`, SEC_TO_TIME(SUM(TIME_TO_SEC(TIMEDIFF(`CheckOutTime`,`CheckInTime`)))), `JobTitle`,`WorkHoursPerWeek`,`SalaryPerHour`, checkdate FROM `attendance` INNER JOIN employee ON attendance.EmployeeID = employee.EmployeeID INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE checkdate LIKE '%YEAR-MONTH%' group by contract.EmployeeID;";
        private string UNIQUE_ATENDANCE = "SELECT `EmployeeID` FROM `attendance`GROUP BY EmployeeID;";
        private string GET_EMPLOYEEID_WITH_CARD_CODE = "SELECT `EmployeeID` FROM `employee` WHERE `CardNumber`= @CardNumber;";
        private string IS_CHECKED_IN = "SELECT employeeID FROM `atendance` WHERE EmployeeID = @EmployeeID AND CheckDate = @CheckDate AND `CheckOutTime` IS NULL;";
        private string CREATE_CHECKIN = "INSERT INTO ATENDANCE(EmployeeID, CheckInTime, CheckOutTime, CheckDate) VALUES(@EmployeeID, @CheckInTime, @CheckOutTime, @CheckDate)";
        private string UPDATE_CHECKOUT = "UPDATE ATENDANCE SET CheckOutTime = @CheckOutTime WHERE CheckDate = @CheckDate AND EmployeeID = @EmployeeID AND `CheckOutTime` IS NULL ;";
        private string GET_ALL_ATENDANCE_CHECKIN = "SELECT `EmployeeID`,`CheckInTime`,`CheckOutTime`,`CheckDate` FROM `atendance` WHERE CheckDate = @CheckDate ORDER BY CheckOutTime DESC;";
        private string GET_ALL_ATENDANCE = "SELECT `EmployeeID`,`CheckInTime`,`CheckOutTime`,`CheckDate` FROM `attendance`;";


        public List<Checkin> getAllAtendance()
        {
            List<Checkin> checkin = new List<Checkin>();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_ATENDANCE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Checkin a;

                while (reader.Read())
                {
                    a = new Checkin(Convert.ToInt32(reader[0]), Convert.ToDateTime(reader[1]), Convert.ToDateTime(reader[2]), reader[3].ToString());
                    checkin.Add(a);
                }
                return checkin;
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
            return checkin;
        }

        public List<TimeWorked> getAllAtendanceTime(int year, int month)
        {
            List<TimeWorked> timeWorkeds = new List<TimeWorked>();

            MySqlConnection conn = Utils.GetConnection();

            string sql = "";

            if (month > 9)
            {
                sql = "SELECT employee.`EmployeeID`,`FirstName`,`LastName`, HOUR(SEC_TO_TIME(SUM(TIME_TO_SEC(TIMEDIFF(`CheckOutTime`,`CheckInTime`))))) AS HoursWorked, `JobTitle`,`WorkHoursPerWeek`,`SalaryPerHour`, checkdate  FROM `attendance` INNER JOIN employee ON attendance.EmployeeID = employee.EmployeeID INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE checkdate LIKE '" + year + "-" + month + "%'  AND employee.Active = 1 AND contract.Active = 1 group by contract.EmployeeID;";
            }
            else
            {
                sql = "SELECT employee.`EmployeeID`,`FirstName`,`LastName`, HOUR(SEC_TO_TIME(SUM(TIME_TO_SEC(TIMEDIFF(`CheckOutTime`,`CheckInTime`))))) AS HoursWorked, `JobTitle`,`WorkHoursPerWeek`,`SalaryPerHour`, checkdate  FROM `attendance` INNER JOIN employee ON attendance.EmployeeID = employee.EmployeeID INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE checkdate LIKE '" + year + "-0" + month + "%' AND employee.Active = 1 AND contract.Active = 1  group by contract.EmployeeID;";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                TimeWorked a;

                while (reader.Read())
                {
                    a = new TimeWorked(Convert.ToInt32(reader[0]), reader[3].ToString(), reader[1].ToString() + " " + reader[2].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());
                    timeWorkeds.Add(a);
                }

                return timeWorkeds;
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
            return timeWorkeds;
        }

        public DataTable getAtendanceData(int year, int month)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = "";

            if (month > 9)
            {
                sql = "SELECT employee.`EmployeeID`,`FirstName`,`LastName`, HOUR(SEC_TO_TIME(SUM(TIME_TO_SEC(TIMEDIFF(`CheckOutTime`,`CheckInTime`))))) AS HoursWorked, `JobTitle`,`WorkHoursPerWeek`,`SalaryPerHour`, checkdate  FROM `attendance` INNER JOIN employee ON attendance.EmployeeID = employee.EmployeeID INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE checkdate LIKE '" + year + "-" + month + "%' AND employee.Active = 1 AND contract.Active = 1  group by contract.EmployeeID;";
            }
            else
            {
                sql = "SELECT employee.`EmployeeID`,`FirstName`,`LastName`, HOUR(SEC_TO_TIME(SUM(TIME_TO_SEC(TIMEDIFF(`CheckOutTime`,`CheckInTime`))))) AS HoursWorked, `JobTitle`,`WorkHoursPerWeek`,`SalaryPerHour`, checkdate  FROM `attendance` INNER JOIN employee ON attendance.EmployeeID = employee.EmployeeID INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE checkdate LIKE '" + year + "-0" + month + "%' AND employee.Active = 1 AND contract.Active = 1  group by contract.EmployeeID;";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataAdapter reader = new MySqlDataAdapter(sql, conn);

                DataTable table = new DataTable();
                reader.Fill(table);

                return table;
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
            DataTable a = new DataTable();
            return a;
        }

        public List<TimeWorked> UniqueID()
        {
            List<TimeWorked> timeWorkeds = new List<TimeWorked>();

            MySqlConnection conn = Utils.GetConnection();

            string sql = UNIQUE_ATENDANCE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                TimeWorked a;

                while (reader.Read())
                {
                    a = new TimeWorked(Convert.ToInt32(reader[0]), "", "", "", "", "");
                    timeWorkeds.Add(a);
                }

                return timeWorkeds;
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
            return timeWorkeds;
        }

        public List<Checkin> getAllAtendanceOnCheckIn()
        {
            List<Checkin> checkins = new List<Checkin>();

            var date = DateTime.Now;
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_ATENDANCE_CHECKIN;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Checkin a;

                while (reader.Read())
                {
                    a = new Checkin(Convert.ToInt32(reader[0]), Convert.ToDateTime(reader[1]), Convert.ToDateTime(reader[2]), Convert.ToString(reader[3]));
                    checkins.Add(a);
                }
                return checkins;
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
            return checkins;
        }

        public int GetEmployeeID(string CardNumber)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_EMPLOYEEID_WITH_CARD_CODE;

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

        public bool IsAlreadyCheckedIn(int EmployeeID)
        {
            var date = DateTime.Now;
            MySqlConnection conn = Utils.GetConnection();
            string sql = IS_CHECKED_IN;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID.ToString());
                cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
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

        public void AddCheckIn(int EmployeeID)
        {
            var date = DateTime.Now;
            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_CHECKIN;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID.ToString());
                cmd.Parameters.AddWithValue("@CheckInTime", date.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@CheckOutTime", null);
                cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                conn.Open();
                int n = cmd.ExecuteNonQuery();
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

        public void EditCheckOutTime(int EmployeeID)
        {
            var date = DateTime.Now;
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_CHECKOUT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID.ToString());
                cmd.Parameters.AddWithValue("@CheckOutTime", date.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                conn.Open();
                int n = cmd.ExecuteNonQuery();
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
