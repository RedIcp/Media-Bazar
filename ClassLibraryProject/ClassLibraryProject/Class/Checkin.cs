using System;

namespace ClassLibraryProject.Class
{
    public class Checkin
    {
        private int employeeID;
        private DateTime checkIn;
        private DateTime checkOut;
        private string date;

        public int EmployeeID
        { get { return employeeID; } }

        public DateTime CheckIn
        { get { return checkIn; } }
        public DateTime CheckOut
        { get { return checkOut; } }
        public string Date
        { get { return date; } }

        public Checkin(int EmployeeID, DateTime CheckIn, DateTime CheckOut, string Date)
        {
            employeeID = EmployeeID;
            checkIn = CheckIn;
            checkOut = CheckOut;
            date = Date;
        }

        public override string ToString()
        {
            return $"EmployeeID: {EmployeeID} Checkin: {CheckIn}  Checkout: {CheckOut} Day: {Date}";
        }
    }
}
