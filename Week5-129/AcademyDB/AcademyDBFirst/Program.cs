namespace AcademyDBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AcademyContext())
            {
                db.Spartans.ToList().ForEach(s => Console.WriteLine(s));
            }
            Console.WriteLine();

            int rowsChanged = ValidateDB();
        }

        static int ValidateDB()
        {
            int rowsChanged = 0;
            using (var db = new AcademyContext())
            {
                List<string> nameList = new List<string>() {
                    "Charles Batten",
                    "Jonathan Crofts",
                    "Kai Chan"
                };
                foreach (string searchName in nameList)
                {
                    Spartan spartan = BuildSpartan(searchName);
                    var records = db.Spartans.Where(s => ((s.FirstName == spartan.FirstName) && (s.LastName == spartan.LastName)));
                    if (records.Count() > 0)
                    {
                        Console.WriteLine($"{searchName} was found");
                        // CHECK TO SEE IF DATA MATCHES BASE DATA OTHERWISE UPDATE
                    }
                    else
                    {
                        Console.WriteLine($"{searchName} was not found");
                        // AddSpartan(searchName);
                        rowsChanged++;
                    }
                }
            }
            return rowsChanged;
        }

        static Spartan BuildSpartan(string fullName)
        {
            string[] names = fullName.Split(' ');
            Spartan newSpartan = new Spartan() { FirstName = names[0], LastName = names[1] };
            return newSpartan;
        }

        static void AddSpartan(string newNames)
        {
            // IS DEPENDENT ON AN IMPLEMENTATION DETAIL PASS IN A SPARTAN OBJECT
            string[] names = newNames.Split(' ');
            var newSpartan = new Spartan()
            {
                FirstName = names[0],
                LastName = names[1],
            };
            using (var db = new AcademyContext())
            {
                db.Add(newSpartan);
                db.SaveChanges();
            }
        }

    }
}