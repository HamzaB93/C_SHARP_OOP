using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            // Temp hard coded retrieval
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"

                };
            } 

            orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();

            // Temp hard coded 
            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sunflowers",
                    PurchasePrice = 15.96M,
                    OrderQuantity = 2
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
            }

            return orderDisplay;
        }

        // Retreive an order, temp hard coding for testing
        public Order Retreive(int orderItemId)
        {
            // Collaboration 
            Order order = new Order(orderItemId);

            if (orderItemId == 10)
            {
                order.OrderDate = new DateTimeOffset(2014, 11, 1, 2, 3, 33, new TimeSpan(2,0,0));
            }

            return order;
        }

        public bool Save(Order order)
        {
            return true;
        }
    }
}
