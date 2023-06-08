using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tier2_question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = new List<int>() { -15, 22, 3, 9, -85, -9, 24 };
            PrintSumOfAbsoluteValues(listOfNumbers);
        }

        public static void PrintSumOfAbsoluteValues(List<int> numbers)
        {
            var sum = numbers.Where(x => x % 3 == 0).Select(y=> Math.Abs(y)).Sum();
            Console.WriteLine(sum);
        }
    }
}
