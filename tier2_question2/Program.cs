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



        ///
        /// <summary>
        /// Below I created a method whick takes a list of numbers(int).Primes numbers are the numbers that can be divided only with 1
        /// or their self.So I loop every number in the list with a for loop and then declare a variable counter.then I loop again with a start point 2
        /// to check if the number is divisable with 2.If it is I increment the counter so by default the number is not prime and I breaking from the loop
        /// .After I check if counter which takes the times that the number has been divided and if the number is not 1.And if it passes the condition
        /// I add the number to a new list I created because I want to printall the numbers in the list of only prime numbers
        /// </summary>
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

