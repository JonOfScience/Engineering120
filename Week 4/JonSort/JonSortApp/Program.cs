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

            int changes;
            int _temp;
            do
            {
                changes = 0;
                for (int idx = 0; idx < (input.Length - 1); idx++)
                {
                    if (input[idx] > input[idx + 1])
                    {
                        _temp = input[idx];
                        input[idx] = input[idx + 1];
                        input[idx + 1] = _temp;
                        changes++;
                    }
                }

            } while (changes > 0);

            return input;
        }
    }
}