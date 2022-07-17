using System;
using System.Linq;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            // Use a stringbuilder?
            List<string> items = new List<string>();
            for (int i = 0; i < num; i++)
            {
                if (queue.TryDequeue(out string itemResult)) items.Add(itemResult);
            }
            return string.Join(", ", items);
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            var reversed = new int[original.Length];
            var myStack = new Stack<int>();
            foreach (int num in original)
                myStack.Push(num);
            for (int i = 0; i < original.Length; i++)
                reversed[i] = myStack.Pop();
            return reversed;
        }

        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            var counter = new Dictionary<char, int>();
            string result = "";
            //ITS AN ORDERED DICT foreach (int digit in Enumerable.Range(0, 10)) counter.Add(digit.ToString()[0], 0);
            //foreach (char inputDigit in input) counter[inputDigit] += 1;
            foreach (char inputDigit in input)
            {
                if (counter.ContainsKey(inputDigit))
                {
                    counter[inputDigit] += 1;
                }
                else if ("0123456789".Contains(inputDigit)) // Use ASCII codes? If (inputDigit >= 48 && inputDigit <= 57)
                {
                    counter.Add(inputDigit, 1);
                }
            }
            // foreach (KeyValuePair<char, int> keyValuePair in counter) result += $"[{keyValuePair.Key}, {keyValuePair.Value}]";
            foreach (KeyValuePair<char, int> keyValuePair in counter) result += $"{keyValuePair}";
            return result;
        }
    }
}
