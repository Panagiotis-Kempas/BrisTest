using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tier3_question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>() { "hello", "world", "abet", "some", "beat", "yolo", "abut", "someone", "tabu" };
            PrintWordsWhichAreAnagrams(list);
        }


        ///
        /// <summary>
        /// Below there is a method whick takes a list of strings.First I covert every string in the list to a new string which has not white spaces
        /// Then I create a list of key value pair.And I make two for loops.The one starts from the beginning of the list(index 0) and the other from the  second from the second element(index 1)
        /// By this way I loop the list two times but taking different elements to check if for every element in the list exist another element with 
        /// the characteristics of same length then i declare to variables with two lists of characters one for the word from the first loop and one for the other word in the second loop (the word after the first)
        /// and i check if the first word contains all the letters of the second.If yes then i create a key value pair with the two words together and i add to the key value pair list so ican print the pairs later
        /// </summary>
        public static void PrintWordsWhichAreAnagrams(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                words[i] = words[i].Trim();
            }
            var pairs = new List<KeyValuePair<string, string>>();
            for (int i = 0; i < words.Count; i++)
            {
                for (int c = i + 1; c < words.Count; c++)
                {
                    if (words[i].Length == words[c].Length)
                    {
                        var list1 = words[i].ToLower().ToCharArray();
                        var list2 = words[c].ToLower().ToCharArray();

                        if (list1.All(x => list2.Contains(x)))
                        {
                            pairs.Add(new KeyValuePair<string, string>(string.Concat(list1), string.Concat(list2)));
                            break;
                        }
                           
                    }
                }
            }

            foreach (var pair in pairs)
            {
                Console.WriteLine($"PAIR {pair.Key} - {pair.Value}");
            }
        }
    }
}
