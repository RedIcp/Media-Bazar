using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
    public class PreferredShift
    {
        //fields
        private string day;
        private string shift;
        private bool isPreferred;
        private List<Employee> employees;

        //properties
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
        public bool IsPreferred
        {
            get { return isPreferred; }
            set { isPreferred = value; }
        }
        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        //constructor
        public PreferredShift(string day, string shift, bool isPreferred)
        {
            Day = day;
            Shift = shift;
            IsPreferred = isPreferred;
            Employees = new List<Employee>();
        }
    }
}
