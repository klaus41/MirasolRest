using MirasolDAL.Context;
using MirasolDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDAL.Repository
{
    public class PricesRepository : IRepository<Prices>
    {
        public void Add(Prices t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("t");
            }
            using (var ctx = new MirasolContext())
            {
                ctx.Prices.Add(t);
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Prices t = Find(id);
            using (var ctx = new MirasolContext())
            {
                ctx.Prices.Attach(t);
                ctx.Prices.Remove(t);
                ctx.SaveChanges();
            }
        }

        public Prices Find(int id)
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

        public List<Prices> ReadAll()
        {
            using (var ctx = new MirasolContext())
            {
                return ctx.Prices.ToList();
            }
        }

        public void Update(Prices t)
        {
            throw new NotImplementedException();
        }
    }
}
