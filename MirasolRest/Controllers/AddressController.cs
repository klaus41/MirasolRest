using MirasolDAL;
using MirasolDAL.DomainModel;
using MirasolDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MirasolRest.Controllers
{
    public class AddressController : ApiController
    {
        public IEnumerable<Address> GetAdresses()
        {
            try
            {
                return new Facade().GetAddressRepository().ReadAll();
            }
            catch
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        public Address PostAddress(Address address)
        {
            var response = Request.CreateResponse<Address>(HttpStatusCode.Created, address);
            new Facade().GetAddressRepository().Add(address);
            return address;
        }

        public Address Get(int id)
        {
            Address address = new Facade().GetAddressRepository().Find(id);
            if (address == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return address;
        }
    }
}
