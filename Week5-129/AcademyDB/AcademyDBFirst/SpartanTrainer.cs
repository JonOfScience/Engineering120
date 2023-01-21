using System;
using System.Collections.Generic;

namespace AcademyDBFirst
{
    public partial class SpartanTrainer
    {
        public int? SpartanId { get; set; }
        public int? TrainerId { get; set; }

        public virtual Spartan? Spartan { get; set; }
        public virtual Trainer? Trainer { get; set; }
    }
}
