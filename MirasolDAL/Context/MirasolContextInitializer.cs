using MirasolDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDAL.Context
{
    public class MirasolContextInitializer : DropCreateDatabaseAlways<MirasolContext>
    {
        protected override void Seed(MirasolContext context)
        {
            Apartment apart1 = context.Apartments.Add(new Apartment() { Id = 1, Address = "Address 1", HouseNumber = 1 });
            Apartment apart2 = context.Apartments.Add(new Apartment() { Id = 2, Address = "Address 2", HouseNumber = 2 });

            base.Seed(context);
        }
    }
}
