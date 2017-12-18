using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        // properties
        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string _ProductName;

        public string ProductName
        {
            get
            {
                return _ProductName.InsertSpaces();
            }
            set { _ProductName = value; }
        }

        // Constructors
        public Product() { }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        // Methods

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
                isValid = false;
            if (CurrentPrice == null)
                isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
