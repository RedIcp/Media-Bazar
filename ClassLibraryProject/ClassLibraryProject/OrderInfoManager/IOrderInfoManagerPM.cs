using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public interface IOrderInfoManagerPM
    {
        public List<OrderInfo> GetOrderInfosForProduct(Product p);
        public bool CreateOrderInfo(OrderInfo oi);
        public bool UpdateOrderInfo(OrderInfo oi);
        public bool DeleteOrderInfo(OrderInfo oi);
    }
}
