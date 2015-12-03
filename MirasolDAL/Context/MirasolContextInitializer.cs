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
            IList<Apartment> apartments = new List<Apartment>();

            Facilities facility1 = context.Facilities.Add(new Facilities()
            {
                Id = 1,
                Inside = "Wi-Fi, air conditioning, heating, tv, intercom, iron, ironing board",
                Kitchen = "Dishwasher, freezer, fridge, coffee machine, washing machine, dryer, hob, microwave, oven, kettle, toaster",
                Bathroom = "Shower, bath tub, hair dryer",
                Beds = "1 Double bed",
                Views = "Sea views, mountain views, pool views",
                SuitableFor = "Suitable for the elderly, pets not allowed, no smoking inside, car necessary",
            });

            
            apartments.Add(new Apartment() {
                Address = "Torrox Costa 1202",
                Bedrooms = 1,
                Sleeps = 2,
                Bathrooms = 1,
                LivingArea = 70,
                Terrace = 55,
                WiFi = true,
                Balcony = true,
                Garden = true,
                TerraceFurniture = true,
                AirCondition = true,
                Heating = true,
                Facilities = facility1
                
                 });

            foreach (Apartment apartment in apartments)
                context.Apartments.Add(apartment);
          
            base.Seed(context);
        }
    }
}
