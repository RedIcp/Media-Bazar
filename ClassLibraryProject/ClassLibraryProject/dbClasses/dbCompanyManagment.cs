using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;

namespace ClassLibraryProject.dbClasses
{
   public class dbCompanyManagment : ICompanyManagment
    {
        private string GET_COMPANY = " SELECT Employee.EmployeeID, CompanyName, company.Address, company.Email, KVK, btw, company.PhoneNumber, company.CompanyID FROM `EMPLOYEE` INNER JOIN contract ON employee.EmployeeID = contract.EmployeeID INNER JOIN  jobs ON jobs.JobTitle = contract.JobTitle INNER JOIN departments ON departments.DepartmentID = jobs.DepartmentID INNER JOIN company ON company.CompanyID = departments.CompanyID HAVING employee.EmployeeID = @EmployeeID;";
        private string Edit_COMPANY = "UPDATE company SET CompanyName = @CompanyName, Address = @Address, Email = @Email, KVK = @KVK, btw = @btw , PhoneNumber = @PhoneNumber WHERE CompanyID = @CompanyID;";

        public Company GetCompany(int userID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_COMPANY;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@EmployeeID", userID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Company Company;

                while (reader.Read())
                {
                    Company = new Company(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString());

                    return Company;
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
            return null;
        }

        public void EditCompany(string name, string address, string phoneNumber, string email, string btw, string kvk, string id)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = Edit_COMPANY;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CompanyName", name);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@KVK", kvk);
                cmd.Parameters.AddWithValue("@btw", btw);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@CompanyID", id);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
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
