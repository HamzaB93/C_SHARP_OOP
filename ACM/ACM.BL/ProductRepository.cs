using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        // Retrive one product - Temp hard coding for testing
        public Product Retrieve (int productId)
        {
            // Collaboration
            Product product = new Product(productId);

            if (productId == 2 )
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        // Save a product
        public bool Save(Product product)
        {
            return true;
        }

    }
}
