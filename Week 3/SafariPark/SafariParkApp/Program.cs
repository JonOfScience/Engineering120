using SafariParkApp.Misc;

namespace SafariParkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Constructors
            //Person jon = new Person("Jon", "Crofts", 22);
            //jon.Age = 23;
            //Console.WriteLine(jon.GetFullName());
            //Person charlie = new Person("Charlie");

            //Person bob = new Person();
            #endregion

            #region Object Initializers
            //Person dan = new Person("Dan", "Summerside") { Age = 100 };
            //Person laba = new Person { FirstName = "Laba", LastName = "Limbu", Age = 33 };

            //var shop1 = new Shopping { Ties = 3, Shirts = 3, Trousers = 1 };
            //var shop2 = new Shopping { Socks = 10 };
            #endregion

            #region Immutable properties
            //var kai = new Spartan { FullName = "Kai", Course = "C# SDET", PersonalId = 999 };
            //kai.PersonalId = 998;
            #endregion

            #region Structs
            //Point3d p3d;
            //p3d.x = 2;

            //Point3d pt = new Point3d(3, 6, 2);
            //Person jon = new Person("Jon", "Crofts", 22);
            //DemoMethod(pt, jon);
            #endregion

            #region Inheritance
            //Hunter maks = new Hunter("Maks", "Hadys", "Sony") { Age = 10 };
            //Console.WriteLine(maks.Age);
            //Console.WriteLine(maks.Shoot());
            #endregion

            #region The Object Class
            //Hunter maks = new Hunter("Maks", "Hadys", "Sony") { Age = 10 };
            //Hunter maksEvilTwin = new Hunter("Maks", "Hadys", "Sony") { Age = 10 };
            //Person dan = new Person("Dan", "Daaboul") { Age = 1 };
            //Console.WriteLine($"H1 equals H2? {maks.Equals(dan)}");
            //var maks2 = maks;
            //Console.WriteLine(maks.GetHashCode());
            //Console.WriteLine(maks2.GetHashCode());
            //Console.WriteLine(dan.GetHashCode());
            //Console.WriteLine(1.GetHashCode());
            //Console.WriteLine(1.GetHashCode());
            //Console.WriteLine(maks.GetType());
            //Console.WriteLine($"Maks equals Evil Twin? {maks.Equals(maksEvilTwin)}");
            //Console.WriteLine(maksEvilTwin.GetHashCode());
            //Console.WriteLine(maks.ToString());
            #endregion

            #region Abstract Classes
            //var rect = new Rectangle(1, 2);
            //Console.WriteLine(rect.CalculateArea());
            #endregion


            //Airplane a = new Airplane(200, 100, "JetsRUs")
            //    { NumPassengers = 150 };
            //a.Ascend(500);
            //Console.WriteLine(a.Move(3));
            //Console.WriteLine(a);
            //a.Descend(200);
            //Console.WriteLine(a.Move());
            //a.Move();
            //Console.WriteLine(a);

            //var ellis = new Hunter("Ellis", "Witten", "Nikon") { Age = 21 };
            //var plane = new Airplane(400, 200, "Virgin");
            //var vehicle = new Vehicle(20, 20);
            //var kenny = new Person("Kenny", "Harvey") { Age = 22 };
            //List<Object> gameObjs = new List<object>
            //{
            //    ellis, plane, vehicle, kenny
            //};
            //foreach (var gameObj in gameObjs)
            //{
            //    Console.WriteLine(gameObj);
            //}
            // SpartaWrite(ellis);

            /* HOMEWORK
            var bob = new Person("Bob", "Fleming") { Age = 67 };
            var chris = new Person("Chris", "Jackson") { Age = 24 };
            var bike = new Vehicle(1, 12);
            var warthog = new Airplane(1, 460, "USAF");
            List<IMovable> moveables = new List<IMovable>
            {
                bob, chris, bike, warthog
            };
            foreach (IMovable moveable in moveables)
            {
                Console.WriteLine(moveable.Move());
            }
            */

            /* LISTS
            List<Person> peopleList = new List<Person>() { new Person("Nish", "Mandal") { Age = 32 } };
            var kai = new Person("Kai", "Chan");
            var tom = new Person("Tom", "W");

            peopleList.Add(tom);

            var newerList = new List<Person>();
            newerList.AddRange(peopleList);
            newerList.Add(kai);

            peopleList.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            newerList.ForEach(x => Console.WriteLine(x));
            */

            List<int> list = new List<int>() { 5, 4, 3, 9, 0 };
            list.Add(8);
            list.Sort();
            list.RemoveRange(1, 2);
            list.Insert(2, 1);
            list.Reverse();
            list.Remove(9);
            Console.WriteLine("({0})" , string.Join(", ", list));
        }

        public static void SpartaWrite(Object obj)
        {
            Console.WriteLine(obj);
            if (obj is Hunter)
            {
                var hunterObj = (Hunter)obj;
                Console.WriteLine(hunterObj.Shoot());
            }
        }

        public static void DemoMethod(Point3d pt, Person p)
        {
            pt.x = 100;
            p.Age = 100;
        }
    }
}