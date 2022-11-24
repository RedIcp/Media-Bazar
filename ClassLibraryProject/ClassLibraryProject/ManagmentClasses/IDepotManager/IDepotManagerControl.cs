using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IDepotManager
{
    public interface IDepotManagerControl
    {
        //restock
        Restock GetRestockByID(int id);
        List<Restock> GetRestockRequests();
        bool OrderRestock(int id, OrderInfo orderInfo, int amount);
        bool DeleteRestock(int id);
        bool IsValid(OrderInfo orderInfo, int amount);

        //schedule
        Schedule GetSchedule(string department, int year, int week, string day);
        List<Schedule> GetSchedules(string department, int year, int week);
        bool CreateWeek(string department, int year, int week);
        bool WeekExist(string department, int year, int week);
        bool UpdateSchedule(string department, int year, int week, string day, int morningAmount, int afternoonAmount, int eveningAmount);

        //planning
        void GetAllRegisteredShift();
        bool RegisterEmployee(string department, int year, int week, string day, string shift, Employee employee);
        bool CheckAmount(string department, int year, int week, string day, string shift);
        bool DeRegisterEmployee(string department, int year, int week, string day, string shift, Employee employee);
        RegisteredShift GetRegisteredShift(string department, int year, int week, string day, string shift);
        bool RegisteredEmployeeExist(string department, int year, int week, string day, string shift, int employeeID);

        //preferred shift
        List<Employee> EmployeesWithNoPreference(string day, string shift);
        public  PreferredShift GetPreferredShift(string day, string shift);
    }
}
