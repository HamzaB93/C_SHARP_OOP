using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            // Arrange
            var orderRepository = new OrderRepository();

            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(2014, 11, 1, 2, 3, 33, new TimeSpan(2, 0, 0))
            };

            // Act
            var actual = orderRepository.Retreive(10);

            // Assert
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

        }
    }
}
