using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace TermProjectV1.Models
{
    public class Member
    {
        [Key]
        public int ID { get; set; }
        //changed from id
        [Required]
        //if column name deleted, the migration error appears for migration that doesn't exist any more??
        [Column("Member Full Name")]
        [Display(Name ="First Name")]
        [StringLength(50,ErrorMessage ="Please enter the member full name using 30 characters or less.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        public string name { get; set; }       
        
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Please enter the member full name using 30 characters or less.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        public string LastName { get; set; }

        [Display(Name = "Gender")]
        public string gender { get; set; }
        [StringLength(50,ErrorMessage ="Please enter your address using 50 characters or less.")]

        [Display(Name = "Address")]
        public string address { get; set; }
        [StringLength(30,ErrorMessage ="Please enter your city using 30 characters or less.")]

        [Display(Name = "City")]
        public string city { get; set; }
        [StringLength(2,ErrorMessage ="Please enter your 2 character state abbreviation.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabetic letters are allowed.")]

        [Display(Name = "State")]
        public string state { get; set; }
        [StringLength(10,ErrorMessage ="Zipcode has a max length of 10 characters.")]
        
        [Display(Name = "Zipcode")]
        [RegularExpression(@"^(?!0+$)[0-9]{5,5}$", ErrorMessage = "Please enter your 5 digit zipcode.")]
        public string zip { get; set; }

        [Display(Name = "Email")]
        [RegularExpression(@"^(([^<>()[\]\\.,;:\s@""]+(\.[^<>()[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$",
            ErrorMessage = "Please enter a valid email.")]
        public string email { get; set; }

        [Display(Name = "Cellphone Number")]
        [RegularExpression(@"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})", ErrorMessage = "Please enter your phone number i.e 231-988-8888.")]
        public string cell { get; set; }

        //Nvaigation property
        //public ICollection<MemberReference> MemberReferences { get; set; }
    }
}
