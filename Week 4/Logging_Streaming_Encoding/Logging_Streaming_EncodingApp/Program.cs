//#define TEST

using System.IO;
using System.Diagnostics;
namespace Logging_Streaming_EncodingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}, it is now {DateTime.Now}");


            string currentDirectory = Directory.GetCurrentDirectory();
            var path = Path.Combine(currentDirectory, @"../../../"); // Go with "/" as it is platform independent

            #region reading and writing a single string
            //var text = "Hello, world!";
            //File.WriteAllText(path + "Hello.txt", text); // Goes to default directory

            //string content = File.ReadAllText(path + "Hello.txt");
            //Console.WriteLine(content);
            #endregion

            #region reading and writing a series of strings
            //string[] lines = { "And after all", "You're my Wonderwall", "I said maybe!" };
            //File.WriteAllLines(path + "Wonderwall.txt", lines);
            //string[] inputLines = File.ReadAllLines(path + "Wonderwall.txt");
            //foreach (var item in inputLines)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            // LOOK AT DIRECTORY CLASS

            #region Logging
            //Console.WriteLine($"This is being logged at time {DateTime.Now}");
            //// Listens for debugging or trace output
            //// Writes it to a text file
            //TextWriterTraceListener twtl = new TextWriterTraceListener(File.Create(path + "TraceOutput.txt"));
            //// Assigns twtl to be a listener
            //Trace.Listeners.Add(twtl);
            //int total = 0;
            //for (int i = 0; i <= 3; i++)
            //{
            //    Console.WriteLine(i);
            //    total += 1;
            //    Debug.WriteLine("Debug - The value of i is {i}");
            //    Trace.WriteLine("Trace - The value of i is {i}");
            //}
            //// Flushes output to the text file
            //Trace.Flush();
            #endregion

            #region Conditionally compiling code
            //            // If code is not intented to be run on a platform, or in an environment, or in debug mode
            //            Console.WriteLine("Starting the app");
            ////#if TEST
            //#if DEBUG
            //            // This code will only be run in debug mode
            //            Console.WriteLine("This is debug code");
            //#endif
            //            Console.WriteLine("Finishing the app");
            #endregion

            #region Encoding/Decoding
            // 
            #endregion

            #region streaming
            // Sending data from one location to another
            // An abstraction of bytes

            // Creates a stream for text to the following location
            using (StreamWriter sw = File.AppendText(path + "Mary.txt"))
            {
                // Within the stream, writing text to the file
                sw.WriteLine("Mary had a little lamb");
            }

            using (StreamReader sr = File.OpenText(path + "Mary.txt"))
            {
                string s = " ";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            #endregion

            //using (Stream ns = new NetworkStream(clientSocket, true), bufStream = new BufferedStream(ns, 2014))
            //{
            //      do something
            //}


            // END OF C#

            // Watch SQL videos today
            // Extra time to do coding path on Monday
            // IMPORTANT: WHERE, IN, * wildcards, Aggregate functions
            // LESS IMPORTANT: Date functions, trim functions, sub-query
            // Get NorthwindDB set up 
            // SQL miniproject
        }
    }
}