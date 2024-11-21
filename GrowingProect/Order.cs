using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrowingProect
{
    public class Order
    {
        public int orderId { get; set; }
        public string orderName { get; set;}
        public int orderCount { get; set; }
        public decimal orderPrice { get; set; }
        public decimal orderTotalAmmount { get; set; }
        public OrderStatus orderStatus{ get; set; }

        public Order(int id , string name , int count,
        decimal price , decimal total , OrderStatus status)
        {
            orderId = id;
            orderName = name;
            orderPrice = price;
            orderTotalAmmount = total;
            orderStatus = status;
        }
    }
}