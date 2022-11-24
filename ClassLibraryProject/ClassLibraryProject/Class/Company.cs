namespace ClassLibraryProject.Class
{
    public class Company
    {
        //fields
        private string companyID;
        private string companyName;
        private string address;
        private string email;
        private string kVK;
        private string btw;
        private string phoneNumber;

        //properties
        public string CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string KVK
        {
            get { return kVK; }
            set { kVK = value; }
        }
        public string Btw
        {
            get { return btw; }
            set { btw = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


        //constructor
        public Company()
        {

        }
        public Company(string CompanyName, string Address, string Email, string KVK, string Btw, string PhoneNumber,string CompanyID)
        {
            companyID = CompanyID;
            companyName = CompanyName;
            address = Address;
            email = Email;
            kVK = KVK;
            btw = Btw;
            phoneNumber = PhoneNumber;
        }
    }
}
