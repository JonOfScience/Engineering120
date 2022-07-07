namespace CodeKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

        }

        public static char[] FindDuplicateCharacters(string text)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n' };
            List<char> duplicates = new List<char>();
            int letter_count;
            foreach (char letter in alphabet)
            {
                letter_count = 0;
                foreach (char letterIn in text)
                {
                    if (letterIn == letter)
                        letter_count++;
                }
                if (letter_count > 1)
                {
                    duplicates.Add(letter);
                }

            }
            return duplicates.ToArray();
        }
    }
}