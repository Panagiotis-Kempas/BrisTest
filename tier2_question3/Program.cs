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


        ///
        /// <summary>
        /// I created a method whick takes a list of numbers and with where method of linq I loop every number to ,check if is divisable by 3,
        /// so the where method returns a new ienumerable with only the numbers that are divisable with 3 and then with select method I loop again
        /// every number in the new list and I convert the number to it;s absolute form whick is positive
        /// </summary>
        public static void PrintSumOfAbsoluteValues(List<int> numbers)
        {
            var sum = numbers.Where(x => x % 3 == 0).Select(y=> Math.Abs(y)).Sum();
            Console.WriteLine(sum);
        }
    }
}
