using ClassLibraryProject.Class;

namespace ClassLibraryProject.Interfaces
{
    public interface ILogin
    {
        public Employee CheckLogin(string UserName, string Password);
        public int GetID(string UserName, string Password);
    }
}
