namespace ResponseRandomizerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(string.Join(',', MakeResponseOrder()));
        }

        public static List<string> MakeResponseOrder()
        {
            Random randGen = new Random();
            string[] participants = { "Dan", "David", "Ellis", "Jon", "Laba", "Tom" };
            int[] chances = new int[participants.Length];
            Dictionary<int, string> recallList = new Dictionary<int, string>();
            for (int idx = 0; idx < participants.Length; idx++)
            {
                chances[idx] = randGen.Next(1, 100);
                recallList.Add(chances[idx], participants[idx]);
            }
            Array.Sort(chances);
            List<string> outList = new List<string>();
            foreach (int chance in chances)
            {
                outList.Add(recallList[chance]);
            }
            return outList;
        }
    }
}