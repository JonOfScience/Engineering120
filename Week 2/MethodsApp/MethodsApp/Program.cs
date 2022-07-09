namespace MethodsApp;

internal class Program
{
    static void Main(string[] args)
    {
        #region Methods
        //var result = DoThis(10, "Decent");

        //var spartaPizza = OrderPizza(pepperoni: true, kiwi:true, jalapenos: true, chicken: true);
        //Console.WriteLine(spartaPizza);
        //Console.WriteLine(Add(1, 2));
        //Console.WriteLine(Add(1, 2, 3));
        #endregion

        #region Tuples
        //var myTuple = ("Kai", "Chan", 60);
        //(string fName, string lName, int age)myTuple2 = ("Kai", "Chan", 60);
        //var myTuple3 = (title: "Lord of the Rings", copies: 3);
        //Console.WriteLine(myTuple);
        //Console.WriteLine(myTuple.Item1);
        //Console.WriteLine(myTuple2.fName);
        //Console.WriteLine(myTuple3.title);

        //var result = ConvertPoundsToStones(78);
        //Console.WriteLine($"{result.stones} st. {result.lbs} lbs.");
        #endregion

        // By Ref, By Var and the "out" keyword
        //var result2 = DoThat(11, "Hello", out bool z);
        int number = 10;
        Subtract(number);
        Console.WriteLine(number);
        Subtract(ref number);
        Console.WriteLine(number);
    }

    public static void Subtract(int num)
    {
        num--;
    }

    public static void Subtract(ref int num)
    {
        num--;
    }


    public static int DoThat(int x, string y, out bool z)
    {
        Console.WriteLine(y);
        z = (x > 10);
        return x * x;
    }

    public static (int stones, int lbs) ConvertPoundsToStones(int pounds)
    {
        // stones and pounds
        var stones = pounds / 14;
        var lbs = pounds % 14;
        return (stones, lbs);
    }

    public static int DoThis(int x, string y = "sad")
    {
        Console.WriteLine($"I'm feeling {y}");
        return x * x;
    }

    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }


    public static string OrderPizza(bool pepperoni, bool chicken, bool jalapenos, bool kiwi = false)
    {
        var pizza = "Pizza with tomato sauce, cheese";
        if (pepperoni) pizza += ", pepperoni";
        if (chicken) pizza += ", chicken";
        if (jalapenos) pizza += ", jalapenos";
        if (kiwi) pizza += ", kiwi";
        return pizza;
    }
}