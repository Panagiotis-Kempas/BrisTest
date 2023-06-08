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
