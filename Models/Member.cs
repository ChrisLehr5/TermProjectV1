using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TermProjectV1.Models
{
    public class Member
    {
        public int ID { get; set; }
        [Required]
        [StringLength(30,ErrorMessage ="Please enter the member full name using 30 characters or less.")]
        public string name { get; set; }
        public string gender { get; set; }
        [StringLength(50,ErrorMessage ="Please enter your address using 50 characters or less.")]
        public string address { get; set; }
        [StringLength(30,ErrorMessage ="Please enter your city using 30 characters or less.")]
        public string city { get; set; }
        [StringLength(2,ErrorMessage ="Please enter your 2 character state abbreviation.")]
        public string state { get; set; }
        [StringLength(10,ErrorMessage ="Zipcode has a max length of 10 characters.")]
        public string zip { get; set; }
        public string email { get; set; }
        public string cell { get; set; }

    }
}
