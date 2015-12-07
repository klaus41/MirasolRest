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
    public class BookingsController : ApiController
    {
        public IEnumerable<Bookings> GetBookings()
        {
            return new Facade().GetBookingsRepository().ReadAll();
        }
        public BookingsDTO PostBookings(BookingsDTO dto)
        {
            return dto;
        }

        public Bookings Get(int id)
        {
            return new Facade().GetBookingsRepository().Find(id);
        }
    }
}
