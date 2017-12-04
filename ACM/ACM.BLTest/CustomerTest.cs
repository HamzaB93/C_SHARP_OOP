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

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            // Act

            // Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        // Test for valid last name and email
        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAddress = "fbaggins@precious.me";

            var expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Test for invalid, with no last name
        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer();
            customer.EmailAddress = "fbaggins@precious.me";

            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Test for invalid, no email
        [TestMethod]
        public void ValidateMissingEmail()
        {
            // Arrange
            var customer = new Customer();
            customer.LastName = "Baggins";

            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
