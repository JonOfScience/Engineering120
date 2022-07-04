using System;

namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        int timeOfDay = 21;
        string greet = Greeting(timeOfDay);
        Console.WriteLine(greet);
    }

    public static string AvailableClassifications(int ageOfViewer)
    {
        string result;
        if (ageOfViewer < 12)
        {
            result = "U, PG & 12A films are available.";
        }
        else if (ageOfViewer < 15)
        {
            result = "U, PG, 12A & 12 films are available.";
        }
        else if (ageOfViewer < 18)
        {
            result = "U, PG, 12A, 12 & 15 films are available.";
        }
        else
        {
            result = "All films are available.";
        }
        return result;
    }


    public static string Greeting(int timeOfDay)
    {
        if ((timeOfDay < 1) || (timeOfDay > 24))
            throw new ArgumentOutOfRangeException();

        string greeting;
        if (timeOfDay >= 5 && timeOfDay < 12)
        {
            greeting = "Good morning!";
        }
        else if (timeOfDay >= 12 && timeOfDay <= 18)
        {
            greeting = "Good afternoon!";
        }
        else
        {
            greeting = "Good evening!";
        }
        return greeting;
    }
}