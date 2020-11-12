using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            //Temporary hardcoded values to populate a customer
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Description";
                product.CurrentPrice = 15.96M;
            }
            Object myObject = new Object();

            return product;
        }
        public bool Save(Product product)
        {
            var success = true;

            if(product.HasChanges)
            {
                if(product.IsValid)
                {
                    if(product.IsNew)
                    {
                        // Call an Insert Stored Procedure
                    }
                    else
                    {
                        //Call an Update Stored PRocedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
