using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReview
{
    public class management
    {
        public void getQueriedList(List<ProductDetail> prodlist)
        {
            var retreivedData = (from prodReviews in prodlist select prodReviews).ToList();

            foreach (var product in retreivedData)
                Console.WriteLine("Product Id: {0}  Review:{1} ", product.ProductID,product.Review);
        }

        public static void DisplayList(List<ProductDetail> productDetails)
        {

            
        }
    }
}
