using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
    public class RegisteredShift
    {
        //fields
        private string department;
        private int year;
        private int week;
        private string day;
        private string shift;
        private List<Employee> employees;

        //properties
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Week
        {
            get { return week; }
            set { week = value; }
        }
        public string Day
        {
            get { return day; }
            set { day = value; }
        }
        public string Shift
        {
            get { return shift; }
            set { shift = value; }
        }
        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        //constructor
        public RegisteredShift(string department, int year, int week, string day, string shift)
        {
            Department = department;
            Year = year;
            Week = week;
            Day = day;
            Shift = shift;
            Employees = new List<Employee>();
        }
    }
}
