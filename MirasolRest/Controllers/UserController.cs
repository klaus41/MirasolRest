using MirasolDAL;
using MirasolDAL.DomainModel;
using MirasolDTO.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MirasolRest.Controllers
{
    public class UserController : ApiController
    {
        public IEnumerable<User> GetUsers()
        {
            return new Facade().GetUserReporitory().ReadAll();
        }

        public UserDTO PostUser(UserDTO dto)
        {
            return dto;
        }

        public User Get(int id)
        {
            return new Facade().GetUserReporitory().Find(id);
        }
    }
}