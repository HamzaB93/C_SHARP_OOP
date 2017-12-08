using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        // Properties
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        // Composition
        public List<OrderItem> orderItems { get; set; } 
        public int CustomerId { get; set; } // Doesnt have to directly reference a customer as a property
        public int ShippingAddressId { get; set; } // Doesnt have to directly reference a address as a property

        // Constructors

        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        // Methods
        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null)
                isValid = false;

            return isValid;
        }
    }
}