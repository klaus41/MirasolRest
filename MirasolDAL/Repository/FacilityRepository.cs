using MirasolDAL.Context;
using MirasolDAL.DomainModel;
using MirasolDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDAL.Repository
{
    class FacilityRepository : IRepository<Facilities>
    {
        public void Add(Facilities t)
        {
            using (var ctx = new MirasolContext())
            {
                ctx.Facilities.Add(t);
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Facilities t = Find(id);
            using (var ctx = new MirasolContext())
            {
                ctx.Facilities.Attach(t);
                ctx.Facilities.Remove(t);
                ctx.SaveChanges();
            }
        }

        public Facilities Find(int id)
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

        public List<Facilities> ReadAll()
        {
            using (var ctx = new MirasolContext())
            {
                return ctx.Facilities.ToList();
            }
        }

        public void Update(Facilities t)
        {
            throw new NotImplementedException();
        }
    }
}
