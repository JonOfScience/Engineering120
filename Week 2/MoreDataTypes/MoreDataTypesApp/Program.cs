using System.Text;

namespace MoreDataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //String message = "I like donuts";
            //Console.WriteLine(message);
            //string newMessage = message.Insert(message.Length, " Actually, I like pies");
            //Console.WriteLine(newMessage);
            //string[] lines = { "Add", " ", "These", " ", "Words" };
            //string newnew = String.Concat(lines);
            //Console.WriteLine(newnew);

            Console.WriteLine(StringExercise(" C# list fundamentals "));
            Console.WriteLine(StringBuilderExercise(" C# list fundamentals "));
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