using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.dbClasses.IGetObject;
using ClassLibraryProject.ManagmentClasses.IAllManager;

namespace ClassLibraryProject.ManagmentClasses
{
    public class RegisteredShiftManagment : IRegisteredShiftAllManager
    {
        private IDBRegisteredShift db;
        private IGetSchedule schedule;

        public RegisteredShiftManagment(IDBRegisteredShift dbRegisteredShift, IGetSchedule schedule)
        {
            db = dbRegisteredShift;
            this.schedule = schedule;
        }

        public void GetAllRegisteredShift()
        {
            db.GetAllRegisteredShifts();
        }
        public bool RegisterEmployee(string department, int year, int week, string day, string shift, int employeeID)
        {
            if (!RegisteredEmployeeExist(department, year, week, day, shift, employeeID))
            {
                if (db.RegisterEmployee(department, year, week, day, shift, employeeID) == true)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool DeRegisterEmployee(string department, int year, int week, string day, string shift, int employeeID)
        {
            if (RegisteredEmployeeExist(department, year, week, day, shift, employeeID))
            {
                if (db.DeRegisterEmployee(department, year, week, day, shift, employeeID))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool CheckAmount(string department, int year, int week, string day, string shift)
        {
            if (schedule.GetSchedule(department, year, week, day) != null)
            {
                int amountRegistered = GetRegisteredShift(department, year, week, day, shift).Employees.Count;
                int morningAmount = schedule.GetSchedule(department, year, week, day).MorningAmount;
                int afternoonAmount = schedule.GetSchedule(department, year, week, day).AfternoonAmount;
                int eveningAmount = schedule.GetSchedule(department, year, week, day).EveningAmount;


                if (shift == "Morning")
                {
                    if (morningAmount > amountRegistered)
                    {
                        return true;
                    }
                    return false;
                }
                else
                {
                    if (shift == "Afternoon")
                    {
                        if (afternoonAmount > amountRegistered)
                        {
                            return true;
                        }
                        return false;
                    }
                    else
                    {
                        if (shift == "Evening")
                        {
                            if (eveningAmount > amountRegistered)
                            {
                                return true;
                            }
                            return false;
                        }
                    }
                    return false;
                }
            }
            return false;
        }
        public RegisteredShift GetRegisteredShift(string department, int year, int week, string day, string shift)
        {
            return db.GetRegisteredShift(department, year, week, day, shift);
        }
        private Employee RegisteredEmployee(string department, int year, int week, string day, string shift, int employeeID)
        {
            if (GetRegisteredShift(department, year, week, day, shift) != null)
            {
                RegisteredShift rs = GetRegisteredShift(department, year, week, day, shift);
                foreach (Employee e in rs.Employees)
                {
                    if (e.EmployeeID == employeeID)
                    {
                        return e;
                    }
                }
            }
            return null;
        }
        public bool RegisteredEmployeeExist(string department, int year, int week, string day, string shift, int employeeID)
        {
            if (RegisteredEmployee(department, year, week, day, shift, employeeID) != null)
            {
                return true;
            }
            return false;
        }
    }
}
