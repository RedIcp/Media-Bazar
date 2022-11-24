using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
   public class WorkingToday
    {
        public bool morning;
        public bool afternoon;
        public bool evening;

        public WorkingToday()
        {
                
        }
        public WorkingToday( bool Morning, bool Afternoon, bool Evening)
        {
            morning = Morning;
            afternoon = Afternoon;
            evening = Evening;
    }
    }
}
