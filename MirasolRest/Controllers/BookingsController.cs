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
    public class BookingsController : ApiController
    {
        public IEnumerable<Bookings> GetBookings()
        {
            try
            {
                return new Facade().GetBookingsRepository().ReadAll();
            }
            catch
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }
        public Bookings PostBookings(Bookings bookings)
        {
            var response = Request.CreateResponse<Bookings>(HttpStatusCode.Created, bookings);
            new Facade().GetBookingsRepository().Add(bookings);
            return bookings;
        }

        public Bookings Get(int id)
        {
            Bookings bookings = new Facade().GetBookingsRepository().Find(id);
            if (bookings == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return bookings;
        }
    }
}
