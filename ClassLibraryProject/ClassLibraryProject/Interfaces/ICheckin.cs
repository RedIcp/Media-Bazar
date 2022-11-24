using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ClassLibraryProject.Interfaces
{
  public  interface ICheckin
    {
        public List<Checkin> getAllAtendance();

        public List<TimeWorked> getAllAtendanceTime(int year, int month);

        public DataTable getAtendanceData(int year, int month);

        public List<TimeWorked> UniqueID();

        public List<Checkin> getAllAtendanceOnCheckIn();

        public int GetEmployeeID(string CardNumber);

        public bool IsAlreadyCheckedIn(int EmployeeID);

        public void AddCheckIn(int EmployeeID);

        public void EditCheckOutTime(int EmployeeID);
    }
}
