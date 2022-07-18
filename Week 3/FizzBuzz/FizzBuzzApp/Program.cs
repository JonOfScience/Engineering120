namespace FizzBuzzApp;

public class Program
{
    public static string FizzBuzz(int n)
    {
        string fizzBuzzReturn = string.Empty;
        for (int i = 1; i <= n; i++) 
        {
            if (i > 1)
                fizzBuzzReturn += " ";
            if (i % 3 == 0)
            {
                fizzBuzzReturn += "Fizz"; 
            }
            else if (i % 5 == 0)
            {
                fizzBuzzReturn += "Buzz";
            }
            else
            {
                fizzBuzzReturn += $"{i}";
            }
        }
        //if (n == 1) return "1";
        //else if (n == 2) return "1 2";
        //else if (n == 3) return "1 2 Fizz";
        //else if (n == 4) return "1 2 Fizz 4";
        //else return "1 2 Fizz 4 Buzz";
        return fizzBuzzReturn;
    }
}