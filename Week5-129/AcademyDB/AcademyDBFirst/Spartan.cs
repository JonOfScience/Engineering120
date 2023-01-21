using System;
using System.Collections.Generic;

namespace AcademyDBFirst
{
    public partial class Spartan
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Course { get; set; }
        public string? GradeAchieved { get; set; }
        public string CityOfResidence { get; set; } = null!;
        public DateTime DateJoined { get; set; }
        public int Stream { get; set; }
        public bool? HasGraduated { get; set; }
        public bool? IsOnSite { get; set; }
        public int? OnSiteAt { get; set; }
    }
}
