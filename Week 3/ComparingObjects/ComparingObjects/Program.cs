namespace ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nish = new Person("Nish", "Mandal") { Age = 22 };
            //var david = nish;
            //Console.WriteLine(nish.Equals(david)); // True because they have the same memory address
            //var tom = new Person("Nish", "Mandal") { Age = 22 };
            //Console.WriteLine(nish.Equals(tom)); // False because not at the same memory address
            //Console.WriteLine(nish.GetHashCode());
            //Console.WriteLine(david.GetHashCode());
            //Console.WriteLine(tom.GetHashCode());
            var bob = new Person("Bob", "Builder") { Age = 25 };

            var people = new List<Person>
            {
                new Person("Cath", "Cookson"),
                new Person("Bob", "Builder") { Age = 25},
                new Person("Dan", "Dare"),
                new Person("Amy", "Andrews") { Age = 32}
            };
            // Is there a person named Bob Builder in the list?
            //var hasBob = people.Where(x => x.GetFullName() == "Bob Builder").Any();
            // Hacky way but relies on method names

            //bool hasBob2 = people.Contains(bob); // This will give false unless Equals and GetHashCpde

            var hasBob2 = people.Contains(bob);
            people.ForEach(x => Console.WriteLine(x.GetFullName()));
            people.Sort();
            Console.WriteLine();
            people.ForEach(x => Console.WriteLine(x.GetFullName()));
            nish.CompareTo(bob);

            // people.OrderBy(x => x.Age); // CAN'T USE PRIVATE FIELDS WHILE USING LINQ

        }
    }

    public class Person : IEquatable<Person?>, IComparable<Person?>

    {
        private string _firstName;
        private string _lastName;
        private int _age;
        public Person() { }
        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        public int CompareTo(Person? other)
        {
            if (other == null) return 1;
            if (this._lastName != other._lastName)
            {
                return this._lastName.CompareTo(other._lastName);
            }
            else if (this._firstName != other._lastName)
            {
                return this._firstName.CompareTo(other._firstName);
            }
            else
            {
                return this._age.CompareTo(other._age);
            }
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return other is not null &&
                   _firstName == other._firstName &&
                   _lastName == other._lastName &&
                   Age == other.Age;
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_firstName, _lastName, _age, Age);
        }

        public static bool operator ==(Person? left, Person? right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person? left, Person? right)
        {
            return !(left == right);
        }
    }
}