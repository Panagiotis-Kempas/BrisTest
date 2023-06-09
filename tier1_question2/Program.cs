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


        ///
        /// <summary>
        /// In the below code I created a function which takes a astring as a parameter.First I check if the string is not null ,or empty or white space.
        /// Then I create a variable which takes the word parameter and I use the Linq extension method split and pass the empty character as a parameter
        /// and the I pass as second parameter RemoveEmptyEntries value of Enum  StringSplitOptions so I remove all the empty characters(the white spaces)
        /// and from the result of split method which returns an ienumerable ,I take the count of the list of strings
        /// </summary>
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
