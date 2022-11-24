namespace ClassLibraryProject.Class
{
    public class OrderInfo
    {
        //fields
        private int id;
        private Supplier supplier;
        private Product product;
        private int minAmount;
        private int maxAmount;
        private int multiples;
        private double purchasePrice;

        //properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public Supplier Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
        public int MinAmount
        {
            get { return minAmount; }
            set { minAmount = value; }
        }
        public int MaxAmount
        {
            get { return maxAmount; }
            set { maxAmount = value; }
        }
        public int Multiples
        {
            get { return multiples; }
            set { multiples = value; }
        }
        public double PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }
        //constructor
        public OrderInfo(Supplier supplier, Product product, int minAmount, int maxAmount, int multiples, double purchasePrice)
        {
            Supplier = supplier;
            Product = product;
            MinAmount = minAmount;
            MaxAmount = maxAmount;
            Multiples = multiples;
            this.PurchasePrice = purchasePrice;
        }
        public OrderInfo(int id, Supplier supplier, Product product, int minAmount, int maxAmount, int multiples, double purchasePrice)
        {
            ID = id;
            Supplier = supplier;
            Product = product;
            MinAmount = minAmount;
            MaxAmount = maxAmount;
            Multiples = multiples;
            this.PurchasePrice = purchasePrice;
        }
        public override string ToString()
        {
            return ID.ToString() +": "+ Supplier.Name;
        }
    }
}
