using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IDB
{
    public interface IDBReshelf
    {
        Product GetProduct(string barcode);
        List<Reshelf> GetReshelfRequests();
        bool RequestReshelf(int id, Product product, int amount);
        bool DeleteReshelf(int id);
        bool CompleteReshelf(int id);
        bool ChangeAmountDepot(Product product, int amount);
        bool ChangeAmountStore(Product product, int amount);
    }
}
