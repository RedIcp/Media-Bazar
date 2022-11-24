using ClassLibraryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses
{
    public class AmountOfEmployeesNeededManagment : IAmountOfEmployeesNeededManagment
    {
       public IDbAmountOfEmployeesNeededManagment dbAmountOfEmployeesNeeded;
        public AmountOfEmployeesNeededManagment(IDbAmountOfEmployeesNeededManagment dbAmountOfEmployeesNeeded)
        {
            this.dbAmountOfEmployeesNeeded = dbAmountOfEmployeesNeeded;
        }

        public int AmountLeftToSchedule(string shift, string day, int week, int year, string department)
        {
            return dbAmountOfEmployeesNeeded.AmountLeftToSchedule(shift, day, week, year, department);
        }

        public int AmountOfEmployeesToSchedule(string shift, string day, int week, int year, string department)
        {
            return dbAmountOfEmployeesNeeded.AmountOfEmployeesToSchedule(shift, day, week, year, department);
        }
    }
}
