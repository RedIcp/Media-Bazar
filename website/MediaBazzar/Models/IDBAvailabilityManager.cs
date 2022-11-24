using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite
{
    public interface IDBAvailabilityManager
    {
        public bool EnterAvailability(Unavailability u);
        public List<Unavailability> ReadAvailability(Employee e);
    }
}
