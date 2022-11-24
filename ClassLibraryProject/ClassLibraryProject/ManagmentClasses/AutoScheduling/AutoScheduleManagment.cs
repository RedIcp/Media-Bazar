using ClassLibraryProject.Interfaces;

namespace ClassLibraryProject.ManagmentClasses
{
    public class AutoScheduleManagment
    {
        public IAsignShiftManagment asignShift;
        public IEmployeesAvailibleManagment employeesAvailible;
        public IDeletePlanningForTheWeekManagment deletePlanning;
        public IAmountOfEmployeesNeededManagment amountOfEmployeesNeeded;

        public AutoScheduleManagment(IAsignShiftManagment asignShift, IEmployeesAvailibleManagment employeesAvailible, IDeletePlanningForTheWeekManagment deletePlanning, IAmountOfEmployeesNeededManagment amountOfEmployeesNeeded)
        {
            this.asignShift = asignShift;
            this.employeesAvailible = employeesAvailible;
            this.deletePlanning = deletePlanning;
            this.amountOfEmployeesNeeded = amountOfEmployeesNeeded;
        }
    }
}
