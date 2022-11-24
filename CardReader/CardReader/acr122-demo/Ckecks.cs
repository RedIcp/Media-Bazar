
using System;

namespace CardReader
{
    class Ckecks
    {
        private int employeeID;
        private string checkIn;
        private string checkOut;
        private string date;
        private string timeWorked;

        public int EmployeeID
        { get { return employeeID; } }
        public string CheckIn
        { get { return checkIn; } }
        public string CheckOut
        { get { return checkOut; } }
        public string Date
        { get { return date; } }
        public string TimeWorked
        { 
            get { return timeWorked; }
            set { timeWorked = value; }
        }

        public Ckecks(int EmployeeID, string CheckIn, string CheckOut, string Date, string TimeWorked)
        {
            employeeID = EmployeeID;
            checkIn = CheckIn;
            checkOut = CheckOut;
            date = Date;
            timeWorked = TimeWorked;
        }

        public override string ToString()
        {
            if (TimeWorked.ToString() == "")
            {
                return $"EmployeeID: {EmployeeID} Checkin: {CheckIn}  Checkout: {CheckOut} ";
            }
            else
            {
                return $"EmployeeID: {EmployeeID} Checkin: {CheckIn}  Checkout: {CheckOut} TimeWorked: {TimeWorked}";
            }
        }
    }
}
