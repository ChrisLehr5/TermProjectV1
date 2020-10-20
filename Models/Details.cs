using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TermProjectV1.Models
{
    public class Details
    {
        public int ID { get; set; }
        //changed from ID

        [Display(Name = "Date of Membership")]
        public DateTime detailDate { get; set; } = DateTime.Now;

        [Display(Name = "Member Age")]
        [Range(16,110, ErrorMessage ="Please enter an age between 16 and 110 years old.")]
        public int age { get; set; }
        [Required]
        public int MemberID { get; set; }
        public Member Member { get; set; }
    }
}
