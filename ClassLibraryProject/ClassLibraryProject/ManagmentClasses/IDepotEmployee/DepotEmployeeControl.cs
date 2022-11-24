using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IDepotEmployee
{
    public class DepotEmployeeControl: IDepotEmployeeControl
    {
        private IReshelfDepotEmployee reshelf;
        private IRestockDepotEmployee restock;

        public DepotEmployeeControl(IReshelfDepotEmployee reshelf, IRestockDepotEmployee restock )
        {
            this.reshelf = reshelf;
            this.restock = restock;
        }

        //reshelf
        public List<Reshelf> GetReshelfRequest()
        {
            return reshelf.GetReshelfRequests();
        }
        public bool CompleteReshelf(int id, Product product)
        {
            return reshelf.CompleteReshelf(id,product);
        }
        public bool DeleteReshelf(int id)
        {
            return reshelf.DeleteReshelf(id);
        }
        public bool CheckAmount(Product product, int amount)
        {
            return reshelf.CheckAmount(product, amount);
        }

        //restock
        public Product GetProduct(string barcode)
        {
            return restock.GetProduct(barcode);
        }
        public List<Restock> GetOrderedRestockRequests()
        {
            return restock.GetOrderedRestockRequests();
        }
        public bool RequestRestock(Product product)
        {
            return restock.RequestRestock(product);
        }
        public bool ReceiveRestock(int id, Product product)
        {
            return restock.ReceiveRestock(id, product);
        }
        public bool RestockExist(Product product)
        {
            return restock.RestockExist(product);
        }
    }
}
