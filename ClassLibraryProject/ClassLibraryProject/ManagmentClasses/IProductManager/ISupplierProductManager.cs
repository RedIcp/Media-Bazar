using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IProductManager
{
    public interface ISupplierProductManager
    {
        List<Supplier> GetSuppliers();
        bool AddSupplier(string name, string country, int buildingNumber, string postalCode, string email, int phoneNumber, string bankNumber);
        bool UpdateSupplier(int id, string name, string country, int buildingNumber, string postalCode, string email, int phoneNumber, string bankNumber);
        bool DeleteSupplier(int id);
    }
}
