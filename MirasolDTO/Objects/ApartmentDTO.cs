using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

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
        public string Pool { get; set; }
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
        
    }
}
    
