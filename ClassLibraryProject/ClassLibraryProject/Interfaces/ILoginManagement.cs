using ClassLibraryProject.Class;

namespace ClassLibraryProject.Interfaces
{
   public interface ILoginManagement
    {
        //Gets the jobtitle of the employee that users this username and password, if exists
        public Employee checkLogin(string UserName, string Password);

        //Gets the ID of the employee that users thes username and password entered
        public int GetID(string UserName, string Password);
    }
}
