using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tier2_question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = new List<int>() { 1, 2, 5, 10, 7, 13, 17, 22, 20 };
            PrintSumOfSquaresOfPrimeNumbers(listOfNumbers);
        }


        public static void PrintSumOfSquaresOfPrimeNumbers(List<int> numbers)
        {
            var ListOfPrimes = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                int counter = 0;

                for (int j = 2; j < numbers[i] / 2; j++)
                {
                    if (numbers[i] % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && numbers[i] != 1)
                {
                    ListOfPrimes.Add(numbers[i]);
                }
            }
            var sum = ListOfPrimes.Select(x => x * x).Sum();
            Console.WriteLine(sum);
        }
    }
}

