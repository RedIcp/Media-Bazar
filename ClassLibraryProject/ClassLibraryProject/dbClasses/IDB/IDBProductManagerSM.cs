using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public interface IDBProductManagerSM
    {
        public List<Product> ReadProductsSM();
        public List<Product> ReadNewProductsSM();
        public bool UpdateProductSM(Product p);
        public List<Product> SearchProducts(string search);
        public Product GetProductByID(int productID);
    }
}
