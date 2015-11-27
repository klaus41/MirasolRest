using MirasolDAL.Context;
using MirasolDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDAL.Repository
{
    public class ApartmentRepository : IRepository<Apartment>
    {
        
        public void Add(Apartment t)
        {
            using (var ctx = new MirasolContext())
            {
                ctx.Apartments.Add(t);
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Apartment t = Find(id);
            using (var ctx = new MirasolContext())
            {
                ctx.Apartments.Attach(t);
                ctx.Apartments.Remove(t);
                ctx.SaveChanges();
            }
        }

        public Apartment Find(int id)
        {
            foreach (var item in ReadAll())
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Apartment> ReadAll()
        {
            using (var ctx = new MirasolContext())
            {
                return ctx.Apartments.ToList();
            }
        }

        public void Update(Apartment t)
        {
            using (var ctx = new MirasolContext())
            {
                foreach (var apartment in ReadAll())
                {
                    if (t.Id == apartment.Id)
                    {
                        apartment.Address = t.Address;
                        apartment.HouseNumber = t.HouseNumber;
                    }
                }
            }
        }
    }
}
