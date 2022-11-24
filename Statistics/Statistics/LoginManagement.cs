using MySql.Data.MySqlClient;
using System;

namespace Statistics
{
    class LoginManagement
    {
        public string LOGIN_BY_EMPLOYEEID = " SELECT employee.userName, password, contract.JobTitle FROM employee INNER JOIN contract ON contract.employeeID = employee.Employeeid where employee.UserName = @UserName order by startdate;";
        public string GET_EMPLOYEEID = " SELECT employeeID, password, userName FROM employee where UserName = @UserName";


        public string checkLogin(string UserName, string Password)
        {

            MySqlConnection conn = Utils.GetConnection();
            string sql = LOGIN_BY_EMPLOYEEID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UserName", UserName);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0].ToString() == (UserName).ToString() && reader[1].ToString() == Password)
                    {
                        if (reader[2].ToString() == "CEO")
                        {
                            return reader[2].ToString();
                        }
                    }
                }
                return "Wrong info!";
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
            return "";
        }

        public int GetID(string UserName, string Password)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_EMPLOYEEID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UserName", UserName);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[2].ToString() == UserName.ToString() && reader[1].ToString() == Password.ToString())
                    {
                        return Convert.ToInt32(reader[0]);
                    }
                }
                return 0;
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
            return 0;
        }
    }
}
