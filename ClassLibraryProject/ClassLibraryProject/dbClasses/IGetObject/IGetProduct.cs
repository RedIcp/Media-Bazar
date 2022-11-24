using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IGetObject
{
    public interface IGetProduct
    {
        Product GetProduct(string barcode);
    }
}
