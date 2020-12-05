using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TermProjectV1.Models
{
    public class MemberReference
    {
        //Composite Primary key and foreign key for Member 
        public int MemberID { get; set; }
        //Composite Primary key and foreign key for reference 
        public int ReferenceID { get; set; }

        //navigation properties
        public Member Member { get; set; }
        public Reference Reference { get; set; }
    }
}
