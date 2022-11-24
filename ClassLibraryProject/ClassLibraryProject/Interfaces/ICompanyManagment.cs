using ClassLibraryProject.Class;

namespace ClassLibraryProject.Interfaces
{
   public interface ICompanyManagment
    {
        public Company GetCompany(int UserID); 
        public void EditCompany(string Name, string Adress, string PhoneNumber, string Email, string BTW, string KVK, string ID);
    }
}
