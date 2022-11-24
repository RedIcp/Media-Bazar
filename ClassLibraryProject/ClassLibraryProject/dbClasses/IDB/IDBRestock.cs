using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IDB
{
    public interface IDBRestock
    {
        Product GetProduct(string barcode);
        List<Restock> GetRestockRequests();
        bool DeleteRestock(int id);
        bool OrderRestock(int id, OrderInfo orderInfo, int amount);
        bool RequestRestock(int id, Product product);
        bool ReceiveRestock(int id);
        bool ChangeAmount(Product product, int amount);
    }
}
