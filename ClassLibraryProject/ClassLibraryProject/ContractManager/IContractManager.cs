using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public interface IContractManager
    {
        public bool CreateContract(Contract c);
        public Contract ReadContract(Employee e);
        public bool UpdateContract(Contract c);
    }
}
