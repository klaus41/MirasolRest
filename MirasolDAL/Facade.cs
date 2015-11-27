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

        public IRepository<Apartment> GetApartmentRepository()
        {
            if ( apartmentRepo == null)
            {
                apartmentRepo = new ApartmentRepository();
            }
            return apartmentRepo;
        }
    }
}
