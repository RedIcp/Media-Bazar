using MySql.Data.MySqlClient;

namespace CardReader
{
    class Connection
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn =
      new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi461266;Database=dbi461266;Pwd=Lars123;SslMode =none;");
            return conn;
        }
    }
}
