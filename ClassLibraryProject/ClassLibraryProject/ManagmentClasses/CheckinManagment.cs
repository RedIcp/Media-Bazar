using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using System.Collections.Generic;
using System.Data;

namespace ClassLibraryProject.ManagmentClasses
{
    public class CheckinManagment : ICheckin
    {
        ICheckinManagment icheckinManagment;

        public CheckinManagment(ICheckinManagment checkinManagment)
        {
            icheckinManagment = checkinManagment;
        }

        public List<Checkin> getAllAtendance()
        {
            return icheckinManagment.getAllAtendance();
        }

        public List<TimeWorked> getAllAtendanceTime(int year, int month)
        {
            return icheckinManagment.getAllAtendanceTime(year, month);
        }

        public DataTable getAtendanceData(int year, int month)
        {
            return icheckinManagment.getAtendanceData(year, month);
        }

        public List<TimeWorked> UniqueID()
        {
            return icheckinManagment.UniqueID();
        }

        public List<Checkin> getAllAtendanceOnCheckIn()
        {
            return icheckinManagment.getAllAtendanceOnCheckIn();
        }

        public int GetEmployeeID(string CardNumber)
        {
            return icheckinManagment.GetEmployeeID(CardNumber);
        }

        public bool IsAlreadyCheckedIn(int EmployeeID)
        {
            return icheckinManagment.IsAlreadyCheckedIn(EmployeeID);
        }

        public void AddCheckIn(int EmployeeID)
        {
            icheckinManagment.AddCheckIn(EmployeeID);
        }

        public void EditCheckOutTime(int EmployeeID)
        {
            icheckinManagment.EditCheckOutTime(EmployeeID);
        }
    }
}
