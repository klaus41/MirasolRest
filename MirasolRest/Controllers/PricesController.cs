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
    public class PricesController : ApiController
    {
        public IEnumerable<Prices> GetPrices()
        {
            try
            {
                return new Facade().GetPricesRepository().ReadAll();
            }
            catch
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        public Prices PostPrices(Prices prices)
        {
            var reponse = Request.CreateResponse<Prices>(HttpStatusCode.Created, prices);
            new Facade().GetPricesRepository().Add(prices);
            return prices;
        }

        public Prices Get(int id)
        {
            Prices prices = new Facade().GetPricesRepository().Find(id);
            if (prices == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return prices;
        }
    }
}
