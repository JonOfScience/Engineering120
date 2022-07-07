namespace ExceptionsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Exceptions
            //var theBeatles = new string[] { "John", "Paul", "Ringo", "George" };
            #endregion

            #region Exception Handling
            //string text;
            //string fileName = "Wonderwall.txt";
            //try
            //{
            //    text = File.ReadAllText(fileName);
            //    Console.WriteLine(text);
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("Sorry can't find " + fileName);
            //}

            //int a = 1;
            //int b = 0;
            //try
            //{
            //    Console.WriteLine(a / b);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Can't divide by zero");
            //    throw; // Re-throw the error
            //}
            #endregion

            #region finally
            //try
            //{
            //    Console.WriteLine("Charlie received 88: " + Grade(88));
            //    Console.WriteLine("Thomas received -100: " + Grade(-100));
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("I will always execute.");
            //}
            #endregion

            #region Numerical types
            //int anInt = 3; // explicitly typed
            //var vInt = 3; // implicitly typed

            //var name = "Peter";
            //var isClean = true;
            //var letter = 'p';
            //var uLongNum = 52ul;

            //float sum = 0;
            //for (int i = 0; i < 100_000; i++)
            //{
            //    sum += 2 / 5.0f;
            //}
            //Console.WriteLine("2/5 added 100,000 times " + sum);
            //Console.WriteLine("2/5 multiplied 100,000 " + 2/5.0f * 100_000 );
            #endregion

            //int max = int.MaxValue;
            //max++;
            //checked
            //{
            //    sbyte sNum = SByte.MaxValue;
            //    Console.WriteLine("SByte max: " + max);
            //    sNum += 1;
            //    Console.WriteLine(sNum);
            //}

            //int bankBalance = -2;
            //uint posBalance = (uint)bankBalance; // Gives about 40000000
            //Console.WriteLine(Convert.ToString(bankBalance, 2));
            //Console.WriteLine(Convert.ToString(posBalance, 2));

            //char n = 'N';
            //int i = n;
            //Console.WriteLine((int)n);
            //Console.WriteLine(i);

            //var theInt = 78;
            //var anotherInt = Convert.ToChar(theInt);
            //Console.WriteLine(anotherInt);

            double myDouble = 3.4;
            int myInt2 = Convert.ToInt32(myDouble);
        }
        public static string Grade(int mark)
        {
            if (mark < 0 || mark > 100) throw new ArgumentOutOfRangeException($"Mark: {mark}, Allowed range 0 - 100");
            return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        }
    }
}