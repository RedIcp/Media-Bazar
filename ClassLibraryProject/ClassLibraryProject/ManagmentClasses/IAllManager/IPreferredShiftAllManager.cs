using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IAllManager
{
    public interface IPreferredShiftAllManager
    {
        List<Employee> EmployeesWithNoPreferrence(string day, string shift);
        PreferredShift GetPreferredShift(string day, string shift);
    }
}
