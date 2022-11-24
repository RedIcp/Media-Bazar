using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public class EmployeeManager : IEmployeeManagerOffice, IEmployeeManagerAdmin, IEmployeeManagerAll
    {
        IDBEmployeeManagerOffice DBEmployeeManagerOffice { get; set; }
        IDBEmployeeManagerAdmin DBEmployeeManagerAdmin { get; set; }
        IDBEmployeeManagerAll DBEmployeeManagerAll { get; set; }

        public EmployeeManager()
        {
            DBEmployeeManagerOffice = new DBEmployeeManager();
            DBEmployeeManagerAdmin = new DBEmployeeManager();
            DBEmployeeManagerAll = new DBEmployeeManager();
        }

        public bool CreateEmployee(Employee e)
        {
            return DBEmployeeManagerOffice.CreateEmployee(e);
        }
        public List<Employee> ReadEmployees()
        {
            return DBEmployeeManagerOffice.ReadEmployees();
        }
        public bool UpdateEmployee(Employee e)
        {
            return DBEmployeeManagerOffice.UpdateEmployee(e);
        }
        public bool DeleteEmployee(Employee e)
        {
            return DBEmployeeManagerOffice.DeleteEmployee(e);
        }

        public Employee GetEmployeeID(string givenEmail, string jobTitle)
        {
            return DBEmployeeManagerOffice.GetEmployeeID(givenEmail, jobTitle);
        }

        public int AmountOfOfficeManagers()
        {
            return DBEmployeeManagerAdmin.AmountOfOfficeManagers();
        }

        public Employee GetEmployeeByID(int givenEmployeeID)
        {
            return DBEmployeeManagerOffice.GetEmployeeByID(givenEmployeeID);
        }

        public bool UpdateOwnInfo(Employee e)
        {
            return DBEmployeeManagerAll.UpdateOwnInfo(e);
        }

        public List<Contract> GetEmployeeContracts(Employee e)
        {
            return DBEmployeeManagerAll.GetEmployeeContracts(e);
        }

        public List<Employee> SearchEmployee(string search)
        {
            return DBEmployeeManagerOffice.SearchEmployee(search);
        }

        public List<Employee> GetAllEmployees()
        {
            return DBEmployeeManagerOffice.GetAllEmployees();
        }
    }
}
