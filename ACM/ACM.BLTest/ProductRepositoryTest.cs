using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetreiveTest()
        {
            // Arrange
            var productRepository = new ProductRepository();

            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size",
                CurrentPrice = 15.96M
            };

            // Act
            var actual = productRepository.Retrieve(2);

            // Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
