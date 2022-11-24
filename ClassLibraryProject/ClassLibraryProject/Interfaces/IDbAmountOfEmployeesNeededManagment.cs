using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Interfaces
{
    public interface IDbAmountOfEmployeesNeededManagment
    {
        public int AmountOfEmployeesToSchedule(string shift, string day, int week, int year, string department);
        public int AmountLeftToSchedule(string shift, string day, int week, int year, string department);

    }
}
