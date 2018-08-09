using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //if number div by 3 fizz
            //if number div by 5 buzz
            //if both then fizzbuzz


            for (int i = 0; i < 100; i++)
            {

                if ((i % 3 == 0) & (i % 5 == 0))
                {

                    Console.WriteLine("FizzBuzz");

                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }


            }//end for
        }
    }
}
