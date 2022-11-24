using ClassLibraryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses
{
  public class AsignShiftManagment : IAsignShiftManagment
    {
        IDbAsignShiftManagment dbAsignShift;
        public AsignShiftManagment(IDbAsignShiftManagment dbAsignShift)
        {
            this.dbAsignShift = dbAsignShift;
        }

        public bool AssignEmployeeShift(string sql)
        {
            return dbAsignShift.AssignEmployeeShift(sql);
        }

        public bool ScheduleAllEmployees(List<int> employees, int amountToSchedule, string shift, string day, int week, int year)
        {

            StringBuilder sql = new StringBuilder();
            if (employees.Count != 0)
            {
                sql.Append("Insert into`planning` (`Year`, `Week`, `Day`, `Shift`, EmployeeID ) VALUES ");

                for (int i = 0; i < employees.Count; i++)
                {
                    if (i == 0)
                    {
                        sql.Append($"({year},{week},'{day}','{shift}',{employees[i]})");
                    }
                    else
                    {
                        sql.Append($",({year},{week},'{day}','{shift}',{employees[i]})");
                    }

                }
                sql.Append(";");
                dbAsignShift.AssignEmployeeShift(sql.ToString());

                return true;
            }
            return true;
        }

        public bool ScheduleShift(List<int> employees, int amountToSchedule, string shift, string day, int week, int year)
        {
            if (amountToSchedule != 0) 
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into`planning` (`Year`, `Week`, `Day`, `Shift`, EmployeeID ) VALUES ");

                for (int i = 0; i < amountToSchedule; i++)
                {
                    if (i == 0)
                    {
                        sql.Append($"({year},{week},'{day}','{shift}',{employees[i]})");
                    }
                    else
                    {
                        sql.Append($",({year},{week},'{day}','{shift}',{employees[i]})");
                    }

                }
                sql.Append(";");
                AssignEmployeeShift(sql.ToString());

                return true;
            }
            return true;
        }
    }
}
