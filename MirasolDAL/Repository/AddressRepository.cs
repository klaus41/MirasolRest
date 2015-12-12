using MirasolDAL.Context;
using MirasolDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDAL.Repository
{
    public class AddressRepository : IRepository<Address>
    {
        public void Add(Address t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("t");
            }
            using (var ctx = new MirasolContext())
            {
                ctx.Addresses.Add(t);
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Address t = Find(id);
            using (var ctx = new MirasolContext())
            {
                ctx.Addresses.Attach(t);
                ctx.Addresses.Remove(t);
                ctx.SaveChanges();
            }
        }

        public Address Find(int id)
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

        public List<Address> ReadAll()
        {
            using (var ctx = new MirasolContext())
            {
                return ctx.Addresses.ToList();
            }
        }

        public void Update(Address t)
        {
            throw new NotImplementedException();
        }
    }
}
