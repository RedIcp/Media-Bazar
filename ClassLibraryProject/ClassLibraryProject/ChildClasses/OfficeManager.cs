using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.Interfaces;
using ClassLibraryProject.ManagmentClasses;
using System;

namespace ClassLibraryProject.ChildClasses
{
     public class OfficeManager :Employee
    {
        public IDepartment departmentManagment;
        public ICompany companyManagment;
        public ICheckin checkinManagment;

        public IEmployeeManagerOffice EmployeeManagerOffice { get; set; }
        public IContractManager ContractManager { get; set; }

        public OfficeManager() : base()
        { 
        }

        public OfficeManager(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail)
       : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {
        }
        public OfficeManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {
        }
        public OfficeManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IEmployeeManagerAll employeeManagerAll)
         : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll)
        {
        }
        public OfficeManager(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IEmployeeManagerOffice employeeManagerOffice, IDepartment departmentManagment, ICompany companyManagment,  IContractManager contractManager, ICheckin checkinManagment)
       : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {
            this.EmployeeManagerOffice = employeeManagerOffice;
            this.ContractManager = contractManager;

            this.departmentManagment = departmentManagment;
            this.companyManagment = companyManagment;
            this.checkinManagment = checkinManagment;
        }
        public OfficeManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IEmployeeManagerOffice employeeManagerOffice, IDepartment departmentManagment, ICompany companyManagment,  IContractManager contractManager, ICheckin checkinManagment)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {
            this.EmployeeManagerOffice = employeeManagerOffice;
            this.ContractManager = contractManager;

            this.departmentManagment = departmentManagment;
            this.companyManagment = companyManagment;
            this.checkinManagment = checkinManagment;
        }
    }
}
