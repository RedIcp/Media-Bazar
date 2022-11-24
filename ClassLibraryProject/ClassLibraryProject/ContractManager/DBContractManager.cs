using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace ClassLibraryProject
{
    public class DBContractManager : IDBContractManager
    {
        // sql
        public static string CREATE_CONTRACT = "INSERT INTO Contract (EmployeeID, JobTitle, WorkHoursPerWeek, SalaryPerHour, StartDate, EndDate, Department, Active) VALUES (@EmployeeID, @JobTitle, @WorkHoursPerWeek, @SalaryPerHour, @StartDate, @EndDate, @Department, @Active);";
        public static string READ_CONTRACT = "SELECT * FROM Contract WHERE EmployeeID = @EmployeeID AND Active = @Active;";
        public static string UPDATE_CONTRACT = "UPDATE Contract SET Active = @Active, ReasonForTermination = @ReasonForTermination, EndDate = @EndDate WHERE ContractID = @ContractID;";

        public bool CreateContract(Contract c)
        {
            /* Regex */
            if (c.WorkHoursPerWeek % 4 != 0)
            {
                return false;
            }
            if (c.WorkHoursPerWeek == 0)
            {
                return false;
            }
            if (!Regex.IsMatch(c.StartDate.ToString("dd/MM/yyyy"), @"((?:0[0-9])|(?:[1-2][0-9])|(?:3[0-1]))\/((?:0[1-9])|(?:1[0-2]))\/(\d{4})"))
            {
                return false;
            }
            if (c.StartDate < DateTime.Now)
            {
                return false;
            }
            if (!Regex.IsMatch(c.EndDate.ToString("dd/MM/yyyy"), @"((?:0[0-9])|(?:[1-2][0-9])|(?:3[0-1]))\/((?:0[1-9])|(?:1[0-2]))\/(\d{4})"))
            {
                return false;
            }
            if (c.StartDate > c.EndDate)
            {
                return false;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_CONTRACT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@EmployeeID", c.Employee.EmployeeID);
                cmd.Parameters.AddWithValue("@WorkHoursPerWeek", c.WorkHoursPerWeek);
                cmd.Parameters.AddWithValue("@SalaryPerHour", c.SalaryPerHour);
                cmd.Parameters.AddWithValue("@StartDate", c.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", c.EndDate);
                cmd.Parameters.AddWithValue("@Department", c.Department);
                cmd.Parameters.AddWithValue("@Active", 1);
                cmd.Parameters.AddWithValue("@JobTitle", c.JobTitle);


                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows == 1)
                { return true; }
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

        public Contract ReadContract(Employee e)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = $"SELECT * FROM Contract WHERE EmployeeID = {e.EmployeeID} AND Active = 1;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Contract contract;

                while (reader.Read())
                {
                    int contractID = reader.GetInt32(0);
                    string jobTitle = reader.GetString(2);
                    int workHoursPerWeek = reader.GetInt32(3);
                    double salaryPerHour = reader.GetDouble(4);
                    DateTime startDate = reader.GetDateTime(5);

                    DateTime endDate = DateTime.Now;

                    string department = reader.GetString(8);
                    bool isActive = reader.GetBoolean(9);

                    contract = new Contract(contractID, e, jobTitle, workHoursPerWeek, salaryPerHour, startDate, endDate, department, isActive);
                    return contract;
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

        public bool UpdateContract(Contract c)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_CONTRACT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ContractID", c.ContractID);
                cmd.Parameters.AddWithValue("@Active", c.IsActive);
                cmd.Parameters.AddWithValue("@ReasonForTermination", c.ReasonForTermination);
                cmd.Parameters.AddWithValue("@EndDate", c.EndDate);

                cmd.ExecuteNonQuery();
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

            return true;
        }
    }
}
