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

        // Use this syntax when you dont need to add extra code to get and set
        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        // propg snippet to make the setter private so nothing else can change the property
        public int CustomerId { get; private set; }

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

        // Constructor - no params = default
        public Customer()
        {

        }

        // Consructor - with params 
        public Customer(int customerId)
        {
            // this means the instance of the class
            this.CustomerId = customerId;
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
