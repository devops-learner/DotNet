using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetReviewed.Models.Repository
{
    public interface ICategoryRepository
    {
        Category Get(int id);

        void Add(Category category);

        IEnumerable<Category> GetAll();

    }
}
