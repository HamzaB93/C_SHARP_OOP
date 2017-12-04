using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        // Test to see if full name is correct
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange - Make preperations
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";

            // Act - Perform the action we want
            string actual = customer.FullName;

            // Assert - varifies epxected matches actual
            Assert.AreEqual(expected, actual);

        }

        // Test without a first name
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange - Make preperations
            Customer customer = new Customer();
            customer.LastName = "Baggins";

            string expected = "Baggins";

            // Act - Perform the action we want
            string actual = customer.FullName;

            // Assert - varifies epxected matches actual
            Assert.AreEqual(expected, actual);

        }

        // Test without a last name
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange - Make preperations
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";

            string expected = "Bilbo";

            // Act - Perform the action we want
            string actual = customer.FullName;

            // Assert - varifies epxected matches actual
            Assert.AreEqual(expected, actual);

        }
    }
}
