namespace ControlFlowApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int mark = 35;
            //string grade = mark >= 65 ? "Pass" : "Fail";
            //Console.WriteLine(grade);

            // This example should be refactored to make it more clear
            string grade2 = mark >= 65 ? mark >= 85 ? "Distinction" : "Pass"
                : mark < 20 ? "Failed no retake"
                : "Fail with retake";
            Console.WriteLine(grade2);
        }

        public static string Grade(int mark)
        {
            return mark < 0 ? throw new ArgumentOutOfRangeException() : mark >= 65 ? mark >= 85 ? "Distinction" : "Pass" : mark < 20 ? "Failed no retake" : "Fail with retake";
        }
    }
}