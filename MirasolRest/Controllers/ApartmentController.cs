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
    public class ApartmentController : ApiController
    {
        public IEnumerable<Apartment> GetApartments()
        {

                return new Facade().GetApartmentRepository().ReadAll();

        }

        public Apartment PostApartment(Apartment apartment)
        {
            var response = Request.CreateResponse<Apartment>(HttpStatusCode.Created, apartment);
            new Facade().GetApartmentRepository().Add(apartment);
            return apartment;
        }

        public Apartment Get(int id)
        {
            Apartment apartment = new Facade().GetApartmentRepository().Find(id);
            if (apartment == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return apartment;
        }
    }
}
