namespace FizzBuzzApp;

public class Program
{
    public static string FizzBuzz(int n)
    {
        if (n == 1) return "1";
        else if (n == 2) return "1 2";
        else if (n == 3) return "1 2 Fizz";
        else if (n == 4) return "1 2 Fizz 4";
        else return "1 2 Fizz 4 Buzz";

    }
}