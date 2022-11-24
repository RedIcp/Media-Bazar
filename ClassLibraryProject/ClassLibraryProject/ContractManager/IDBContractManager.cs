using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public interface IDBContractManager
    {
        public bool CreateContract(Contract c);
        public Contract ReadContract(Employee e);
        public bool UpdateContract(Contract c);
    }
}
