using System.Collections.Generic;

namespace ClassLibraryProject.Class
{
    public class Supplier
    {
        //fields
        private int id;
        private string name;
        private string country;
        private int buildingNumber;
        private string postalCode;
        private string email;
        private string phoneNumber;
        private string bankNumber;
        private string productType;
        private List<OrderInfo> orderInfos;

        //properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BuildingNumber { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BankNumber { get; set; }
        public string ProductType { get; set; }
        public List<OrderInfo> OrderInfos { get; set; }

        //constructor
        public Supplier(string name, string country, int buildingNumber, string postalCode, string email, string phoneNumber, string bankNumber, string productType)
        {
            this.Name = name;
            this.Country = country;
            this.BuildingNumber = buildingNumber;
            this.PostalCode = postalCode;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.BankNumber = bankNumber;
            this.ProductType = productType;

            OrderInfos = new List<OrderInfo>();
        }
        public Supplier(int id, string name, string country, int buildingNumber, string postalCode, string email, string phoneNumber, string bankNumber, string productType)
        {
            ID = id;
            Name = name;
            Country = country;
            BuildingNumber = buildingNumber;
            PostalCode = postalCode;
            Email = email;
            PhoneNumber = phoneNumber;
            BankNumber = bankNumber;
            this.ProductType = productType;
            OrderInfos = new List<OrderInfo>();
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}

