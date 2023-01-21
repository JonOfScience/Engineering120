using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyDBFirst;

public partial class Spartan
{
    public override string ToString()
    {
        using (var db = new AcademyContext())
        {
            string streamName = db.Streams.Find(Stream).Name;
            return $"{Title} {FirstName} {LastName} - {streamName} stream - {Course} cohort";
        }
    }

    public bool isTheSameAs(Spartan anotherSpartan)
    {
        bool isIdentical = false;
        //REFACTOR TO EQUALS OVERRIDE METHOD
        //if (Title != anotherSpartan.Title) return false;
        if (FirstName != anotherSpartan.FirstName) return false;
        if (LastName != anotherSpartan.LastName) return false;

        return true;
    }
}
