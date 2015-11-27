using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDAL.DomainModel
{
    [DataContract(IsReference = true)]
    [Table("Apartment")]
    public class Apartment
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public int HouseNumber { get; set; }


    }
}
