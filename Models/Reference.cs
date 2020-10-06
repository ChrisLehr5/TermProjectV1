using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TermProjectV1.Models
{
    public class Reference
    {
        public int ReferenceId { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter a member id.")]
        public int ID { get; set; }
      
    }
}
