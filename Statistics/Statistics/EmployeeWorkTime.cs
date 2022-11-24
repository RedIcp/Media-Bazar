using System;

namespace Statistics
{
    public  class EmployeeWorkTime
    {
        private int employeeID;
        private string employeeName;
        private TimeSpan timeworked;
        private int workHours;

        public string EmployeeName
        { get { return employeeName; } }

        public int EmployeeID
        { get { return employeeID; } }

        public TimeSpan Timeworked
        { get { return timeworked; } }
        public int WorkHours
        { get { return workHours; } }

        public EmployeeWorkTime(int EmployeeID, string EmployeeName, TimeSpan Timeworked, int WorkHours)
        {
            employeeID = EmployeeID;
            timeworked = Timeworked;
            workHours = WorkHours;
            employeeName = EmployeeName;
        }
    }
}
