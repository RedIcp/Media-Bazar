using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public interface IEmployeeManagerAll
    {
        public bool UpdateOwnInfo(Employee e);
        public List<Contract> GetEmployeeContracts(Employee e);
    }
}
