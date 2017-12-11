using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        // Retrieve one customer - Hard coding for testing purposes
        public Customer Retrieve(int customerId)
        {
            // New instance of a customer, passing id because the setter is in the constructor

            // Collaboration > CustomerRepository uses a Customer instance 
            Customer customer = new Customer(customerId);
            // Gettiung the list of address from the address repostory via collaboration  
            customer.AddressList = addressRepository.RetrieveByCustomerId((customerId)).ToList();

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
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
