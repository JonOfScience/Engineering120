namespace Lambda_LessonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 3, 7, 1, 2, 8, 3, 0, 4, 5 };

            //// Declarative
            //int allCount = nums.Count();

            //// Imperative approach
            //int allCountAlt = 0;
            //foreach (var num in nums)
            //{
            //    allCountAlt++;
            //}

            //// Method within a Method
            //int allCountAlt = 0;
            //foreach (var num in nums)
            //{
            //    if (isEven(num))
            //        allCountAlt++;
            //}

            //int allEven = nums.Count(isEven);

            //// Anonymous method
            //// DO NOT USE ANONYMOUS METHODS - JUST TO ILLUSTRATE LINQ
            //int allDEvens = nums.Count(delegate (int n) { return n % 2 == 0; });

            //// ?
            //int allMEvens = nums.Count(x => x % 2 == 0);

            // int allEventsLinq = nums.Where(x => x % 2 == 0).Count();

            var people = new List<Person>
            {
                new Person{Name="Nish", Age=40, City="Birmingham"},
                new Person{Name="Cathy", Age=20, City="Ottawa"},
                new Person{Name="Peter", Age=55, City="London"}
            };

            int countYoungPeople = people.Count(IsYoung);
            int countYoungPeopleLambda = people.Count(p => p.Age < 30);

            int totalAge = people.Sum(p => p.Age);


            //// Using a Lambda Expression, in 1 line
            //// Find the total age of people older than or equal to 30
            //int totalOldAge = people.Sum(x => (x.Age >= 30) ? x.Age : 0);
            
            var londonPeopleQuery = people.Where(p => p.City == "London");
            foreach (var p in londonPeopleQuery)
                Console.WriteLine(p);

            //ORDER BY
            // var peopleOrderByAge = people.OrderBy(x => x.Age).OrderByDescending(x => x.Name);

            //SELECT
            //var londonAges = people.Where(p => p.City == "London").Select(x => x.Age);

            //Anonymous Types (no methods, no fields, only public read-only properties)
            var employee = new { Age = 30, Name = 12 };

            // OO or Relational approach
            // For read only purposes
            var anon = people.Select(x => new { Fullname = x.Name });


            
        }

        public static bool IsYoung(Person p)
        {
            return p.Age < 30;
        }

        public static bool isEven(int n)
        {
            return n % 2 == 0;
        }
    }
} 