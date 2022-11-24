using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Interfaces
{
    public interface IAsignShiftManagment
    {
        public bool AssignEmployeeShift(string sql);
        public bool ScheduleShift(List<int> employees, int amountToSchedule, string shift, string day, int week, int year);
        public bool ScheduleAllEmployees(List<int> employees, int amountToSchedule, string shift, string day, int week, int year);

    }
}
