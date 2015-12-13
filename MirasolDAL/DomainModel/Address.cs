using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDAL.DomainModel
{
    [DataContract(IsReference = true)]
    [Table("Address")]
    public class Address
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Required]
        [MaxLength(4)]
        public int HouseNr { get; set; }
        [DataMember]
        public int Floor { get; set; }
        [DataMember]
        [Required]
        public string StreetName { get; set; }
        [DataMember]
        [Required]
        public int ZipCode { get; set; }
        [DataMember]
        [Required]
        public string City { get; set; }
        [DataMember]
        [Required]
        public string Country { get; set; }

    }
}
