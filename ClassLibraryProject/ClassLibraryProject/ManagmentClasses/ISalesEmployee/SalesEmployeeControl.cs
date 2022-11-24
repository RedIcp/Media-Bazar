using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.ISalesEmployee
{
    public class SalesEmployeeControl: ISalesEmployeeControl
    {
        private IReshelfSalesEmployee reshelf;

        public SalesEmployeeControl(IReshelfSalesEmployee reshelf)
        {
            this.reshelf = reshelf;
        }

        //reshelf
        public Product GetProduct(string barcode)
        {
            return reshelf.GetProduct(barcode); 
        }
        public bool RequestReshelf(Product product, int amount)
        {
            return reshelf.RequestReshelf(product, amount);
        }
    }
}
