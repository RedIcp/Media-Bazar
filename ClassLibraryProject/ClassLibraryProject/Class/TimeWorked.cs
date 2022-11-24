namespace ClassLibraryProject.Class
{
    public class TimeWorked
    {
        private int employeeID;
        private string timeWorked;
        private string name;
        private string jobTitle;
        private string workHoursPerWeek;
        private string salaryPerHour;

        public int EmployeeID
        {
            get { return employeeID; }
        }

        public string TimeWork
        {
            get { return timeWorked; }
            set { timeWorked = value; }
        }
        public string Name
        {
            get { return name; }
        }
        public string JobTitle
        {
            get { return jobTitle; }
        }
        public string WorkHoursPerWeek
        {
            get { return workHoursPerWeek; }
        }
        public string SalaryPerHour
        {
            get { return salaryPerHour; }
        }


        public TimeWorked(int EmployeeID, string TimeWorked, string Name, string JobTitle, string WorkHoursPerWeek, string SalaryPerHour)
        {
            employeeID = EmployeeID;
            timeWorked = TimeWorked;
            name = Name;
            jobTitle = JobTitle;
            workHoursPerWeek = WorkHoursPerWeek;
            salaryPerHour = SalaryPerHour;

        }

        public override string ToString()
        {
            return $"EmployeeID:   {EmployeeID} timeWorked:   {timeWorked}";
        }
    }
}
