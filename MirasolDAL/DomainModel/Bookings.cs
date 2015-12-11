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
    [Table("Bookings")]
    public class Bookings
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public Apartment Apartment { get; set; }
        [DataMember]
        [Required]
        [DataType("date")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [DataMember]
        [Required]
        [DataType("date")]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [DataMember]
        [Required]
        public User User { get; set; }

    }
}