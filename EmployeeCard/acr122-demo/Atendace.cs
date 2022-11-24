using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acr122_demo
{
   public  class Atendace
    {
        public static string GET_EMPLOYEEID_WITH_CARD_CODE = "SELECT `EmployeeID` FROM `employee` WHERE `CardNumber`= @CardNumber;";
        public static string IS_CHECKED_IN = "SELECT * FROM `atendance` WHERE EmployeeID = @EmployeeID AND CheckDate = @DateTime.now AND `CheckOutTime` IS NULL;";


        public int GetEmployeeID( string CardNumber)
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
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }

        public bool IsAlreadyCheckedIn()
        {
            return true;
        }

        public void AddCheckIn()
        { 

        }

        public void EditCheckOutTime()
        { 

        }

    }
}
