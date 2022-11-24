using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.ManagmentClasses.IDepotEmployee;
using ClassLibraryProject.ManagmentClasses.IDepotManager;
using System;
using System.Collections.Generic;

namespace ClassLibraryProject.ManagmentClasses
{
    public class RestockManagment: IRestockDepotManager, IRestockDepotEmployee 
    {
        private List<int> numbers = new List<int>();
        public int id()
        {
            int n = 1;
            Random random = new Random();
            for (int i = 1000; i < 9999; i++)
            {
                numbers.Add(i);
            }
            foreach (int i in numbers)
            {
                n = random.Next(numbers.Count);
                if (i == numbers[n])
                {
                    return i;
                }
            }
            return n;
        }

        private IDBRestock db;

        public RestockManagment(IDBRestock dbRestock)
        {
            db = dbRestock;
        }

        //manager
        public bool OrderRestock(int id, OrderInfo orderInfo, int amount)
        {
            if (RestockByIDExist(id))
            {
                if(IsValid(orderInfo, amount) == true)
                {
                    if (db.OrderRestock(id, orderInfo, amount) == true)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }
        public List<Restock> GetRestockRequests()
        {
            return db.GetRestockRequests();
        }
        public bool DeleteRestock(int id)
        {
            if (RestockByIDExist(id))
            {
                if (db.DeleteRestock(id) == true)
                {
                    db.GetRestockRequests().Remove(GetRestockByID(id));
                    return true;
                }
                return false;
            }
            return false;
        }

        //employee
        public Product GetProduct(string barcode)
        {
            return db.GetProduct(barcode);
        }
        public List<Restock> GetOrderedRestockRequests()
        {
            List<Restock> restocks = new List<Restock>();

            foreach(Restock restock in db.GetRestockRequests())
            {
                if(restock.Status == "Ordered")
                {
                    restocks.Add(restock);
                }
            }
            return restocks;
        }    
        public bool RequestRestock(Product product)
        {
            if (!RestockExist(product))
            {
                if (db.RequestRestock(id(), product) == true)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool ReceiveRestock(int id, Product product)
        {
            if (RestockExist(product))
            {
                if (db.ReceiveRestock(id) == true)
                {
                    int newAmount = product.AmountInDepot + GetRestockByID(id).AmountRequested;
                    db.ChangeAmount(product, newAmount);
                    return true;
                }
                return false;
            }
            return false;
        }

        //check
        public bool IsValid(OrderInfo orderInfo, int amount)
        {
            if(amount % orderInfo.Multiples == 0 && amount <= orderInfo.MaxAmount && amount >= orderInfo.MinAmount)
            {
                return true;
            }
            return false;
        }
        private Restock GetRestock(Product product)
        {
            foreach(Restock restock in db.GetRestockRequests())
            {
                if(restock.Product == product && (restock.Status == "Pending" || restock.Status == "Ordered"))
                {
                    return restock;
                }
            }
            return null;
        }
        public Restock GetRestockByID(int id)
        {
            foreach (Restock restock in db.GetRestockRequests())
            {
                if (restock.ID == id)
                {
                    return restock;
                }
            }
            return null;
        }
        public bool RestockExist(Product product)
        {
            if (GetRestock(product) != null)
            {
                return true;
            }
            return false;
        }
        private bool RestockByIDExist(int id)
        {
            if (GetRestockByID(id) != null)
            {
                return true;
            }
            return false;
        }  
    }
}
