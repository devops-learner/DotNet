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
    public class CategoryController : ApiController
    {
        ICategoryRepository _categoryRepository;
        // GET api/category
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        
        public IEnumerable<Category> Get()
        {
            return _categoryRepository.GetAll(); 
            
            }

        // GET api/category/5
        public Category Get(int id)
        {
            return _categoryRepository.Get(id);
        }

        // POST api/category
        public void Post(Category category)
        {
            _categoryRepository.Add(category);
        }

    }
}
