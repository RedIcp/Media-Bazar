using MySql.Data.MySqlClient;
using System;

namespace ClassLibrary1
{
    public class DatabaseConnection
    {


        public static string GET_EMPLOYEEID = " SELECT employeeID, password, userName FROM employee where UserName = @UserName";



        public static MySqlConnection GetConnected()
        {
            MySqlConnection conn =
      new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi461266;Database=dbi461266;Pwd=Lars123;SslMode =none;");
            return conn;
        }


        public bool IsEmployeeExist(Employee employee)
        {
            MySqlConnection conn = GetConnected();
            String CheckUserEXIST = "SELECT * FROM employee WHERE Username=?user AND Password = ?pass;";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(CheckUserEXIST, conn);

                cmd.Parameters.AddWithValue("pass", employee.Password);
                cmd.Parameters.AddWithValue("user", employee.Username);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                return false;
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
    }
}
