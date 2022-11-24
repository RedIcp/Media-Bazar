using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1
{
    public class User
    {

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool Employee { get; set; }

        public User() { }
        public User(string firstName, string lastName, string email, string username, string password, bool employee)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Username = username;
            Password = password;
            Employee = employee;
        }

        public string GetInfo()
        {
            return "name: " + FirstName + " " + LastName + " Email: " + Email;

        }


    }
}
