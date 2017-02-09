using System;
using System.ComponentModel.DataAnnotations;
using Rently.Models;

namespace Rently.Dtos
{
    //data tansfer object exclude the properties that can be updated
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }


        //        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}