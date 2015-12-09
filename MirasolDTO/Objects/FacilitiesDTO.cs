using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDTO.Objects
{
    [DataContract(IsReference = true)]
    public class FacilitiesDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Inside { get; set; }
        [DataMember]
        public string Kitchen { get; set; }
        [DataMember]
        public string Bathroom { get; set; }
        [DataMember]
        public string Beds { get; set; }
        [DataMember]
        public string Views { get; set; }
        [DataMember]
        public string SuitableFor { get; set; }

        [DataMember]
        public string Notes { get; set; }
        [DataMember]
        public string General { get; set; }
        [DataMember]
        public string Outside { get; set; }


    }
}
