using System;
using System.Collections.Generic;

namespace AcademyDBFirst
{
    public partial class University
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string City { get; set; } = null!;
        public string? Country { get; set; }
    }
}
