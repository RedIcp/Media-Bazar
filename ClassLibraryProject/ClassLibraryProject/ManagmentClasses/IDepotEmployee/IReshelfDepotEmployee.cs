using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IDepotEmployee
{
    public interface IReshelfDepotEmployee
    {
        Product GetProduct(string barcode);
        List<Reshelf> GetReshelfRequests();
        bool CompleteReshelf(int id, Product product);
        bool DeleteReshelf(int id);
        bool CheckAmount(Product product, int amount);
    }
}
