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
        public DbSet<Facilities> Facilities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
    }
}
