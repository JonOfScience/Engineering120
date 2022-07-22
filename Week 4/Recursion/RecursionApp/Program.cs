namespace RecursionApp;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SumLoop(100));
        Console.WriteLine(SumRecursive(100)); //A
        Console.WriteLine(FactorialRecursive(16));
    }

    public static int SumRecursive(int n)
    {
        if (n == 0) return 0;        
        int prev = SumRecursive(n - 1);
        int sum = n + prev;
        return sum;
    }

    public static int SumLoop(int n)
    {
        int sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    public static int FactorialRecursive(int n)
    {
        if (n < 1 || n > 16) throw new ArgumentOutOfRangeException("n has to be between 1 and 16");
        if (n == 1) return 1;
        int prev = FactorialRecursive(n - 1);
        int fact = n * prev;
        return fact;
    }
}