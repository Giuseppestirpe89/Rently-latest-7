using System;
using System.ComponentModel.DataAnnotations;

namespace Rently.Models
{
    public class Customer
    {
        public int Id { get; set; }

        //data annotation for name
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        //data annotation for the form 
        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

    }
}