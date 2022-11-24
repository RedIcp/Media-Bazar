using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Interfaces
{
    public interface IDbEmployeesAvailibleManagment
    {
        public List<int> EmployeesAvailible(string sql);
    }
}
