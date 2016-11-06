using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetReviewed.Models.DBHandler;
using NetReviewed.Helpers;

namespace NetReviewed.Models.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        //List<Review> reviews = new List<Review> { new Review { Id = 1, Comment = "Work with in future" }, new Review { Id = 2,Comment= "Definitely Good lif after Death" } };

        DbCommentSystem dbContext = new DbCommentSystem();
//Repository<Review> reviewRepository = new Repository<Review>();
        public Review Get(int id)
        {
            var query=from review in dbContext.Reviews
                      where review.ReviewId == id
                      select review;
            query.ToTraceString();
            Logger.Log(query.ToTraceString());
            //return dbContext.Reviews.Where(r=>r.ReviewId==id).First();
            return query.First();
        }

        public void Add(Review review)
        {
            dbContext.Reviews.AddObject(review);
            dbContext.SaveChanges();
        
        }

        public IEnumerable<Review> GetAll()
        {
            return dbContext.Reviews;
        }

        public void Update(Review review)
        {
            var reviewupdate = dbContext.Reviews.Where(r => r.ReviewId == review.ReviewId).First();
            reviewupdate = review;
            dbContext.SaveChanges();

        }

        public void Delete(int id)
        {
            var reviewToDelete = dbContext.Reviews.Where(r => r.ReviewId == id).First();
            dbContext.Reviews.DeleteObject(reviewToDelete);
            dbContext.SaveChanges();
        }
    }
}
