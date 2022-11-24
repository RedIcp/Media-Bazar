using System;
using System.Collections.Generic;

namespace ClassLibraryProject.Class
{
    public class Employee
    {
        // fields
        private int employeeID;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;
        private string zipCode;
        private string address;
        private string city;
        private DateTime dateOfBirth;
        private int bsn;
        private string username;
        private string password;
        private string personalEmail;

        private List<Contract> contracts; // list of contracts for employee (only 1 can be active)

        // properties
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int BSN { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PersonalEmail { get; set; }
        public List<Contract> Contracts
        {
            get { return contracts; }
            set { contracts = value; }
        }

        public IEmployeeManagerAll EmployeeManagerAll { get; set; }

        // constructor
        public Employee()
        {

        }
        public Employee(string firstName, string lastName, string phoneNumber, string email, string zipCode, string address, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.City = city;
            this.DateOfBirth = dateOfBirth;
            this.BSN = bsn;
            this.Username = username;
            this.Password = password;
            this.ZipCode = zipCode;
            this.Address = address;
            this.PersonalEmail = personalEmail;
        }

        public Employee(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string address, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail)
        {
            this.EmployeeID = employeeID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.City = city;
            this.DateOfBirth = dateOfBirth;
            this.BSN = bsn;
            this.Username = username;
            this.Password = password;
            this.ZipCode = zipCode;
            this.Address = address;
            this.PersonalEmail = personalEmail;
        }
        public Employee(string firstName, string lastName, string phoneNumber, string email, string zipCode, string address, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IEmployeeManagerAll employeeManagerAll)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.City = city;
            this.DateOfBirth = dateOfBirth;
            this.BSN = bsn;
            this.Username = username;
            this.Password = password;
            this.ZipCode = zipCode;
            this.Address = address;
            this.PersonalEmail = personalEmail;
            this.EmployeeManagerAll = employeeManagerAll;
        }

        public Employee(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string address, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IEmployeeManagerAll employeeManagerAll)
        {
            this.EmployeeID = employeeID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.City = city;
            this.DateOfBirth = dateOfBirth;
            this.BSN = bsn;
            this.Username = username;
            this.Password = password;
            this.ZipCode = zipCode;
            this.Address = address;
            this.PersonalEmail = personalEmail;
            this.EmployeeManagerAll = employeeManagerAll;

            Contracts = new List<Contract>();
        }
        // methodes
        public override string ToString()
        {
            return $"ID: {EmployeeID} - Name: {FirstName} {LastName} - Email: {Email}";
        }
    }
}
