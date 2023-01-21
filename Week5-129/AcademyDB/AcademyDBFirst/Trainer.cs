using System;
using System.Collections.Generic;

namespace AcademyDBFirst
{
    public partial class Trainer
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
