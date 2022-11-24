using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using ClassLibraryProject.ManagmentClasses;
using ClassLibraryProject.ManagmentClasses.ISalesManager;
using System;

namespace ClassLibraryProject.ChildClasses
{
   public class SalesManager : Employee
    {
        public AutoScheduleManagment autoSchedule;
        public IViewDepartments viewDepartments;
        public IProductManagerSM ProductManagerSM { get; set; }
        public ISalesManagerControl Control;

        public SalesManager() : base()
        { }

        public SalesManager(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail)
       : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {

        }
        public SalesManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {}
        public SalesManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IEmployeeManagerAll employeeManagerAll)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll)
        { }
        public SalesManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IViewDepartments viewDepartments, AutoScheduleManagment autoSchedule)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {
            this.autoSchedule = autoSchedule;
            this.viewDepartments = viewDepartments;
        }
        public SalesManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IViewDepartments viewDepartments, AutoScheduleManagment autoSchedule, IProductManagerSM productManagerSM)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {
            this.autoSchedule = autoSchedule;
            this.viewDepartments = viewDepartments;
            this.ProductManagerSM = productManagerSM;
        }

        public SalesManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IViewDepartments viewDepartments, AutoScheduleManagment autoSchedule, IEmployeeManagerAll employeeManagerAll)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll)
        {
            this.autoSchedule = autoSchedule;
            this.viewDepartments = viewDepartments;
        }

        public SalesManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IViewDepartments viewDepartments, AutoScheduleManagment autoSchedule, IProductManagerSM productManagerSM, ISalesManagerControl control)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {
            this.autoSchedule = autoSchedule;
            this.viewDepartments = viewDepartments;
            this.ProductManagerSM = productManagerSM;
            Control = control;
        }
    }
}
