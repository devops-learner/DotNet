using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetReviewed.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Content { get; set; }
        public string Topic { get; set; }
        public string Email { get; set; }
        public bool IsAnonymous { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}