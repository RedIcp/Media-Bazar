using MySql.Data.MySqlClient;

namespace ClassLibraryProject.Class
{
    public class Utils
    {
        public static string LOGIN_BY_EMPLOYEEID = " SELECT employee.employeeID, password, `contract`.`JobTitle` FROM employee INNER JOIN contract ON contract.employeeID = employee.Employeeid where employee.employeeid = @employeeid order by startdate;";


        //Planing
  
        public static string MAKE_EMPTY_SCHEDULE = "SELECT Department, Day, Morning , Afternoon, Evening FROM `schedule`;";
        public static string CREATE_SCHDULEDWORK = "INSERT INTO schduledwork (Department, EmployeeID, Day, Time) VALUE ( @depratment , @EmployeeID , @Day , @Time);";

        public static string CLEAR_PLAN = "DELETE FROM schduledwork;";

        //check
        public static string CREATE_CHECKIN = "INSERT INTO ATENDANCE(EmployeeID, CheckInTime, CheckOutTime, CheckDate) VALUES(@ID, @CheckInTime, @CheckOutTime, @CheckDate)";
        public static string CREATE_CHECKOUT = "UPDATE ATENDANCE SET CheckOutTime = @CheckOutTime WHERE CheckDate = @CheckDate && EmployeeID = @ID;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn =
            new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi461266;Database=dbi461266;Pwd=Lars123;SslMode =none;");
            return conn;
        }
    }
}
