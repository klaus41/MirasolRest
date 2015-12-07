using MirasolDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDTO.Objects
{
    [DataContract(IsReference = true)]
    public class BookingsDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Apartment Apartment { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public User User { get; set; }
    }
}
