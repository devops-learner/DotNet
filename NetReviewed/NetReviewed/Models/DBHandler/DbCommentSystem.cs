using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using NetReviewed.Models;
using System.Configuration;

namespace NetReviewed.Models.DBHandler
{
    public class DbCommentSystem : ObjectContext
    {
        private ObjectSet<Review> _reviews;
        private ObjectSet<Comment> _comments;
        private ObjectSet<Category> _categorys;

        static string ConnectionInfo {
            get { return ConfigurationManager.ConnectionStrings["CommentSystemCS"].ConnectionString; }
        
        }

        public DbCommentSystem()
            : base("name=DbCommentSystemContainer", "DbCommentSystemContainer")
        {

            _categorys = CreateObjectSet<Category>();
            _comments = CreateObjectSet<Comment>();
            _reviews = CreateObjectSet<Review>();
            
            if (!this.DatabaseExists())
            {
                this.CreateDatabase();
            }
        }

        public ObjectSet<Review> Reviews     { get{return _reviews;} }                                                  
        public ObjectSet<Category> Categorys { get{return _categorys;} }
        public ObjectSet<Comment> Comments { get { return _comments; } }
    }
}
