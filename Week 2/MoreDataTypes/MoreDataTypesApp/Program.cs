using System.Diagnostics;
using System.Text;

namespace MoreDataTypesApp
{
    public enum PokemonType
    {
        GRASS, FIRE, ELEC, WATER
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Strings and String Methods
            //Console.WriteLine("Hello, World!");
            //String message = "I like donuts";
            //Console.WriteLine(message);
            //string newMessage = message.Insert(message.Length, " Actually, I like pies");
            //Console.WriteLine(newMessage);
            //string[] lines = { "Add", " ", "These", " ", "Words" };
            //string newnew = String.Concat(lines);
            //Console.WriteLine(newnew);

            //Console.WriteLine(StringExercise(" C# list fundamentals "));
            #endregion

            #region StringBuilder
            // Console.WriteLine(StringBuilderExercise(" C# list fundamentals "));
            #endregion

            #region String Interpolation
            //string a = "A";
            //string b = "B";
            //string aAndB = a + b;
            //Console.WriteLine(aAndB);
            //aAndB = String.Concat(a, b);
            //Console.WriteLine(aAndB);
            //string[] arrayOfStrings = { "hello", "world" };
            //Console.WriteLine(String.Concat(arrayOfStrings));
            //char[] arrayOfChars = { 'a', 'b', 'c' };
            //Console.WriteLine(String.Concat(arrayOfChars));
            //Console.WriteLine("Your blood type is " + a + b + ".");
            //Console.WriteLine($"Your blood type is {a}{b.ToLower()}.");

            //int num1 = 2;
            //int num2 = 7;
            //string logOfNum1Num2 = $"The log to base {num1} of {num2} is {Math.Log(num2, num1):N3}";
            //Console.WriteLine(logOfNum1Num2);
            //string money = $"The change is {(num2 - num1):C}";
            //Console.WriteLine(money);
            #endregion

            #region String parsing
            //ParsingStrings();
            #endregion

            #region Arrays
            //// 1D Arrays
            //int[] arrayOfInts = new int[10];
            //arrayOfInts[4] = 6;

            //int[] anotherArrayOfInts = { 1, 2, 3, 4, 5 };
            //string sparta = "SpartaGlobal";
            //var spartaArray = sparta.ToCharArray();

            //var anotherSparta = "Hello,Hi,Hola,Hallo,Hej";
            //var annotherArray = anotherSparta.Split(','); // Takes a regex expression for separator

            //// 2D Arrays
            //int[,] grid = new int[2, 4];
            //grid[0, 1] = 6;
            //grid[1, 3] = 8;

            //foreach (var element in grid)
            //{
            //    Console.WriteLine(element);
            //}

            //string[,] chessboard = {
            //    { "pawn", "king" }, 
            //    { "blank", "blank" }, 
            //    { "enemy king", "enemy pawn" }
            //};
            //int lower1D = chessboard.GetLowerBound(0);
            //int lower2D = chessboard.GetLowerBound(1);
            //int upper1D = chessboard.GetUpperBound(0);
            //int upper2D = chessboard.GetUpperBound(1);
            //string theBoard = "";
            //for (int i = lower1D; i <= upper1D + 1; i++)
            //{
            //    for (int j = lower2D; i <= upper2D + 1; i++)
            //    {
            //        theBoard += $"{chessboard[i, j]} is at {i} and {j}\n";
            //    }
            //}
            //Console.WriteLine(theBoard);

            //// Jagged Arrays
            //int[][] jaggedIntArray = new int[2][];
            //jaggedIntArray[0] = new int[4];
            //jaggedIntArray[1] = new int[2];

            //jaggedIntArray[0][3] = 666;

            //jaggedIntArray[0] = new int[] { 1, 2, 3, 4 };

            //foreach (int[] innerArray in jaggedIntArray)
            //{
            //    foreach (int element in innerArray)
            //    {
            //        Console.WriteLine(element);
            //    }
            //}
            #endregion

            #region DateTime
            ////var now = DateTime.Now;
            ////Console.WriteLine(now);
            ////var tomorrow = now.AddDays(1);
            ////Console.WriteLine(tomorrow);

            //var nishBDay = new DateOnly(1989, 11, 2);

            //var now2 = DateOnly.FromDateTime(DateTime.Now);

            //var stopwatch = new Stopwatch();
            //stopwatch.Start();
            //int total = 0;
            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    total += i;
            //}
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed);
            #endregion

            #region Enums

            //PokemonType type = PokemonType.FIRE;
            //if (type == PokemonType.WATER) Console.WriteLine("Water is the type.");
            //else if (type == PokemonType.FIRE) Console.WriteLine("Fire is the type.");

            //switch (type)
            //{
            //    case PokemonType.ELEC:
            //        Console.WriteLine("Bzzt!");
            //        break;
            //    case PokemonType.GRASS:
            //        Console.WriteLine("The worst type.");
            //        break;
            //    case PokemonType.FIRE:
            //        Console.WriteLine($"Beats {PokemonType.GRASS}");
            //        break;
            //    default:
            //        Console.WriteLine("No type found :(");
            //        break;
            //}
            //var poke = (int)PokemonType.GRASS;
            //var poke2 = (PokemonType)3;
            //Console.WriteLine(poke);
            //Console.WriteLine(poke2);

            //var anotherType = Enum.Parse(typeof(PokemonType), "WATER");
            //Console.WriteLine(anotherType);

            #endregion

        }

        public static void ParsingStrings()
        {
            Console.WriteLine("How many cars do you own?");
            string input = Console.ReadLine();
            //int numOfCars = Int32.Parse(input);
            var success = Int32.TryParse(input, out int numOfCars);
            Console.WriteLine(numOfCars);
            Console.WriteLine(success);
        }


        public static string StringExercise(string myString)
        {
            myString = myString.Trim();
            myString = myString.ToUpper();
            myString = myString.Replace('L', '*');
            myString = myString.Replace('T', '*');
            //char[] replaceCharacters = { 'L', 'T' };
            //foreach (char c in replaceCharacters)
            //    myString = myString.Replace(c, '*');
            int nIndex = myString.IndexOf('N');
            string result = myString.Remove(nIndex + 1);
            // string result = myString.Substring(0, nIndex + 1);
            return result;
        }

        public static string StringBuilderExercise(string myString)
        {
            string ucTrimmedString = myString.Trim().ToUpper();
            int nPos = ucTrimmedString.IndexOf('N');
            StringBuilder sb = new StringBuilder(ucTrimmedString);
            sb.Replace('L', '*').Replace('T', '*');
            sb.Remove(nPos + 1, sb.Length - nPos - 1);
            return sb.ToString();
        }
    }
}