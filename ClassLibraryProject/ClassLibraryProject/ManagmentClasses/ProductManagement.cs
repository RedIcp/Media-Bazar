using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.dbClasses.IGetObject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace ClassLibraryProject.ManagmentClasses
{
    public class ProductManagement : IGetProduct, IProductManagerPM, IProductManagerSM
    {
        public IDBProductManagerPM DBProductManagerPM { get; set; }
        public IDBProductManagerSM DBProductManagerSM { get; set; }

        public ProductManagement()
        {
            this.DBProductManagerPM = new DBProductManager();
            this.DBProductManagerSM = new DBProductManager();
        }
        /* Esther Start */
        /* Product Manager */
        public bool CreateProduct(Product p)
        {
            return DBProductManagerPM.CreateProduct(p);
        }

        public List<Product> ReadProductsPM()
        {
            return DBProductManagerPM.ReadProductsPM();
        }

        public List<Product> SearchProductsPM(string search)
        {
            return DBProductManagerPM.SearchProducts(search);
        }

        public bool UpdateProductPM(Product p)
        {
            return DBProductManagerPM.UpdateProductPM(p);
        }
        /* Sales Manager */
        public List<Product> ReadProductsSM()
        {
            return DBProductManagerSM.ReadProductsSM();
        }
        public List<Product> ReadNewProductsSM()
        {
            return DBProductManagerSM.ReadNewProductsSM();
        }
        public bool UpdateProductSM(Product p)
        {
            return DBProductManagerSM.UpdateProductSM(p);
        }
        /* Esther End */


        public Product GetProduct(string barcode)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByID(int productID)
        {
            return DBProductManagerPM.GetProductByID(productID);
        }
    }
}
