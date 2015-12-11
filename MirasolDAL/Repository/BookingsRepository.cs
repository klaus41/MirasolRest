using MirasolDAL.Context;
using MirasolDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDAL.Repository
{
    public class BookingsRepository : IRepository<Bookings>
    {
        public void Add(Bookings t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("t");
            }
            using (var ctx = new MirasolContext())
            {
                ctx.Bookings.Add(t);
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Bookings t = Find(id);
            using (var ctx = new MirasolContext())
            {
                ctx.Bookings.Attach(t);
                ctx.Bookings.Remove(t);
                ctx.SaveChanges();
            }
        }

        public Bookings Find(int id)
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

        public List<Bookings> ReadAll()
        {
            using (var ctx = new MirasolContext())
            {
                return ctx.Bookings.ToList();
            }
        }

        public void Update(Bookings t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("t");
            }
            throw new NotImplementedException();
        }
    }
}
