using System;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1
{
    public class Edit
    {
        public Edit()
        {

        }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public string Streetname { get; set; }
        [Required]
        public string Zipcode { get; set; }

      
        public Edit(string firstName, string lastName, string email, int phone, string department, DateTime birthday, string streetname, string zipcode)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Department = department;
            Birthday = birthday;
            Streetname = streetname;
            Zipcode = zipcode;

        }

        public string GetInfo()
        {
            return "You have successfully changed your details";
        }
    }
}
