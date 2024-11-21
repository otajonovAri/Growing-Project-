using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrowingProect
{
    public struct OrderTotalAmmount
    {
        private decimal OrderCount;
        public decimal Count
        {
            get { return OrderCount; }
            set{
                OrderCount = value > 0 ? value : 0;
            }
        }
        private decimal OrderPrice;
        public OrderTotalAmmount(decimal Price , decimal Count)
        {
            OrderCount = Count > 0 ? Count : 0;
            OrderPrice = Price;
        }
        public decimal GetOrderPrice()
        {
            if (OrderCount <= 0 || OrderPrice <= 0)
                return 0;
            return OrderPrice * OrderCount;
        }
    }
}