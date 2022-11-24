using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IGetObject
{
    public interface IGetSchedule
    {
        Schedule GetSchedule(string department, int year, int week, string day);
    }
}
