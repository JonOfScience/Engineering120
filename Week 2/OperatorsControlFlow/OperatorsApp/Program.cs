namespace OperatorsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Increment
            int x = 0;
            int y = 0;
            int a = ++x;
            int b = y++;
            #endregion

            // int division

            #region modulus

            // in weeks and days - what is 15 days
            // var weeks = 15 / 7;
            // var days = 15 % 7;
            // Console.WriteLine($"{weeks} weeks and {days} day(s).");

            // Console.WriteLine(FindSumDiv5and7(100));

            //const int NUM_ROWS = 2;
            //const int NUM_COLS = 5;
            //bool running = true;
            //int row = 0;
            //int col = 0;
            //int sprintNumber = -1;

            //while (running)
            //{
            //    sprintNumber++;
            //    sprintNumber %= (NUM_ROWS * NUM_COLS);
            //    row = sprintNumber / NUM_COLS;
            //    col = sprintNumber % NUM_COLS;
            //}
            #endregion

            #region Logical Operators
            //bool isWearingParachute = false;
            //if (isWearingParachute && JumpOutOfPlane())
            //{
            //    Console.WriteLine("Congrats, you have made a successful jump.");
            //}

            //string greeting = null;
            //if (greeting != null && greeting.ToLower().StartsWith('h'))
            //{
            //    Console.WriteLine($"{greeting} starts with an 'h'.");
            //}

            //int n = 0;
            //int o = 3;
            //if (n == 5 ^ o == 3)
            //{
            //    Console.WriteLine("Exclusive or");
            //}
            #endregion

            #region Selection

            #endregion
        }

        public static bool JumpOutOfPlane()
        {
            Console.WriteLine("Jump");
            return true;
        }

        // Find the sum of all numbers from 1 to n
        public static int FindSumDiv5and7(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++) 
            {
                if (i % 5 == 0 || i % 7 == 0)
                    sum += i;
            }
            return sum;
        }
    }
}