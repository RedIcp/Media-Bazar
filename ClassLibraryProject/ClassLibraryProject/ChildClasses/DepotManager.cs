using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using ClassLibraryProject.ManagmentClasses;
using ClassLibraryProject.ManagmentClasses.IDepotManager;
using System;

namespace ClassLibraryProject.ChildClasses
{
    public class DepotManager : Employee
    {
        public AutoScheduleManagment autoSchedule;
        public IViewDepartments viewDepartments;
        public IDepotManagerControl Control;

        public DepotManager() : base()
        { }

        public DepotManager(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail)
            : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {}

        public DepotManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail)
           : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {
        }
        public DepotManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IEmployeeManagerAll employeeManagerAll)
           : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll)
        {
        }
        public DepotManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IViewDepartments viewDepartments, AutoScheduleManagment autoSchedule, IEmployeeManagerAll employeeManagerAll)
            : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll)
        {
            this.viewDepartments = viewDepartments;
            this.autoSchedule = autoSchedule;
        }
        public DepotManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IViewDepartments viewDepartments, AutoScheduleManagment autoSchedule, IEmployeeManagerAll employeeManagerAll, IDepotManagerControl control)
            : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll)
        {
            this.viewDepartments = viewDepartments;
            this.autoSchedule = autoSchedule;
            Control = control;
        }
        public DepotManager(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IEmployeeManagerAll employeeManagerAll)
            : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll)
        { }
    }
}
