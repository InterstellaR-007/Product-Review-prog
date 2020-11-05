using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReview
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<ProductDetail> prodReviewList = new List<ProductDetail>()
            {
                new ProductDetail(){ProductID=1,UserID=1,Rating=2,Review="good",isLike=true},
                new ProductDetail(){ProductID=2,UserID=10,Rating=2,Review="good",isLike=true},
                new ProductDetail(){ProductID=3,UserID=11,Rating=3,Review="good",isLike=true},
                new ProductDetail(){ProductID=4,UserID=4,Rating=5,Review="bad",isLike=false},
                new ProductDetail(){ProductID=5,UserID=2,Rating=1,Review="good",isLike=true},
                new ProductDetail(){ProductID=6,UserID=7,Rating=2,Review="good",isLike=true},
                new ProductDetail(){ProductID=7,UserID=8,Rating=2,Review="good",isLike=true},
                new ProductDetail(){ProductID=8,UserID=19,Rating=2,Review="good",isLike=true},
                new ProductDetail(){ProductID=9,UserID=2,Rating=1,Review="bad",isLike=false}

            };


            management mgmgt = new management();
            mgmgt.getQueriedList(prodReviewList);
            

        }
        
    }
}
