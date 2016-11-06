using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NetReviewed.Models.Repository;
using NetReviewed.Models;

namespace NetReviewed.Controllers
{
    public class ReviewController : ApiController
    {

        public ReviewController(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
        // GET api/review
        public IEnumerable<Review> Get()
        {
            return _reviewRepository.GetAll();
        }

        // GET api/review/5
        public HttpResponseMessage Get(int id)
        {
            var review = _reviewRepository.Get(id);
            return review == null ? Request.CreateResponse(HttpStatusCode.NotFound) : Request.CreateResponse(HttpStatusCode.Created, review);
        }

        // POST api/review
        public HttpResponseMessage Post(Review review)
        {
            var response = Request.CreateResponse(HttpStatusCode.Created, review);
            // Get the url to retrieve the newly created review.
            response.Headers.Location = new Uri(Request.RequestUri, string.Format("reviews/{0}", review.ReviewId));
            _reviewRepository.Add(review);
            return response;
    
        }

        // PUT api/review/5
        public void Put(Review review)
        {
            _reviewRepository.Update(review);
        }

        // DELETE api/review/5
        public HttpResponseMessage Delete(int id)
        {
            _reviewRepository.Delete(id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

        private IReviewRepository _reviewRepository { get; set; }
    }
}
