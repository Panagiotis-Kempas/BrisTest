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
