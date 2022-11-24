using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public class ContractManager : IContractManager
    {
        IDBContractManager DBContractManager { get; set; }

        public ContractManager()
        {
            DBContractManager = new DBContractManager();
        }
        public bool CreateContract(Contract c)
        {
            return DBContractManager.CreateContract(c);
        }

        public Contract ReadContract(Employee e)
        {
            return DBContractManager.ReadContract(e);
        }

        public bool UpdateContract(Contract c)
        {
            return DBContractManager.UpdateContract(c);
        }
    }
}
