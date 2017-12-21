using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Order : EntityBase, Logabble
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

        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null)
                isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return OrderDate.Value.Date + " (" + OrderId + ")";
        }

        public string Log()
        {
            var logString = this.OrderId + ": " +
                            "Date: " + this.OrderDate.Value.Date + " " +
                            "Status: " + this.EntityState.ToString();
            return logString;
        }
    }
}