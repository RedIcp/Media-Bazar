
using System.Collections.Generic;

namespace ClassLibraryProject.Class
{
    public class Product
    {
        //fields
        private int productID;
        private string productName;
        private string barcode;
        private string productType;
        private double sellingPrice;
        private int amountInDepot;
        private int amountInStore;
        private bool isDiscontinued;

        private List<OrderInfo> orderInfos;

        //properties
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public string ProductType { get; set; }
        public double SellingPrice { get; set; }
        public int AmountInDepot { get; set; }
        public int AmountInStore { get; set; }
        public bool IsDiscontinued { get; set; }

        public List<OrderInfo> OrderInfos { get; set; }

        //constructor
        // for creating the product
        public Product(string name, string type, string barcode)
        {
            Barcode = barcode;
            ProductName = name;
            ProductType = type;
            AmountInDepot = 0;
            AmountInStore = 0;
            sellingPrice = 0;
            IsDiscontinued = false;

            OrderInfos = new List<OrderInfo>();
        }
        // for reading the product
        public Product(int id, string name, string barcode, string type, double sellingPrice, int amountInDepot, int amountInStore, bool isDiscontinued) 
        {
            ProductID = id;
            Barcode = barcode;
            ProductName = name;
            ProductType = type;
            AmountInDepot = amountInDepot;
            AmountInStore = amountInStore;
            SellingPrice = sellingPrice;
            IsDiscontinued = isDiscontinued;

            OrderInfos = new List<OrderInfo>();
        }
        public override string ToString()
        {
            return Barcode;
        }
    }
}
