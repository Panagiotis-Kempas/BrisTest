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
