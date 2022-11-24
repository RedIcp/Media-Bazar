using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IDepotEmployee
{
    public interface IDepotEmployeeControl
    {
        //reshelf
        List<Reshelf> GetReshelfRequest();
        bool CompleteReshelf(int id, Product product);
        bool DeleteReshelf(int id);
        bool CheckAmount(Product product, int amount);

        //restock
        List<Restock> GetOrderedRestockRequests();
        Product GetProduct(string barcode);
        bool RequestRestock(Product product);
        bool ReceiveRestock(int id, Product product);
        bool RestockExist(Product product);
    }
}
