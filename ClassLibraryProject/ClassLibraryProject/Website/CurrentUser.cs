namespace ClassLibrary1
{
    public class CurrentUser
    {
        // fields
        private int employeeID;
        private string firstName;
        private string lastName;
        private string email;
        private string username;
        private string password;
        private int active;

        // properties
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Active { get; set; }

        // constructor
        public CurrentUser()
        {
                
        }
        public CurrentUser(int employeeID, string firstName, string lastName, string email, string username, string password, int active)
        {
            this.EmployeeID = employeeID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.Active = active;
        }
    }
}
