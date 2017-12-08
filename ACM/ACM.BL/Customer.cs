using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        // member belongs to the type itself, rather than the instance
        public static int InstanceCount { get; set; }

        private string lastName;
        public string LastName
        {
            get
            {
                // any extra code
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        // Composition 
        public List<Address>AddressList { get; set; } 

        // Spec wanted to have a fullname 
        // No backing field as we dont need storage, its using it for last and first name anyway
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        // Constructor calls the parameterised constructor 
        public Customer() : this(0)
        {

        }

        // Consructor - with params 
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            // Give us an instance instead of giving us a null, will be empty to used later
            AddressList = new List<Address>();
        }

        // validate to say thet the last name and email are required
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
                isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress))
                isValid = false;

            return isValid;
        }
    }
}
