using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        private string lastName;
        public string LastName
        {
            get
            {
                // any extra code
                return LastName;
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
                return LastName + ", " + FirstName;
            }
        }

    }
}
