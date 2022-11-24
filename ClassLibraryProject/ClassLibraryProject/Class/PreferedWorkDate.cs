using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
   public class PreferedWorkDate
    {
        public int morning;
        public int afternoon;
        public int evening;

        public PreferedWorkDate()
        {

        }
        public PreferedWorkDate(int morning, int afternoon, int evening)
        {
            this.morning = morning;
            this.afternoon = afternoon;
            this.evening = evening;

    }

}
}
