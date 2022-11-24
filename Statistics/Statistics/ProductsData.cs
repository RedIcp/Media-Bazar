
namespace Statistics
{
    public class ProductsData
    {
        private string productName;
        private int amount;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public ProductsData(string productName, int amount)
        {
            ProductName = productName;
            Amount = amount;
        }
    }
}
