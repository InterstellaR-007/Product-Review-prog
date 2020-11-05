using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReview
{
    public class management
    {
        public void PickTop3(List<ProductDetail> prodlist)
        {
            var retreivedData = (from prodReviews in prodlist orderby prodReviews.Rating descending select prodReviews).Take(3).ToList();
            DisplayList((List<ProductDetail>)retreivedData);
        }

        public static void DisplayList(List<ProductDetail> productDetails)
        {

            foreach (var product in productDetails)
                Console.WriteLine("{0} {1} {2} {3} {4}", product.ProductID, product.UserID, product.Rating, product.Review, product.isLike);
        }
    }
}
