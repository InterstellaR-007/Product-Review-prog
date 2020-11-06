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
            var retreivedData = (from prodReviews in prodlist where (prodReviews.Rating > 3) && 
                                 ((prodReviews.ProductID == 1)|| (prodReviews.ProductID == 4)
                                 || (prodReviews.ProductID == 9))
                                 select prodReviews).ToList();

            DisplayList((List<ProductDetail>)retreivedData);
        }

        public static void DisplayList(List<ProductDetail> productDetails)
        {

            foreach (var product in productDetails)
                Console.WriteLine("Product ID:{0} UserID:{1} Rating:{2} Review:{3} islike:{4}", product.ProductID, product.UserID, product.Rating, product.Review, product.isLike);
        }
    }
}
