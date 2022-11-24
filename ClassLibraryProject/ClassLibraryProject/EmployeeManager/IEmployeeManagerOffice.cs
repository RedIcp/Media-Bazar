﻿using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public interface IEmployeeManagerOffice
    {
        public bool CreateEmployee(Employee e);
        public List<Employee> ReadEmployees();
        public bool UpdateEmployee(Employee e);
        public bool DeleteEmployee(Employee e);
        public Employee GetEmployeeID(string givenEmail, string jobTitle);
        public Employee GetEmployeeByID(int givenEmployeeID);
        public List<Employee> GetAllEmployees(); 
        public List<Employee> SearchEmployee(string search);
    }
}
