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


        ///
        /// <summary>
        /// In the below I created a function whick takes a string .I do my check if the string is null or white space or empty string
        /// and then i create two variables which are all the vowels in lower and upper case and I loop every character in the string parameter,
        /// with the select method of linq,and looping very character I check if this character exists in the two vowel variables I put and empty character in this position,
        /// else i leave the character as it is and then because the select method returns an ienumerable ,I use concat method to create a new string by combining all characters
        /// </summary>
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
