﻿using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IDB
{
    public interface IDBSupplierManagerPM
    {
        List<Supplier> ReadSuppliers();
        bool CreateSupplier(Supplier s);
        bool UpdateSupplier(Supplier s);
        bool DeleteSupplier(Supplier s);
        List<Supplier> GetSuppliersForProduct(Product p);
        public Supplier GetSupplierByID(int supplierID);
        public List<Supplier> SearchSuppliers(string search);
    }
}
