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
            //var retreivedData = prodlist.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            var retreivedData = (from prodReviews in prodlist group prodReviews by prodReviews.ProductID into newProd orderby newProd.Key select newProd ).ToList();

            foreach (var product in retreivedData)
                Console.WriteLine("Product Id: {0}  Count: {1} ", product.Key,product.Count());
        }

        public static void DisplayList(List<ProductDetail> productDetails)
        {

            
        }
    }
}
