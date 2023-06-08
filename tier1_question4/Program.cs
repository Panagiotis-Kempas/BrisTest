using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tier1_question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoveAllVowels("hello");
            RemoveAllVowels("codewars");
            RemoveAllVowels("goodbye");
            RemoveAllVowels("HELLO");
        }

        public static void RemoveAllVowels(string word)
        {
            if(!string.IsNullOrWhiteSpace(word)) 
            {
                var vowelToLower = "aeiou";
                var vowelToUpper = "aeiou";
                var newWord = string.Concat(word.ToLower().Select(x => vowelToLower.Contains(x) || vowelToUpper.Contains(x) ? "" : x.ToString()));
                Console.WriteLine(newWord);
            }
           
        }
    }
}
