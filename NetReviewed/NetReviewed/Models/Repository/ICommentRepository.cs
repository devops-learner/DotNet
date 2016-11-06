using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetReviewed.Models.Repository
{
    public interface ICommentRepository
    {
        void Add(Comment comment);

        IEnumerable<Comment> GetAll();

    }
}
