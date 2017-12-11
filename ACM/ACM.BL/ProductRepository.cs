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

            //product.ToString();
            Object myObject = new Object();
            
            Console.WriteLine("Object: " + myObject.ToString());
            Console.WriteLine("Product: " + product.ToString());

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
            var success = true;

            if (product.HasChanges && product.Isvalid)
            {
                if (product.IsNew)
                {
                    // Call an Insert Stored Procedure
                }
                else
                {
                    // Call an update stored procedure
                }
            }
            return success;
        }

    }
}
