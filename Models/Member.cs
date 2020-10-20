using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TermProjectV1.Models
{
    public class Member
    {
        public int ID { get; set; }
        //changed from id
        [Required]
        [Column("Member Full Name")]
        [Display(Name ="Full Name")]
        [StringLength(30,ErrorMessage ="Please enter the member full name using 30 characters or less.")]
        public string name { get; set; }

        [Display(Name = "Gender")]
        public string gender { get; set; }
        [StringLength(50,ErrorMessage ="Please enter your address using 50 characters or less.")]

        [Display(Name = "Address")]
        public string address { get; set; }
        [StringLength(30,ErrorMessage ="Please enter your city using 30 characters or less.")]

        [Display(Name = "City")]
        public string city { get; set; }
        [StringLength(2,ErrorMessage ="Please enter your 2 character state abbreviation.")]

        [Display(Name = "State")]
        public string state { get; set; }
        [StringLength(10,ErrorMessage ="Zipcode has a max length of 10 characters.")]
        
        [Display(Name = "Zipcode")]
        public string zip { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Cellphone Number")]
        public string cell { get; set; }

    }
}
