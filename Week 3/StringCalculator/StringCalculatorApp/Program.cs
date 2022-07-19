namespace CalculatorApp;

public class Program
{
    static void Main(string[] args)
    {
    }

    static public int Add(string numbers)
    {
        if (numbers.Length < 1)
        {
            return 0;
        }
        List<string> delimiters = new List<string> { ",", "\n" };
        int numDelimiters = 0;
        if (numbers.Length > 3 && numbers.Substring(0, 2) == "//")
        {
            int endOfDelimiter = numbers.IndexOf("\n");
            // Single character vs multicharacter - I want to do this by regex
            string delimeterString = numbers.Substring(2, endOfDelimiter - 2);
            delimiters[0] = delimeterString;
            if (delimeterString.Length > 1)
            {
                numDelimiters = delimeterString.Count(x => (x == '['));
                if (numDelimiters > 1)
                {
                    var allDelimiters = delimeterString.Split("][");
                    allDelimiters[0] = allDelimiters[0].Replace("[", "");
                    allDelimiters[allDelimiters.Length - 1] = allDelimiters[allDelimiters.Length - 1].Replace("]", "");
                    // Feed this string array back into "delimeter"
                }
                else
                    delimiters[0] = delimeterString.Substring(1, delimeterString.Length - 2);
            }
            numbers = numbers.Remove(0, endOfDelimiter);
        }

        Queue<string> oldQueue = new Queue<string>();
        oldQueue.Enqueue(numbers);

        Queue<string> newQueue = new Queue<string>();
        List<string> arrString;
        foreach (string delimiter in delimiters)
        {
            newQueue = new Queue<string>();
            while (oldQueue.Count > 0)
            {
                arrString = oldQueue.Dequeue().Split(delimiter).Where(x => x.Length > 0).ToList();
                arrString.ForEach(x => newQueue.Enqueue(x));
            }
            oldQueue = new Queue<string>(newQueue);
        }

        List<int> negative = new List<int>();
        int total = 0;
        while (oldQueue.Count > 0)
        {
            int.TryParse(oldQueue.Dequeue(), out int x);
            if (x < 0)
                negative.Add(x);
            if (x <= 1000)
                total += x;
        }
        if (negative.Count > 0)
        {
            throw new ArgumentOutOfRangeException($"negatives not allowed : {string.Join(',', negative)}");
        }
        return total;
    }
}
