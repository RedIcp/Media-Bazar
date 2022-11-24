
namespace ClassLibraryProject.Class
{
    public class Reshelf
    {
        //fields
        private int id;
        private Product product;
        private int amountRequested;
        private string status;

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

        //constructors
        public Reshelf(int id, Product product, int amountRequested, string status)
        {
            ID = id;
            Product = product;
            AmountRequested = amountRequested;
            Status = status;
        }
        public Reshelf(int id, Product product, int amountRequested)
        {
            ID = id;
            Product = product;
            AmountRequested = amountRequested;
            Status = "Pending";
        }

        public override string ToString()
        {
            return Status;
        }
    }
}
