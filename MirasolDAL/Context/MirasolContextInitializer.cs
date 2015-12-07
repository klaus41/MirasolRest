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

            User user1 = context.Users.Add(new User()
            {
                Id = 1,
                Address = "Strandbygade 46, 3.",
                Email = "klausgaarde@live.dk",
                Name= "Klaus Gaarde",
                Password = "240789" 
            });

            
            Apartment apartment1 = context.Apartments.Add(new Apartment() {
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
                PriceHighSeason = 750,
                PriceLowSeason = 550,
                PriceMiddleSeason = 650,
                Facilities = facility1
                
                 });


            Bookings booking1 = context.Bookings.Add(new Bookings()
            {
                Id = 1,
                Apartment = apartment1,
                EndDate = new DateTime(2015, 10, 10),
                StartDate = new DateTime (2015, 10, 17),
                User = user1,
            });

            foreach (Apartment apartment in apartments)
                context.Apartments.Add(apartment);
          


            base.Seed(context);
        }
    }
}
