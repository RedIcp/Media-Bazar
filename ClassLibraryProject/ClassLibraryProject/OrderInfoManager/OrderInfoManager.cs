using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public class OrderInfoManager : IOrderInfoManagerPM
    {
        DBOrderInfoManager DBOrderInfoManager { get; set; }

        public OrderInfoManager()
        {
            this.DBOrderInfoManager = new DBOrderInfoManager();
        }
        public List<OrderInfo> GetOrderInfosForProduct(Product p)
        {
            return DBOrderInfoManager.GetOrderInfosForProduct(p);
        }

        public bool CreateOrderInfo(OrderInfo oi)
        {
            return DBOrderInfoManager.CreateOrderInfo(oi);
        }

        public bool DeleteOrderInfo(OrderInfo oi)
        {
            return DBOrderInfoManager.DeleteOrderInfo(oi);
        }

        public bool UpdateOrderInfo(OrderInfo oi)
        {
            return DBOrderInfoManager.UpdateOrderInfo(oi);
        }
    }
}
