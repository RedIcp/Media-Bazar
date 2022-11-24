using ClassLibraryProject.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Interfaces
{
    public interface IEmployeesAvailibleManagment
    {
        public List<int> EmployeesAvailible(Shifts shift, Days day, int week, int year, string department, Prefrance prefrance);
    }
}
