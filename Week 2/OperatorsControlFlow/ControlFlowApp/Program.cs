namespace ControlFlowApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region ternary operators
            //int mark = 35;
            ////string grade = mark >= 65 ? "Pass" : "Fail";
            ////Console.WriteLine(grade);

            //// This example should be refactored to make it more clear
            //string grade2 = mark >= 65 ? mark >= 85 ? "Distinction" : "Pass"
            //    : mark < 20 ? "Failed no retake"
            //    : "Fail with retake";
            //Console.WriteLine(grade2);
            #endregion

            #region loops
            List<int> nums = new List<int> { 10, 6, 22, -17, 3 };
            Console.WriteLine("Highest foreach loop: " + LoopTypes.HighestForEachLoop(nums));
            Console.WriteLine("Highest for- loop: " + LoopTypes.HighestForLoop(nums));
            Console.WriteLine("Highest while- loop: " + LoopTypes.HighestWhileLoop(nums));
            Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums));
            #endregion
        }

        public static string Grade(int mark)
        {
            return mark < 0 ? throw new ArgumentOutOfRangeException() 
                : mark >= 65 ? mark >= 85 ? "Distinction" : "Pass" 
                : mark < 20 ? "Failed no retake" : "Fail with retake";
        }
    }
}