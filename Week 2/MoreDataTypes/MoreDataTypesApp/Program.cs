using System.Text;

namespace MoreDataTypesApp
{
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

            Console.WriteLine(StringExercise(" C# list fundamentals "));
            #endregion

            #region StringBuilder
            Console.WriteLine(StringBuilderExercise(" C# list fundamentals "));
            #endregion

            #region String Interpolation
            string a = "A";
            string b = "B";
            string aAndB = a + b;
            Console.WriteLine(aAndB);
            aAndB = String.Concat(a, b);
            Console.WriteLine(aAndB);
            string[] arrayOfStrings = { "hello", "world" };
            Console.WriteLine(String.Concat(arrayOfStrings));
            char[] arrayOfChars = { 'a', 'b', 'c' };
            Console.WriteLine(String.Concat(arrayOfChars));
            Console.WriteLine("Your blood type is " + a + b + ".");
            Console.WriteLine($"Your blood type is {a}{b.ToLower()}.");

            int num1 = 2;
            int num2 = 7;
            string logOfNum1Num2 = $"The log to base {num1} of {num2} is {Math.Log(num2, num1):N3}";
            Console.WriteLine(logOfNum1Num2);
            string money = $"The change is {(num2 - num1):C}";
            Console.WriteLine(money);
            #endregion

            #region String parsing
            ParsingStrings();
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