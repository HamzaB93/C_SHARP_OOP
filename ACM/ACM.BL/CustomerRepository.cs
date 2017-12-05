using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        // Retrieve one customer - Hard coding for testing purposes
        public Customer Retrieve(int customerId)
        {
            // New instance of a customer, passing id because the setter is in the constructor
            Customer customer = new Customer(customerId);

            // Temp - returning hard coded customer details
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobit.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }

        // Retrieve a list of customers
        public List<Customer> Retireve()
        {
            return new List<Customer>();
        }

        // saves the current customer
        public bool Save()
        {
            return true;
        }
    }
}
