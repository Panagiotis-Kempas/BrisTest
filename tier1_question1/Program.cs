using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tier1_question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNtimesOfLetterF("Ftgffp54545cFF!@");
        }

        public static void PrintNtimesOfLetterF(string word)
        {
            if(!string.IsNullOrWhiteSpace(word))
            {
                var count = word.ToLower().Where(x => x == 'f').Count();
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("This word does not contain any characters of F letter");
            }      
        }
    }
}
