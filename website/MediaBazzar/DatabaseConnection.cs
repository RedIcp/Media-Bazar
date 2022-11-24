using MySql.Data.MySqlClient;

namespace ClassLibrary1
{
    class DatabaseConnection
    {
        public static string GET_EMPLOYEEID = " SELECT employeeID, password, userName FROM employee where UserName = @UserName";

        public MySqlConnection GetConnected()
        {
            MySqlConnection conn =
                 new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi461266;Database=dbi461266;Pwd=Lars123;SslMode =none;"); 
            return conn;
        }
    }
}
