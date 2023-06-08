using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tier2_question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = new List<int>() { 1, 2, 4, 8, 10, 20, 25, 14, 22, 23 };
            PrintAverage(listOfNumbers);
        }

        public static void PrintAverage(List<int> numbers)
        {
            var average = numbers.Where(x => x % 2 == 0 && x % 5 == 0).Average();
            Console.WriteLine(average);
        }
    }
}
