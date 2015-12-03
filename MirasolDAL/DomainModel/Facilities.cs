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
    [Table("Facilities")]
    public class Facilities
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Inside{ get; set; }
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


    }
}
