using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal_isLucky
{
    class Program
    {
        static void Main(string[] args)
        {
            //given int "n", check if sum of first half
            //of digits == sum of second half of digits.

            int n = 1230;
            int first = 0;
            int second = 0;
            string numString = n.ToString();
            int nLength = numString.Length;
            string[] numArray = new string[nLength];
            int counter = 0;

            for (int i = 0; i < nLength; i++)
            {
                numArray[i] = numString.Substring(counter, 1);
                counter++;
            }


            for (int i = 0; i < (nLength / 2); i++)
            {
                first += int.Parse(numArray[i]);
                Console.WriteLine("first = " + first);
            }
            for (int j = (nLength / 2); j < nLength; j++)
            {
                second += int.Parse(numArray[j]);
                Console.WriteLine("second = " + second);
            }

            Console.WriteLine("first = " + first + " and second = " + second);
            //if (first == second)
            //    return true;
            //else
            //    return false;
        }
    }
}
