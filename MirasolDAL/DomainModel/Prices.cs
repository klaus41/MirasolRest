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
    [Table("Prices")]
    public class Prices
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int FinalCleaning { get; set; }
        [DataMember]
        public int LinenAndTowels { get; set; }
        [DataMember]
        public int BeachTowels { get; set; }
        [DataMember]
        public int LowSeason { get; set; }
        [DataMember]
        public int MidSeason { get; set; }
        [DataMember]
        public int HighSeason { get; set; }
    }
}
