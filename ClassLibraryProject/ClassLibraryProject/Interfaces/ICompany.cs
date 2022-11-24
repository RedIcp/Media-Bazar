using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Interfaces
{
   public interface ICompany
    {
        public Company GetCompany(int UserID);

        public void EditCompany(string Name, string Adress, string PhoneNumber, string Email, string BTW, string KVK, string ID);
    }
}
