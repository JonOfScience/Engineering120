using System;
using System.Collections.Generic;

namespace AcademyDBFirst
{
    public partial class StreamTrainer
    {
        public int? StreamId { get; set; }
        public int? TrainerId { get; set; }

        public virtual Stream? Stream { get; set; }
        public virtual Trainer? Trainer { get; set; }
    }
}
