using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;

namespace ClassLibraryProject.ManagmentClasses
{
    public class LoginManagment : ILogin
    {
        ILoginManagement iLoginManagement;

        public LoginManagment(ILoginManagement loginManagement)
        {
            iLoginManagement = loginManagement;
        }

        //Gets the jobtitle of the employee that users this username and password, if exists
        public Employee CheckLogin(string UserName, string Password)
        {
            return iLoginManagement.checkLogin(UserName, Password);
        }

        //Gets the ID of the employee that users thes username and password entered
        public int GetID(string UserName, string Password)
        {
            return iLoginManagement.GetID(UserName, Password);
        }
    }
}
