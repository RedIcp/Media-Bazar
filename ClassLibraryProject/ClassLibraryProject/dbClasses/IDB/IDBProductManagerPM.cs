using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public interface IDBProductManagerPM
    {
        public bool CreateProduct(Product p);
        public List<Product> ReadProductsPM();
        public bool UpdateProductPM(Product p);
        public List<Product> SearchProducts(string search);
        public Product GetProductByID(int productID);
    }
}
