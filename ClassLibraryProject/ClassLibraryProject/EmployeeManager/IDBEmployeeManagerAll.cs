using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public interface IDBEmployeeManagerAll
    {
        public bool UpdateOwnInfo(Employee e);
        public List<Contract> GetEmployeeContracts(Employee e);
    }
}
