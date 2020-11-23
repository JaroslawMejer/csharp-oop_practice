using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InserSpaces()
            }
            set
            {
                _productName = value;
            }
        }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public decimal? CurrentPrice { get; set; }
        public override string ToString() => ProductName;
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
    }
}
