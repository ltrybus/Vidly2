using System;
using System.ComponentModel.DataAnnotations;

namespace vidly2.Models
{
    public class Customers
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? DOB { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

    }
}