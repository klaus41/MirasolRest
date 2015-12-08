using MirasolDAL.Context;
using MirasolDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDAL.Repository
{
    public class UserRepository : IRepository<User>
    {
        public void Add(User t)
        {
            using (var ctx = new MirasolContext())
            {
                ctx.Users.Add(t);
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            User t = Find(id);
            using (var ctx = new MirasolContext())
            {
                ctx.Users.Attach(t);
                ctx.Users.Remove(t);
                ctx.SaveChanges();
            }
        }

        public User Find(int id)
        {
            foreach (var item in ReadAll())
            {
                if(item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<User> ReadAll()
        {
            using (var ctx = new MirasolContext())
            {
                return ctx.Users.ToList();
            }
        }

        public void Update(User t)
        {
            throw new NotImplementedException();
        }
    }
}
