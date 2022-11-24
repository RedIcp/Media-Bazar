using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IDepotManager
{
    public interface IRestockDepotManager
    {
        public Restock GetRestockByID(int id);
        List<Restock> GetRestockRequests();
        bool OrderRestock(int id, OrderInfo orderInfo, int amount);
        bool DeleteRestock(int id);
        bool IsValid(OrderInfo orderInfo, int amount);
    }
}
