using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tier1_question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNumberOfWords("Today    I     came    from     work    and    I    was   really    tired   so");
        }

        public static void PrintNumberOfWords(string word)
        {
            if (!string.IsNullOrWhiteSpace(word))
            {
                var numberOfWords = word.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Count();
                Console.WriteLine(numberOfWords);
            }
            else
            {
                Console.WriteLine("String does not contain any words or letters");
            }
        }
    }
}
