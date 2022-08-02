using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AysncCake
{
    class Program
    {
        #region version 1
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to my birthday party");
            await HaveAPartyAsync();
            Console.WriteLine("Thanks for a lovely party");
            Console.ReadLine();
        }
        #endregion

        #region version 2
        //public static async Task Main(string[] args)
        //{
        //    Console.WriteLine("Welcome to my birthday party");
        //    await HaveAPartyAsync();
        //    Console.WriteLine("Thanks for a lovely party");
        //    Console.ReadLine();
        //}
        #endregion

        // On making the method "async" (QAR)
        // Void --> Task 
        private static async Task HaveAPartyAsync()
        // private static async Task HaveAPartyAsync()
        {
            var name = "Cathy";
            var decoTask = DecorateRoomAsync();
            var cakeTask = BakeCakeAsync();
            var presentTask = WrapPresentsAsync();
            var decos = await decoTask;
            Console.WriteLine($"{decos}");
            PlayPartyGames();
            await presentTask;
            OpenPresents();
            // Wait here (using .Result) until we get a result from the task
            // Means that control is not handed back to the Main method
            //var cake = cakeTask.Result;

            var cake = await cakeTask;
            Console.WriteLine($"Happy birthday, {name}, {cake}!!");
        }

        // Cake --> Task<Cake>
        private static async Task<Cake> BakeCakeAsync()
        {
            Console.WriteLine("Cake is in the oven");
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("Cake is done");
            return new Cake();
        }

        private static async Task<Decorations> DecorateRoomAsync()
        {
            Console.WriteLine("Room decorating has begun");
            Random decorationsRandom = new Random();
            int numDecorations = decorationsRandom.Next(1, 4);
            await Task.Delay(TimeSpan.FromSeconds(0.5 * numDecorations));
            return new Decorations(numDecorations);
        }

        private static async Task WrapPresentsAsync()
        {
            Console.WriteLine("Presents are being wrapped");
            Random presentsRandom = new Random();
            int numPresents = presentsRandom.Next(1, 5);
            await Task.Delay(TimeSpan.FromSeconds(numPresents));
            Console.WriteLine($"{numPresents} presents are wrapped");
        }

        private static void PlayPartyGames()
        {
            Console.WriteLine("Starting games");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Finishing Games");
        }

        private static void OpenPresents()
        {
            Console.WriteLine("Opening Presents");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("Finished Opening Presents");
        }
    }

    public class Cake
    {
        public override string ToString()
        {
            return "Here's a cake";
        }
    }

    public class Decorations
    {
        private List<string> decosChosen = new List<string>();
        public Decorations(int numDecorations)
        {
            List<string> decoTypes = new List<string>() { "streamers", "balloons", "bunting", "banners" };
            Random selectDeco = new Random();
            for (int i = 0; i < decoTypes.Count; i++)
            {
                int itemSelected = selectDeco.Next(0, decoTypes.Count - 1);
                decosChosen.Add(decoTypes[itemSelected]);
                decoTypes.Remove(decoTypes[itemSelected]);
            }
        }

        public override string ToString()
        {
            return "The room has been decorated with " + string.Join(", ", decosChosen);
        }
    }
}
