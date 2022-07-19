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
                    var allDelimiters = delimeterString.Split(']', '[', StringSplitOptions.RemoveEmptyEntries);
                }
                else
                    delimiters[0] = delimeterString.Substring(1, delimeterString.Length - 2);
            }
            numbers = numbers.Remove(0, endOfDelimiter);
        }
        
        foreach (string delimiter in delimiters)
        {
            numbers = numbers.Replace(delimiter, delimiters[0]);
        }
        string[] arrString = numbers.Split(delimiters[0]).Where(x => x.Length > 0).ToArray();

        List<int> negative = new List<int>();
        int total = 0;
        foreach (string element in arrString)
        {
            int.TryParse(element, out int x);
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
