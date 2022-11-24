using ClassLibraryProject.Interfaces;

namespace ClassLibraryProject.Class
{
   public class Login
    {
        private ILogin login;
        public Login(ILogin login)
        {
            this.login = login;
        }
        public Employee CheckLogin(string userName, string password)
        {
            return login.CheckLogin(userName, password);
        }

        public int GetID(string userName, string password)
        {
            return login.GetID(userName, password);
        }
    }
}
