using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor
{

//    The prime factors of 13195 are 5, 7, 13 and 29.

//What is the largest prime factor of the number 600851475143 ?

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number to want to find prime factor : ");
            //it should be 600851475143 according to the problem.
            long number =  Convert.ToInt64(Console.ReadLine());

            List<long> primeFactor = CalculateFactor(number);

            for (int i = 0; i < primeFactor.Count; i++)
            {
                Console.WriteLine(primeFactor[i]);
            }

            Console.ReadKey();

        }

        public static List<long> CalculateFactor(long number)
        {
            var primes = new List<long>();

            for (int div = 2; div <= number; div++)
            {
                while (number % div == 0)
                {
                    primes.Add(div);
                    number = number / div;
                }
            }

            return primes;
        }
    }
}



