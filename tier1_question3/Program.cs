using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tier1_question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfWords = new List<string> { "Someone", "image", "sun", "beach", "WORD", "Hello world", "Skyfall" };
            PrintStringThatContainLettero(listOfWords);
        }


        ///
        /// <summary>
        /// In the below code I create a method which takes a list of strings and
        /// I filter this list with where linq method and I check which string contains o or O characters and I return a new list of strings
        /// </summary>
        public static void PrintStringThatContainLettero(List<string> list)
        {
            var newList = list.Where(y => y.Contains('o') || y.Contains('O')).ToList();
            foreach (var word in newList)
            {
                Console.WriteLine(word);
            }
        }
    }
}
