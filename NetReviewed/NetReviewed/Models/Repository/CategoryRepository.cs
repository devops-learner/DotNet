using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetReviewed.Models.DBHandler;

namespace NetReviewed.Models.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        DbCommentSystem dbContext = new DbCommentSystem();
        

        public Category Get(int id)
        {
         return  dbContext.Categorys.Where(c => c.CategoryId == id).First();
        }

        public void Add(Category category)
        {
            dbContext.Categorys.AddObject(category);
            dbContext.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return dbContext.Categorys;
        }
    }
}
