using System;

namespace CSharpIntroduction;

public class Program
{
    public static void Main(string[] args)
    {
        //int x = 100;
        //x += 10;
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine(i);
        //    x += i;
        //}
        Console.WriteLine("Writing out our command line arguments");
        foreach (var arg in args)
        {
            Console.WriteLine(arg);
        }
    }
}
