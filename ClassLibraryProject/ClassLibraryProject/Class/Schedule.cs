namespace ClassLibraryProject.Class
{
    public class Schedule
    {
        //fields
        private string department;
        private int year;
        private int week;
        private string day;
        private int morningAmount;
        private int afternoonAmount;
        private int eveningAmount;

        //properties
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public int Week
        {
            get { return week; }
            set { week = value; }
        }
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
        public int MorningAmount
        {
            get { return morningAmount; }
            set { morningAmount = value; }
        }
        public int AfternoonAmount
        {
            get { return afternoonAmount; }
            set { afternoonAmount = value; }
        }
        public int EveningAmount
        {
            get { return eveningAmount; }
            set { eveningAmount = value; }
        }

        //constructor
        public Schedule(string department, int year, int week, string day, int morningAmount, int afternoonAmount, int eveningAmount)
        {
            Department = department;
            Year = year;
            Week = week;
            Day = day;
            MorningAmount = morningAmount;
            AfternoonAmount = afternoonAmount;
            EveningAmount = eveningAmount;
        }
        public Schedule(string department, int year, int week, string day)
        {
            Department = department;
            Year = year;
            Week = week;
            Day = day;
            MorningAmount = 0;
            AfternoonAmount = 0;
            EveningAmount = 0;
        }
    }
}


