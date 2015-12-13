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
    [Table("User")]
    public class User
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public string Name { get; set; }
        [DataMember]
        public Address Address { get; set; }
        [DataMember]
        [Display(Name = "E-mail address")]
        [EmailAddress]
        public string Email { get; set; }
        [DataMember]
        [MinLength(6, ErrorMessage = "The password must be at least 6 characters long")]
        public string Password { get; set; }
    }
}
