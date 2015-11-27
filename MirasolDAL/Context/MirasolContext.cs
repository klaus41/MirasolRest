using MirasolDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDAL.Context
{
    public class MirasolContext : DbContext
    {
        public MirasolContext() : base("MirasolDB")
        {
            Database.SetInitializer(new MirasolContextInitializer());
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Apartment> Apartments { get; set; }
    }
}
