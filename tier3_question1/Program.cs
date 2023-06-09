using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tier3_question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfWords = new List<string>() { "Nun", "Mom", "repaper", "hello world", "someone", "kayak", "deed","noon" };
            PrintWordsThatArePalindrome(listOfWords);
        }

        ///
        /// <summary>
        /// Below there is a method whick takes a list of strings and I loop every string and by using the method IsPalindrome
        /// I pass the string as parameter and I check the result of the method if is true it means is palindrome so print the number
        /// </summary>
        public static void PrintWordsThatArePalindrome(List<string> words)
        {
            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    Console.WriteLine(word);
                }
            }
        }

        ///
        /// <summary>
        /// Below there is a method whick takes a string and checks if is palindrome.
        /// I take the parameter,I create a new string by converting the paraemter to a list of characters but reversed and I combine them.
        /// And I check if the new string is equal with the paraemter and i return a boolean.
        /// </summary>
        public static bool IsPalindrome(string word)
        {
            var reverseWord = string.Concat(word.ToLower().Select(x => x).Reverse());
            if (word.ToLower() == reverseWord)
            {
                return true;
            }
            return false;
        }
    }
}
