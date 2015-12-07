using MirasolDAL;
using MirasolDAL.DomainModel;
using MirasolDTO.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MirasolRest.Controllers
{
    public class FacilitiesController : ApiController
    {
        public IEnumerable<Facilities> GetFacilities()
        {
            return new Facade().GetFacilitiesRepository().ReadAll();
        }

        public FacilitiesDTO PostFacilities(FacilitiesDTO dto)
        {
            return dto;
        }

        public Facilities Get(int id)
        {
            return new Facade().GetFacilitiesRepository().Find(id);
        }
    }
}
