using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IProductManager
{
    public class ProductManagerControl
    {
        private IOrderInfoProductManager orderInfo;
        private ISupplierManagerPM supplier;

        public ProductManagerControl(IOrderInfoProductManager orderInfo, ISupplierManagerPM supplier)
        {
            this.orderInfo = orderInfo;
            this.supplier = supplier;
        }

        //order info
        public List<OrderInfo> GetOrderInfos()
        {
            return orderInfo.GetOrderInfos();
        }
        public bool AddOrderInfo(OrderInfo oi)
        {
            return orderInfo.AddOrderInfo(oi);
        }
        public bool UpdateOrderInfo(int id, int minAmount, int maxAmount, int multiples)
        {
            return orderInfo.UpdateOrderInfo(id, minAmount, maxAmount, multiples);
        }
        public bool DeleteOrderInfo(int id)
        {
            return orderInfo.DeleteOrderInfo(id);
        }
    }
}
