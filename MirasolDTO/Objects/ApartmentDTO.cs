using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using MirasolDAL.DomainModel;

namespace MirasolDTO.Objects
{
    [DataContract(IsReference = true)]
    public class ApartmentDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public int Bedrooms { get; set; }
        [DataMember]
        public int Sleeps { get; set; }
        [DataMember]
        public int Bathrooms { get; set; }
        [DataMember]
        public int Toilets { get; set; }
        [DataMember]
        public int LivingArea { get; set; }
        [DataMember]
        public int Terrace { get; set; }
        [DataMember]
        public bool SharedPool { get; set; }
        [DataMember]
        public bool PrivatePool { get; set; }
        [DataMember]
        public string Jacuzzi { get; set; }
        [DataMember]
        public bool WiFi { get; set; }
        [DataMember]
        public bool RoofTerrace { get; set; }
        [DataMember]
        public bool Garden { get; set; }
        [DataMember]
        public bool TerraceFurniture { get; set; }
        [DataMember]
        public bool Satellite { get; set; }
        [DataMember]
        public bool Balcony { get; set; }
        [DataMember]
        public bool AirCondition { get; set; }
        [DataMember]
        public bool Heating { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string PicturePath { get; set; }
        [DataMember]
        public int PriceLowSeason { get; set; }
        [DataMember]
        public int PriceMiddleSeason { get; set; }
        [DataMember]
        public int PriceHighSeason { get; set; }
        [DataMember]
        public bool OutsideJacuzzi { get; set; }
        [DataMember]
        public virtual Facilities Facilities { get; set; }




    }
}
    
