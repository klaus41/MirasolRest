using MirasolDAL;
using MirasolDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MirasolRest.Controllers
{
    public class UserController : ApiController
    {
        public IEnumerable<User> GetUsers()
        {
            try
            {
                return new Facade().GetUserReporitory().ReadAll();
            }
            catch
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }
    

        public User PostUser(User user)
        {
            var response = Request.CreateResponse<User>(HttpStatusCode.Created, user);
            new Facade().GetUserReporitory().Add(user);
            return user;
        }

        public User Get(int id)
        {
            User user = new Facade().GetUserReporitory().Find(id);
            if (user == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return user;
        }
    }
}