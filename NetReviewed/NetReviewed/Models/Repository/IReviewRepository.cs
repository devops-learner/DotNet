using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetReviewed.Models.Repository
{
  public  interface IReviewRepository
    {
        Review Get(int id);

        void Add(Review review);

        IEnumerable<Review> GetAll();

        void Update(Review review);

        void Delete(int id);
    }
}
