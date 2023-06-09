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


        ///
        /// <summary>
        /// In the below code I created a method which takes a string as a parameter.First I check if the string is not null ,or empty or white space.
        /// Then I create a variable which takes the word parameter and I convert the characters of the word in lower case and I loop evry character using Linq's extension method where to filter the f characters
        /// and from the result of where which returns a ienumerable of f characters,I take the count of this list of characters
        /// </summary>
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
