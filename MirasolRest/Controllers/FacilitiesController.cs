using MirasolDAL;
using MirasolDAL.DomainModel;
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
            try
            {
                return new Facade().GetFacilitiesRepository().ReadAll();
            }
            catch
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        public Facilities PostFacilities(Facilities facilities)
        {
            var response = Request.CreateResponse<Facilities>(HttpStatusCode.Created, facilities);
            new Facade().GetFacilitiesRepository().Add(facilities);
            return facilities;
        }

        public Facilities Get(int id)
        {
            Facilities facility = new Facade().GetFacilitiesRepository().Find(id);
            if (facility == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return facility;
        }
    }
}
