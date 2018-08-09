using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_recursive_functions
{

    // a recusive function is a function that calls itself

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double factorial = Factorial(number);
            double recursivefactorial = RecursiveFactorial(number);
            Console.WriteLine("Factorial of " + number.ToString() + " = " + factorial.ToString());
            Console.WriteLine("Recursive Factorial of " + number.ToString() + " = " + recursivefactorial.ToString());

        }

        //non-recursive method...
        public static double Factorial(int number)
        {
            if (number == 0)
                return 1;

            double factorial = 1;

            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        //recursive method
        public static double RecursiveFactorial(int number)
        {
            if (number == 0)
                return 1;

            return number * RecursiveFactorial(number - 1);
        }
    }
}
