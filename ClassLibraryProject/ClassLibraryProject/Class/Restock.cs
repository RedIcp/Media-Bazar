
namespace ClassLibraryProject.Class
{
    public class Restock
    {
        //fields
        private int id;
        private Product product;
        private int amountRequested;
        private string status;
        private OrderInfo orderInfo;

        //properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
        public int AmountRequested
        {
            get { return amountRequested; }
            set { amountRequested = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public OrderInfo OrderInfo
        {
            get { return orderInfo; }
            set { orderInfo = value; }
        }

        //constructors
        public Restock(int id, Product product, OrderInfo orderInfo, int amountRequested, string status)
        {
            ID = id;
            Product = product;
            OrderInfo = orderInfo;
            AmountRequested = amountRequested;
            Status = status;
        }
        public Restock(int id, Product product)
        {
            ID = id;
            Product = product;
            Status = "Pending";
        }

        public override string ToString()
        {
            return Status;
        }
    }
}
