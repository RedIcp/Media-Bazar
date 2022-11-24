using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.ISalesEmployee
{
    public interface ISalesEmployeeControl
    {
        Product GetProduct(string barcode);
        bool RequestReshelf(Product product, int amount);
    }
}
