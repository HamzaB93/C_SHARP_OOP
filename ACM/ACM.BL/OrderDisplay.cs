using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderDisplay
    {
        // Properties needed to display an order
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        // COmposition
        public List<OrderDisplayItem> OrderDisplayItemList { get; set; }
        public int OrderId { get; set; } 
        public Address ShippingAddress { get; set; }
    }
}
