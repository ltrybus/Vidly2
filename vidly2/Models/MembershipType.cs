using System;
using System.ComponentModel.DataAnnotations;

namespace vidly2.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        [Required]
        public string MembershipDescription { get; set; }


        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}