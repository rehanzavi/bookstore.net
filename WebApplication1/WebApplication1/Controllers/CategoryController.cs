using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoryController : ApiController
    {
        private ICategoryRepository repository;

        public CategoryController()
        {
            repository = new CategorySqlImp();

        }
        [HttpGet]
        public IHttpActionResult Get(int catId)
        {
            var data = repository.GetCategoryByID(catId);
            if (data == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }

        }

        [HttpGet]

        public IHttpActionResult Get()
        {
            var data = repository.GetAllCategory();
            return Ok(data);
        }



        [HttpPost]
        public IHttpActionResult Post(Category category)
        {
            var data = repository.AddCategory(category);
            var data1 = repository.GetAllCategory();
            return Ok(data1);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int catId)
        {
            repository.DeleteCategory(catId);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Put(Category category)
        {
            repository.UpdateCategory(category);
            return Ok();

        }

    }
}
