using System.Diagnostics;
namespace CodeKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            double zeroSol = TestIt(ZeroFindDuplicates);
            double firstSol = TestIt(FirstFindDuplicates);
            double secondSol = TestIt(SecondFindDuplicates);

            Console.WriteLine("Solutions");
            Console.WriteLine($"Zero   {zeroSol}");
            Console.WriteLine($"First  {firstSol}");
            Console.WriteLine($"Second {secondSol}");
            Console.WriteLine();
            Console.WriteLine("Comparators");
            Console.WriteLine($"Zero/First   {zeroSol / firstSol}");
            Console.WriteLine($"First/Second {firstSol / secondSol}");
            Console.WriteLine($"Zero/Second {zeroSol / secondSol}");

        }

        public static double TestIt(Func<string, char[]> functionToTest)
        {
            const int TESTS = 1000000;
            long[] testData = new long[TESTS];
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < TESTS; i++)
            {
                sw.Start();
                functionToTest("Nish Mandal");
                sw.Stop();
                testData[i] = sw.ElapsedTicks;
                sw.Reset();
            }
            // Console.WriteLine("[{0}]", string.Join(", ", testData));
            // Console.WriteLine(testData[2..(TESTS - 1)].Average());
            return testData[2..(TESTS - 1)].Average();
        }

        public static char[] ZeroFindDuplicates(string text)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
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

        public static char[] FirstFindDuplicates(string text)
        {
            List<char> letters = new List<char>();
            List<char> duplicates = new List<char>();
            foreach (char letterIn in text.ToLower())
                if (!duplicates.Contains(letterIn))
                {
                    if (letters.Contains(letterIn))
                    {
                        duplicates.Add(letterIn);
                        letters.Remove(letterIn);
                    }
                    else
                    {
                        letters.Add(letterIn);
                    }
                }
            duplicates.Sort();
            return duplicates.ToArray();
        }

        public static char[] SecondFindDuplicates(string text)
        {
            int[] counts = new int[256];
            List<char> duplicates = new List<char>();
            foreach (char letterIn in text.ToLower())
                counts[(int)letterIn] += 1;
            for (int i = 97; i < 123; i++)
                if (counts[i] > 1)
                    duplicates.Add((char)i);
            return duplicates.ToArray();
        }
    }
}