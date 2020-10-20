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
        [Display(Name = "Reference ID")]
        public int ReferenceId { get; set; }

        [Display(Name = "Reference Full Name")]
        [StringLength(30, ErrorMessage = "Please enter the reference full name using 30 characters or less.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        public string Name { get; set; }


        [Display(Name = "Associated Member ID")]
        [Required(ErrorMessage ="Please enter a member id.")]
        public int ID { get; set; }
      
    }
}
