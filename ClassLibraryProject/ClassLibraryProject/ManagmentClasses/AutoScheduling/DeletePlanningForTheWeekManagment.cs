using ClassLibraryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses
{
    public class DeletePlanningForTheWeekManagment : IDeletePlanningForTheWeekManagment
    {
        public  IDbDeletePlanningForTheWeekManagment dbDeletePlanningForTheWeek;
       
        public DeletePlanningForTheWeekManagment(IDbDeletePlanningForTheWeekManagment dbDeletePlanningForTheWeek)
        {
            this.dbDeletePlanningForTheWeek = dbDeletePlanningForTheWeek;
        }
       
        public bool DeletePlaningThisWeek(int week, int year, string department)
        {
            return dbDeletePlanningForTheWeek.DeletePlaningThisWeek(week, year, department);
        }
    }
}
