using System.Text;

namespace PalindromeApp
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool IsPalindrome(string stringToCheck)
        {
            if (stringToCheck.Length == 0) throw new ArgumentException();
            if (stringToCheck.Length == 1) return true;

            StringBuilder cleanedString = new StringBuilder();
            foreach (char element in stringToCheck.ToLower())
                if (element >= 97 && element <= 122) cleanedString.Append(element);

            if (cleanedString.Length % 2 != 0) cleanedString.Remove( cleanedString.Length / 2 , 1);

            Stack<char> frontHalf = new Stack<char>();
            for (int idx = 0; idx < cleanedString.Length / 2; idx++)
                frontHalf.Push(cleanedString[idx]);

            for (int idx = cleanedString.Length / 2; idx < cleanedString.Length; idx++)
                if (frontHalf.Pop() != cleanedString[idx]) return false;

            return true;
        }
    }
}