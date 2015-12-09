using MirasolDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDAL.Context
{
    public class MirasolContextInitializer : DropCreateDatabaseIfModelChanges<MirasolContext>
    {
        protected override void Seed(MirasolContext context)
        {
           

            Facilities facility1 = context.Facilities.Add(new Facilities()
            {
                Id = 1,
                Inside = "Wi-Fi, air conditioning, heating, tv, intercom, iron, ironing board",
                Kitchen = "Dishwasher, freezer, refridgerator, coffee machine, washing machine, dryer, hob, microwave, oven, kettle, toaster",
                Bathroom = "Shower, bath tub, hair dryer",
                Beds = "1 Double bed",
                Views = "Sea views, mountain views, pool views",
                SuitableFor = "Suitable for the elderly, pets not allowed, no smoking inside, car necessary",
            });

            Facilities facility2 = context.Facilities.Add(new Facilities()
            {
                Id = 2,
                Inside = "Wi-fi, air conditioning, heating, tv, intercom, iron, ironing board",
                Kitchen = "Dishwasher, freezer, refridgerator, coffee machine, washing machine, dryer, hob, oven, kettle, toaster",
                Bathroom = "Shower, bath tub, hair dryer",
                Beds = "2 double beds (1 extra mattress)",
                Views = "Sea views, mountan views, pool views",
                SuitableFor = "Suitable for the elderly, pets not allowed, no smoking inside, car necessary"
            });

            Facilities facility3 = context.Facilities.Add(new Facilities()
            {
                Id = 3,
                Inside = "Wi-fi, air conditioning, heating, washing machine, tv, intercom, iron, ironing board",
                Kitchen = "Dishwasher, freezer, refridgerator, coffee machine, hob, oven, kettle, toaster",
                Bathroom = "Jacuzzi, shower, bath tub, hair dryer",
                Beds = "2 double beds",
                Views = "Sea views, mountain views, pool views",
                SuitableFor = "Wheelchair accessible, suitable for the elderly, pets not allowed, no smoking inside, car not neccessary",
                Notes = "There is sleeping accomodation for 2 extra people on air mattress in the living room"
            });

            Facilities facility4 = context.Facilities.Add(new Facilities()
            {
                Id = 4,
                General = "Linen provided, towels provided",
                Outside = "Shared pool, outside jacuzzi, garden, terrace, terrace furniture, sunbeds, barbeque, parking, private parking, garage, lift",
                Inside = "Wi-fi, sattelite, air conditioning, heating, washing machine, tv, iron, ironing board, children's high chair, cradle",
                Kitchen = "Dishwasher, freezer, refridgerator, coffee machine, hob, oven, kettle, toaster",
                Bathroom = "Shower, bath tub, hair dryer",
                Beds = "2 double beds",
                Views = "Sea views, mountain views, pool views",
                SuitableFor = "pets not allowed, no smoking inside, car not ncessary"
            });

            Facilities facility5 = context.Facilities.Add(new Facilities()
            {
                Id = 5,
                General = "Linen provided, towels included",
                Outside = "Shared pool, private pool, roof terrace, garden, terrace, terrace furniture, parking, private parking, garage, lift",
                Inside = "Wi-Fi, air conditioning, heatin, washing machine, tv, tumble dryer, ceiling fan, intercom, iron, ironing board, children's high chair, cradle",
                Kitchen = "Dishwasher, freezer, refridgerator, coffee machine, hob, microwave, oven, toaster",
                Bathroom = "Shower, bath tub, hair dryer",
                Beds = "1 double bed, 4 single beds",
                SuitableFor = "Pets not allowed, no smoking inside, car not necessary"
            });

            Facilities facility6 = context.Facilities.Add(new Facilities()
            {
                Id = 6,
                General = "Linen provided, towels provided",
                Outside = "Shared pool, outside jacuzzi, roof terrace, terrace, terrace furniture, sunbeds, barbeque, parking, private parking, garage, lift",
                Inside = "Wi-Fi, sattelite, air conditioning, heating, dvd player, washing machine, tv, intercom, iron, ironing board, children's high chair, cradle",
                Kitchen = "Dishwasher, freezer, refridgerator, coffee machine, hob, microwave, oven, blender, toaster",
                Bathroom = "Jacuzzi, shower, bath tub, hair  dryer",
                Beds = "4 single beds, 2 sofa beds",
                Views = "Sea views, mountain views, pool views",
                SuitableFor = "Pets not allowed, no smoking inside, car not necessary"
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
                Address = "Torrox Costa (Calaceite)",
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
                Facilities = facility1,
                Name = "1202"
                 });

            Apartment apartment2 = context.Apartments.Add(new Apartment()
            {
                Address = "Torrox Costa (Calaceite)",
                Bedrooms = 2,
                Bathrooms = 2,
                Sleeps = 5,
                LivingArea = 90,
                Terrace = 24,
                SharedPool = true,
                WiFi = true,
                Balcony = true,
                Garden = true,
                TerraceFurniture = true,
                AirCondition = true,
                Heating = true,
                Facilities = facility2,
                Name = "5332"
            });

            Apartment apartment3 = context.Apartments.Add(new Apartment()
            {
                Address = "El Penoncillo Beach",
                Bedrooms = 2,
                Sleeps = 4,
                Bathrooms = 2,
                LivingArea = 90,
                Terrace = 30,
                SharedPool = true,
                WiFi = true,
                Balcony = true,
                Garden = true,
                TerraceFurniture = true,
                AirCondition = true,
                Heating = true,
                Facilities = facility3,
                Name = "13436"
            });

            Apartment apartment4 = context.Apartments.Add(new Apartment()
            {
                Address = "El Penoncillo Beach",
                Bedrooms = 2,
                Sleeps = 4,
                Bathrooms = 2,
                LivingArea = 80,
                Terrace = 72,
                SharedPool = true,
                OutsideJacuzzi = true,
                WiFi = true,
                Garden = true,
                TerraceFurniture = true,
                Satellite = true,
                AirCondition = true,
                Facilities = facility4,
                Name = "19946"
            });

            Apartment apartment5 = context.Apartments.Add(new Apartment()
            {
                Address = "El Penoncillo Beach",
                Bedrooms = 3,
                Sleeps = 7,
                Bathrooms = 2,
                Toilets = 1,
                LivingArea = 120,
                Terrace = 40,
                SharedPool = true,
                PrivatePool = true,
                WiFi = true,
                RoofTerrace = true,
                Garden = true,
                TerraceFurniture = true,
                Facilities = facility5,
                Name = "22176"
            });

            Apartment apartment6 = context.Apartments.Add(new Apartment()
            {
                Address = "El Penoncillo Beach",
                Bedrooms = 3,
                Sleeps = 6,
                Bathrooms = 2,
                LivingArea = 80,
                Terrace = 72,
                SharedPool = true,
                OutsideJacuzzi = true,
                WiFi = true,
                RoofTerrace = true,
                Garden = true,
                TerraceFurniture = true,
                Satellite = true,
                Facilities = facility6,
                Name = "17576"
            });

            Bookings booking1 = context.Bookings.Add(new Bookings()
            {
                Id = 1,
                Apartment = apartment1,
                EndDate = new DateTime(2015, 10, 10),
                StartDate = new DateTime (2015, 10, 17),
                User = user1,
            });

           
            base.Seed(context);
        }
    }
}
