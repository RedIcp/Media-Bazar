
namespace acr122_demo
{
    public class Person
    {
		// properties
		public int EmployeeID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public int BSN { get; set; }
		public int Active { get; set; }
		public string City { get; set; }
		public string Email { get; set; }
		public int PhoneNumber { get; set; }
		public string DateOfBirth { get; set; }
		public string CardNumber { get; set; }

		//constructor
		public Person(int employeeID, string firstName, string lastName, int phoneNumber, string email, string city, string dateOfBirth, int bsn, string username, string password, string cardNum)
		{
			this.EmployeeID = employeeID;
			this.LastName = firstName;
			this.FirstName = lastName;
			this.Username = username;
			this.Password = password;
			this.BSN = bsn;
			this.Active = 1;
			this.City = city;
			this.Email = email;
			this.PhoneNumber = phoneNumber;
			this.DateOfBirth = dateOfBirth;
			CardNumber = cardNum;
		}

        public Person(long v1, string v2, string v3, long v4, string v5, string v6, string v7, long v8, string v9, string v10, string v11)
        {
        }

        // methodes
        public override string ToString()
		{
			return $"ID: {EmployeeID} - {FirstName} {LastName}";
		}
	}
}
