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
            public int HouseNumber { get; set; }
        }
    }
