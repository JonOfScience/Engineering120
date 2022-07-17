namespace ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var nish = new Person("Nish", "Mandal") { Age = 22 };
            //var david = nish;
            //Console.WriteLine(nish.Equals(david)); // True because they have the same memory address
            //var tom = new Person("Nish", "Mandal") { Age = 22 };
            //Console.WriteLine(nish.Equals(tom)); // False because not at the same memory address
            //Console.WriteLine(nish.GetHashCode());
            //Console.WriteLine(david.GetHashCode());
            //Console.WriteLine(tom.GetHashCode());
            //var bob = new Person("Bob", "Builder") { Age = 25 };

            //var people = new List<Person>
            //{
            //    new Person("Cath", "Cookson"),
            //    new Person("Bob", "Builder") { Age = 25},
            //    new Person("Dan", "Dare"),
            //    new Person("Amy", "Andrews") { Age = 32}
            //};

            // Is there a person named Bob Builder in the list?
            //var hasBob = people.Where(x => x.GetFullName() == "Bob Builder").Any();
            // Hacky way but relies on method names

            //bool hasBob2 = people.Contains(bob); // This will give false unless Equals and GetHashCpde

            //var hasBob2 = people.Contains(bob);
            //people.ForEach(x => Console.WriteLine(x.GetFullName()));
            //people.Sort();
            //Console.WriteLine();
            //people.ForEach(x => Console.WriteLine(x.GetFullName()));
            //nish.CompareTo(bob);

            // people.OrderBy(x => x.Age); // CAN'T USE PRIVATE FIELDS WHILE USING LINQ


            #region Queues (FIFO)
            //// Look Dequeue (return and remove first element), Enqueue (add to the end of the queue), Peek (return but NOT remove first element)
            //var myQueue = new Queue<string>();
            //myQueue.Enqueue("Helen");
            //myQueue.Enqueue("Will");
            //myQueue.Enqueue("David");

            //Console.WriteLine("Queue\n");
            //foreach (var name in myQueue)
            //    Console.WriteLine(name);

            //var first = myQueue.Peek();
            //Console.WriteLine(first);
            //// The queue still has all elements in it

            //var serve = myQueue.Dequeue();
            //Console.WriteLine(serve);
            //// The queue has now been shortened
            #endregion

            #region Stack (LIFO)
            //// Peek, Push (push something onto the stack), and Pop (take the top item off the stack)
            //var myStack = new Stack<int>();
            //int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            //int[] numsReversed = new int[nums.Length];
            //foreach (var num in nums)
            //    myStack.Push(num);

            //for (int i = 0; i < numsReversed.Length; i++)
            //    numsReversed[i] = myStack.Pop();
            #endregion

            #region HashSet
            //var peopleSet = new HashSet<string>() { "Bob Dylan", "James Brown", "Ella Fitzgerald" };
            //bool added = peopleSet.Add("Bob Dylan");
            //bool alsoAdded = peopleSet.Add("Helen of Troy");
            //foreach (var name in peopleSet)
            //    Console.WriteLine(name);
            //Console.WriteLine( added + " " + alsoAdded );

            //var morePeople = new HashSet<string>() { "Cathy French", "Princess Jasmine", "Ella Fitzgerald" };

            //// Will overwrite peopleSet with result
            //peopleSet.IntersectWith(morePeople);

            var vehicleSet = new HashSet<Vehicle>
            {
                new Vehicle(3, 2) {NumPassengers = 3 },
                new Vehicle(3, 100)
            };

            var success = vehicleSet.Add(new Vehicle(3, 100));
            // Will pass as hash codes are different
            #endregion

            #region Dictionaries
            //var vehicleDict = new Dictionary<string, Vehicle>
            //{
            //    { "Saloon", new Vehicle(4, 80) },
            //    { "Sports Car", new Vehicle(2, 160)}
            //};
            //var v = vehicleDict["Saloon"];
            //vehicleDict.Add("Passenger Jet", new Vehicle(300, 800));

            string input = "The cat in the hat comes back";
            input = input.Trim().ToLower();
            var countDict = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (countDict.ContainsKey(c))
                {
                    countDict[c]++;
                } else
                {
                    countDict.Add(c, 1);
                }
            }
            Console.WriteLine("\nDictionary Problem");
            foreach(var entry in countDict)
            {
                Console.WriteLine(entry);
            }

            foreach(var key in countDict.Keys)
            {
                Console.Write($"Key {key}, ");
            }

            foreach (var value in countDict.Values)
            {
                Console.Write($"Value {value}, ");
            }

            #endregion
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