namespace JonSortApp
{
    public class Sorter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int[] BubbleSort(int[] input)
        {
            if (input.Length < 1) throw new ArgumentException("Input must contain at least one element");
            if (input.Length == 1) return input;
            if (input.All(x => x == input[0])) return input;

            int changes = 0;
            do
            {

            } while (changes > 0);

            return new int[] { -1 };
        }
    }
}