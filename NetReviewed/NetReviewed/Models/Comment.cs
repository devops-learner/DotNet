using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetReviewed.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public string Email { get; set; }
        public bool IsAnonymous { get; set; }
        public int ReviewId { get; set; }
        public Review Review { get; set; }
    }
}
