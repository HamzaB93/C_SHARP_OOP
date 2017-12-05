using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        // Retreive an order, temp hard coding for testing
        public Order Retreive(int orderItemId)
        {
            Order order = new Order(orderItemId);

            if (orderItemId == 10)
            {
                order.OrderDate = new DateTimeOffset(2014, 11, 1, 2, 3, 33, new TimeSpan(2,0,0));
            }

            return order;
        }

        public bool Save()
        {
            return true;
        }
    }
}
