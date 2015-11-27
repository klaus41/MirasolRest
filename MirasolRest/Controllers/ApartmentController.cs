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
    public class ApartmentController : ApiController
    {
        public IEnumerable<Apartment> GetApartments()
        {
            return new Facade().GetApartmentRepository().ReadAll();
        }

        public ApartmentDTO PostApartment(ApartmentDTO dto)
        {
            return dto;
        }

        public Apartment Get(int id)
        {
            return new Facade().GetApartmentRepository().Find(id);
        }
    }
}
