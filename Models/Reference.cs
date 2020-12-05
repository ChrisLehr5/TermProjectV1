using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TermProjectV1.Models
{
    public class Reference
    {
       [Key]
        public int ID { get; set; }
        [Display(Name = "Reference ID")]
        public int ReferenceId { get; set; }

        [Display(Name = "Reference First Name")]
        [StringLength(30, ErrorMessage = "Please enter the reference full name using 30 characters or less.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        public string Name { get; set; }


        [Display(Name = "Reference Last Name")]
        [StringLength(30, ErrorMessage = "Please enter the reference full name using 30 characters or less.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        public string LastName { get; set; }

        //Navigation property
        //public ICollection<MemberReference> MemberReferences { get; set; }

    }
}
