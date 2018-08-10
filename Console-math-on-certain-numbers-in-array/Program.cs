using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_math_on_certain_numbers_in_array
{
    class Program
    {//subtract smallest odd number from largest even number in an array.
        static void Main(string[] args)
        {
            int?[] Numbers = { 2, 3, 7, 1, 1000, 222 };

            int? largestEvenNumber = null;

            int? smallestOddNumber = null;

            foreach (int i in Numbers)
            {
                if (i % 2 == 0)
                {
                    if (!largestEvenNumber.HasValue || i > largestEvenNumber)
                    {
                        largestEvenNumber = i;
                    }
                }
                else
                {
                    if (!smallestOddNumber.HasValue || i < smallestOddNumber)
                    {
                        smallestOddNumber = i;
                    }
                }
            }
            if (largestEvenNumber == null)
            {
                Console.WriteLine("no even numbers");
            }
            else
            {
                Console.WriteLine("largest even = " + largestEvenNumber);
            }

            if (smallestOddNumber == null)
            {
                Console.WriteLine("no odd numbers");
            }
            else
            {
                Console.WriteLine("smallest odd = " + smallestOddNumber);
            }
            if (largestEvenNumber != null && smallestOddNumber != null)
            {
                Console.WriteLine(largestEvenNumber - smallestOddNumber);
            }

        }

    }
}
