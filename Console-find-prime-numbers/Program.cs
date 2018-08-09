using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_find_prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double dbl = Convert.ToDouble(Console.ReadLine());
            bool isPrime = true;
            string primes = "";

            //outer loop
            for (double i = 2; i < dbl; i++)
            {
                //inner loop
                for (double j = 2; j < dbl; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes = primes + i.ToString() + " ";
                }
                isPrime = true;
            }

            Console.WriteLine(primes);

        }
    }
}
