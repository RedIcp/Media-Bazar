using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace CardReader
{
    class Atendance
    {
        public List<Ckecks> check;
        public string GET_EMPLOYEEID_WITH_CARD_CODE = "SELECT `EmployeeID` FROM `employee` WHERE `CardNumber`= @CardNumber LIMIT 1;";
        public string IS_CHECKED_IN = "SELECT employeeID FROM `attendance` WHERE EmployeeID = @EmployeeID AND CheckDate = @CheckDate AND `CheckOutTime` IS NULL;";
        public string CREATE_CHECKIN = "INSERT INTO ATtENDANCE(EmployeeID, CheckInTime, CheckOutTime, CheckDate) VALUES(@EmployeeID, @CheckInTime, @CheckOutTime, @CheckDate)";
        public string UPDATE_CHECKOUT = "UPDATE ATtENDANCE SET CheckOutTime = @CheckOutTime WHERE CheckDate = @CheckDate AND EmployeeID = @EmployeeID AND `CheckOutTime` IS NULL ;";
        public string GET_ALL_ATENDANCE_CHECKIN = "SELECT `EmployeeID`,`CheckInTime`,`CheckOutTime`,`CheckDate` FROM `attendance` WHERE CheckDate = @CheckDate order by `Check` desc LIMIT 25;";

        public Atendance()
        {
            check = new List<Ckecks>();
        }

        public void getAllAtendanceOnCheckIn()
        {
            check.Clear();
            DateTime date = DateTime.Now;
            MySqlConnection conn = Connection.GetConnection();

            string sql = GET_ALL_ATENDANCE_CHECKIN;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Ckecks a;

                while (reader.Read())
                {
                    if (reader[2].ToString() == "")
                    {
                        a = new Ckecks(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), "");
                        check.Add(a);
                    }
                    else
                    {
                        a = new Ckecks(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), Convert.ToDateTime(reader[2].ToString()).Subtract(Convert.ToDateTime(reader[1].ToString())).ToString());
                        check.Add(a);
                    }
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Make sure to Use the provided vpn");
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
            MySqlConnection conn = Connection.GetConnection();
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
            MySqlConnection conn = Connection.GetConnection();
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
            MySqlConnection conn = Connection.GetConnection();
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
