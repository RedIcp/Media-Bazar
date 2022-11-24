using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses.IProductManager;
using System;

namespace ClassLibraryProject.ChildClasses
{
  public class ProductManager : Employee
    {
        public IProductManagerPM ProductManagerPM { get; set; }
        public ISupplierManagerPM SupplierManagerPM { get; set; }
        public IOrderInfoManagerPM OrderInfoManagerPM { get; set; }

        // empty for website
        public ProductManager() : base()
        { }

        // for creating the employee
        public ProductManager(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail)
       : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {

        }

        // for reading the employees 
        public ProductManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {

        }

        // for updating the employee as office manager
        public ProductManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IEmployeeManagerAll employeeManagerAll)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll)
        {

        }

        // for login
        public ProductManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IEmployeeManagerAll employeeManagerAll, IProductManagerPM productManagerPM, ISupplierManagerPM supplierManagerPM, IOrderInfoManagerPM orderInfoManagerPM)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll)
        {
            this.ProductManagerPM = productManagerPM;
            this.SupplierManagerPM = supplierManagerPM;
            this.OrderInfoManagerPM = orderInfoManagerPM;
        }
    }
}
