using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public interface IProductManagerSM
    {
        public List<Product> ReadProductsSM();
        public List<Product> ReadNewProductsSM();
        public bool UpdateProductSM(Product p);
        public List<Product> SearchProductsPM(string search);
        public Product GetProductByID(int productID);
    }
}
