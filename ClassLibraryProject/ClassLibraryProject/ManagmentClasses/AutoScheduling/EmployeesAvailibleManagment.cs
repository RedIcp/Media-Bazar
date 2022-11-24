using ClassLibraryProject.Enum;
using ClassLibraryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses
{
   public class EmployeesAvailibleManagment : IEmployeesAvailibleManagment
    {
        public IDbEmployeesAvailibleManagment dbEmployeesAvailible;
        public EmployeesAvailibleManagment(IDbEmployeesAvailibleManagment dbEmployeesAvailible)
        {
            this.dbEmployeesAvailible = dbEmployeesAvailible;
        }

        public List<int> EmployeesAvailible(Shifts shift, Days day, int week, int year, string department, Prefrance prefrance)
        {
            StringBuilder sql = new StringBuilder();


            //SELECT // FROM // JOIN
            sql.Append(" SELECT employee.EmployeeID, contract.WorkHoursPerWeek, contract.WorkHoursPerWeek - COUNT(planning.EmployeeID) * 4 FROM `employee` INNER JOIN contract ON  contract.EmployeeID = Employee.EmployeeID LEFT JOIN planning ON Employee.EmployeeID = planning.EmployeeID WHERE ");

            for (int i = 0; i < 2; i++)
            {
                //WHERE
                sql.Append($" employee.Active = 1 AND contract.Active = 1 AND contract.Department = '{department}' AND contract.JobTitle NOT LIKE '%Manager%' ");

                //IN and NOT IN 
                sql.Append($" AND (employee.EmployeeID) NOT IN(SELECT EmployeeID FROM availability WHERE year = {year} AND WEEK = {week} AND Day = '{day}') AND (employee.EmployeeID, contract.WorkHoursPerWeek) NOT IN(SELECT EmployeeID, COUNT(EmployeeID)*4 FROM planning WHERE year = {year} AND week = {week} GROUP by EmployeeID) ");

                if (shift == Shifts.Evening)
                {
                    //Check if already working in morning
                    sql.Append($"  AND (employee.EmployeeID) NOT IN(SELECT EmployeeID FROM planning WHERE year = {year} AND week = {week} AND day = '{day}' AND shift = 'Morning') ");
                }

                //Check if already working in morning
                if (prefrance == Prefrance.Prefered)
                {
                    sql.Append($" AND (employee.EmployeeID) IN (SELECT employeeID FROM preferedTime WHERE day = '{day}' AND shift = '{shift}' AND prefered = 0 ) ");
                }
                else if (prefrance == Prefrance.No_Prefrance)
                {
                    sql.Append($" AND (employee.EmployeeID) NOT IN (SELECT EmployeeID FROM preferedTime WHERE day = '{day}' AND shift = '{shift}' )");
                }
                else if (prefrance == Prefrance.Not_Prefered)
                {
                    sql.Append($" AND (employee.EmployeeID) IN (SELECT EmployeeID FROM preferedTime WHERE day = '{day}' AND shift = '{shift}' AND prefered = 0 )");
                }


                if (i == 0)
                {
                    sql.Append($" AND planning.Year = '{year}' AND planning.Week = '{week}'  OR ");
                }
            }



            //GROUP BY and ORDER BY
            sql.Append(" GROUP BY employee.EmployeeID ORDER BY contract.WorkHoursPerWeek - COUNT(planning.EmployeeID) * 4 DESC;");

            return dbEmployeesAvailible.EmployeesAvailible(sql.ToString());
        }
    }
}
