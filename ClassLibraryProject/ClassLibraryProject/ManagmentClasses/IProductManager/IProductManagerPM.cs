using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public interface IProductManagerPM
    {
        public bool CreateProduct(Product p);
        public List<Product> ReadProductsPM();
        public bool UpdateProductPM(Product p);
        public List<Product> SearchProductsPM(string search);
        public Product GetProductByID(int productID);
    }
}
