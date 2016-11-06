using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetReviewed.Models.Repository
{
    public class CommentRepository:ICommentRepository
    {
        DBHandler.DbCommentSystem dbContext = new DBHandler.DbCommentSystem();
        public void Add(Comment comment)
        {
            dbContext.Comments.AddObject(comment);
            dbContext.SaveChanges();
        }

        public IEnumerable<Comment> GetAll()
        {
            return dbContext.Comments;
        }
    }
}
