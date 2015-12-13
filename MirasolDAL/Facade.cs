using MirasolDAL.DomainModel;
using MirasolDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDAL
{
    public class Facade
    {
        private IRepository<Apartment> apartmentRepo;
        private IRepository<Facilities> facilityRepo;
        private IRepository<User> userRepo;
        private IRepository<Bookings> bookingsRepo;
        private IRepository<Address> addressRepo;
        private IRepository<Prices> pricesRepo;

        public IRepository<Apartment> GetApartmentRepository()
        {
            if ( apartmentRepo == null)
            {
                apartmentRepo = new ApartmentRepository();
            }
            return apartmentRepo;
        }

        public IRepository<Facilities> GetFacilitiesRepository()
        {
            if ( facilityRepo == null)
            {
                facilityRepo = new FacilityRepository();
            }
            return facilityRepo;
        }

        public IRepository<User> GetUserReporitory()
        {
            if( userRepo == null)
            {
                userRepo = new UserRepository();
            }
            return userRepo;
        }
        public IRepository<Bookings> GetBookingsRepository()
        {
            if(bookingsRepo == null)
            {
                bookingsRepo = new BookingsRepository();
            }
            return bookingsRepo;
        }

        public IRepository<Address> GetAddressRepository()
        {
            if (addressRepo == null)
            {
                addressRepo = new AddressRepository();
            }
            return addressRepo;
        }

        public IRepository<Prices> GetPricesRepository()
        {
            if (pricesRepo == null)
            {
                pricesRepo = new PricesRepository();
            }
            return pricesRepo;
        }
        
    }
}
