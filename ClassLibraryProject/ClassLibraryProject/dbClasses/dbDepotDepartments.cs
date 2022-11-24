﻿using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ClassLibraryProject.dbClasses
{
    class dbDepotDepartments : IDBViewAllDepartments
    {
        private string GET_DEPOT_DEPARTMENTS = "SELECT `DepartmentID`,`HeadDepatment`,`DepartmentName` FROM `departments` WHERE `DepartmentID`> 4 AND HeadDepatment = 'depot';";
        public List<Department> ViewAllDepartments()
        {
            List<Department> departments = new List<Department>();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_DEPOT_DEPARTMENTS; 

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Department d;
                while (reader.Read())
                {
                    d = new Department(
                     reader[0].ToString(),
                     reader[1].ToString(),
                     reader[2].ToString()
                    );

                    departments.Add(d);
                }
            }
            catch (MySqlException a)
            { Debug.WriteLine(a.Message); }
            catch (Exception a)
            { Debug.WriteLine(a.Message); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return departments;
        }
    }
}
