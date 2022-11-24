using MySql.Data.MySqlClient;
using System;
using System.Data;
using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using System.Diagnostics;

namespace ClassLibraryProject.dbClasses
{
  public class dbDepartmentManagment : IDepartmentManagment
    {
        private string GET_DEPARTMENTS = "SELECT `DepartmentID` , `HeadDepatment`,`DepartmentName` FROM `departments`;";
        private string ADD_DEPARTMENT = "INSERT INTO departments ( DepartmentName, CompanyID, HeadDepatment) VALUES (@DepartmentName, @CompanyID, @HeadDepatment);";
        private string EDIT_DEPARTMENT = "UPDATE departments SET DepartmentName = @DepartmentName, HeadDepatment = @HeadDepatment WHERE DepartmentID = @DepartmentID;";
        private string DELETE_DEPARTMENT = "DELETE FROM departments WHERE DepartmentID = @ID;";
        private string MOVE_EMPLOYEES_TO_HEAD_DEPARTMENT = "UPDATE contract SET Department = @HeadDepartment WHERE Department = @Department;";
        private string GET_HEAD_DEPARTMENT = "select  `HeadDepatment`,`DepartmentName` FROM `departments` WHERE DepartmentID = @ID;";
        private string GET_DEPARTMENTNAME = "SELECT `DepartmentName` FROM `departments` WHERE `DepartmentID` = @ID;";
        private string UPDATE_EMPLOYEES_DEPARTMENT = "UPDATE Contract SET Department = @NewDepartmentName WHERE Department = @OldDepartmentName;";

        public DataTable ViewAllDepartments()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_DEPARTMENTS;

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

        public void AddDepartment(string Name, string Head, string CompanyID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = ADD_DEPARTMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@DepartmentName", Name);
                cmd.Parameters.AddWithValue("@HeadDepatment", Head);
                cmd.Parameters.AddWithValue("@CompanyID", CompanyID);


                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

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

        public int EditDepartment(string Name, string Head, string DepartmetnID)
        {

          int result =  UpdateEmployeeInfo(GetDepartmentName( Convert.ToInt32(DepartmetnID)), Name);

            UpdateScheduleInfo(GetDepartmentName(Convert.ToInt32(DepartmetnID)), Name);

            MySqlConnection conn = Utils.GetConnection();
            string sql = EDIT_DEPARTMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@DepartmentName", Name);
                cmd.Parameters.AddWithValue("@HeadDepatment", Head);
                cmd.Parameters.AddWithValue("@DepartmentID", DepartmetnID);


                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                return result;
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

        public int DeleteDepartment(int departmentID)
        {
           int result = MoveEmployeesToHeadDepartment(departmentID);

            MySqlConnection conn = Utils.GetConnection();

            string sql = DELETE_DEPARTMENT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", departmentID);
                conn.Open();
                cmd.ExecuteNonQuery();

                return result;
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

        private int MoveEmployeesToHeadDepartment(int departmentID)
        {
            string HeadDepartment = "";
            string Department = "";

            MySqlConnection conn = Utils.GetConnection();
            
            string sql = GET_HEAD_DEPARTMENT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", departmentID);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    HeadDepartment = reader[0].ToString();
                    Department = reader[1].ToString();
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

            if (HeadDepartment == "")
            {
                return 0;
            }

            sql = MOVE_EMPLOYEES_TO_HEAD_DEPARTMENT;
           
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@HeadDepartment", HeadDepartment);
                cmd.Parameters.AddWithValue("@Department", Department);

                conn.Open();

               int amountOfEmployeesReasigned = cmd.ExecuteNonQuery();

                return amountOfEmployeesReasigned;
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

        private string GetDepartmentName(int departmentID)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_DEPARTMENTNAME;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", departmentID);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return reader[0].ToString();
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
                return "";
        }

        private int UpdateEmployeeInfo(string OldDepartmentName, string NewDepartmentName)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = $"UPDATE Contract SET Department = '{NewDepartmentName}' WHERE Department = '{OldDepartmentName}' ;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int AmountAfacted =  cmd.ExecuteNonQuery();

                return AmountAfacted; 

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

        private int UpdateScheduleInfo(string OldDepartmentName, string NewDepartmentName)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = $"UPDATE schedule SET Department = '{NewDepartmentName}' WHERE Department = '{OldDepartmentName}' ;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int AmountAfacted = cmd.ExecuteNonQuery();

                return AmountAfacted;

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
    }
}
