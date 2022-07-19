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
            if (i % 15 == 0)
                fizzBuzzReturn += "FizzBuzz";
            else if (i % 3 == 0)
                fizzBuzzReturn += "Fizz";
            else if (i % 5 == 0)
                fizzBuzzReturn += "Buzz";
            else
                fizzBuzzReturn += $"{i}";
            
            //if (i > 1)
            //{
            //    fizzBuzzReturn += " ";
            //}

        }
        return fizzBuzzReturn;
    }
}