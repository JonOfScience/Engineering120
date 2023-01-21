using System;
using System.Collections.Generic;

namespace AcademyDBFirst
{
    public partial class Site
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string City { get; set; } = null!;
        public string ContactName { get; set; } = null!;
        public string ContactNumber { get; set; } = null!;
    }
}
