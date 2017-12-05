﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        // properties
        // 
        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

        // Constructors
        public Product() { }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        // Methods

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
                isValid = false;
            if (CurrentPrice == null)
                isValid = false;

            return isValid;
        }
    }
}
