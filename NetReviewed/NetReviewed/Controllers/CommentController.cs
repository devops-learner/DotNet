using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NetReviewed.Models.Repository;
using NetReviewed.Models;

namespace NetReviewed.Controllers
{
    public class CommentController : ApiController
    {
        ICommentRepository _commentRepository;
        public CommentController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }  
        // POST api/comment
        public void Post(Comment comment)
        {
            _commentRepository.Add(comment);
        }
      }
}
