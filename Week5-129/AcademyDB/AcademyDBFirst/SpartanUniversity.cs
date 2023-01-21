using System;
using System.Collections.Generic;

namespace AcademyDBFirst
{
    public partial class SpartanUniversity
    {
        public int? SpartanId { get; set; }
        public int? UniversityId { get; set; }

        public virtual Spartan? Spartan { get; set; }
        public virtual University? University { get; set; }
    }
}
