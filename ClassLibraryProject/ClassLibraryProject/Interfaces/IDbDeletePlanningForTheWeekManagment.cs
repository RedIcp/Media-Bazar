using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Interfaces
{
    public interface IDbDeletePlanningForTheWeekManagment
    {
        public bool DeletePlaningThisWeek(int week, int year, string department);

    }
}
