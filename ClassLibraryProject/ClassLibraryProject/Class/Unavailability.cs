using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
    public class Unavailability
    {
        //fields
        private int year;
        private int week;
        private string day;
        private Employee employee;

        //properties
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Week
        {
            get { return week; }
            set { week = value; }
        }
        public Employee Employee
        {
            get { return employee; }
            set { employee = value; }
        }

        //constructor
        public Unavailability()
        {

        }
        public Unavailability(int year, int week, string day, Employee employee)
        {
            Year = year;
            Week = week;
            Day = day;
            Employee = employee;
        }
    }
}
