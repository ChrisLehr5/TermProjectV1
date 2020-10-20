using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TermProjectV1.Models
{
    public class Reference
    {
        [Display(Name = "Associated Member ID")]
        public int ReferenceId { get; set; }

        [Display(Name = "Reference Full Name")]
        public string Name { get; set; }

        
        [Required(ErrorMessage ="Please enter a member id.")]
        public int ID { get; set; }
      
    }
}
