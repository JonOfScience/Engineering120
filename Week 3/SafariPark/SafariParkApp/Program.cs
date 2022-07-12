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
            Hunter maks = new Hunter("Maks", "Hadys", "Sony") { Age = 10 };
            Console.WriteLine(maks.Age);
            Console.WriteLine(maks.Shoot());
            #endregion

        }

        public static void DemoMethod(Point3d pt, Person p)
        {
            pt.x = 100;
            p.Age = 100;
        }
    }
}