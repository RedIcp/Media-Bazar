using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IDB
{
    public interface IDBPreferredShift
    {
        List<Employee> GetEmployees();
        List<PreferredShift> GetPreferredShifts();
        bool PreferAShift(string day, string shift, Employee employee, bool isPreferred);
        bool UpdatePreferredShift(string day, string shift, Employee employee, bool isPreferred);
        bool DeletePreferredShift(string day, string shift, Employee employee);
        PreferredShift GetPreferredShift(string day, string shift);
    }
}
