using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : ApiController
    {
        private IUserRepository repository;

        public UserController()
        {
            repository = new UserSqpImp();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var data = repository.GetAllUser();
            return Ok(data);
        }
   
        [HttpPost]
        public IHttpActionResult Post(Users user)
        {
            var data = repository.AddUser(user);
            return Ok(data);

        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            repository.DeleteUser(id);
            return Ok();

        }
    }
}
