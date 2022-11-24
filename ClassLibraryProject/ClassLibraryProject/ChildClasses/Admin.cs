using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using System;

namespace ClassLibraryProject.ChildClasses
{
    public class Admin : Employee
    {
        public IEmployeeManagerAdmin EmployeeManagerAdmin { get; set; }
        public IContractManager ContractManager;
        public IDepartment departmentManagment;

        public Admin()
        {

        }
        public Admin(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail)
            : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {

        }
        public Admin(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IEmployeeManagerAll employeeManagerAll)
            : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll)
        {

        }
        public Admin(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail)
        : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        { }

        public Admin(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IEmployeeManagerAll employeeManagerAll)
        : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll)
        {}

        public Admin(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IEmployeeManagerAdmin employeeManagerAdmin, IContractManager ContractManager, IEmployeeManagerAll employeeManagerAll, IDepartment departmentManagment) 
            : base (employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll)
        {
            this.EmployeeManagerAdmin = employeeManagerAdmin;
            this.ContractManager = ContractManager;
            this.departmentManagment = departmentManagment;
        }
    }
}
