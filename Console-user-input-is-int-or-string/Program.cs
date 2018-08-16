using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_user_input_is_int_or_string
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter your input:");
            string strInput = Console.ReadLine();

            int result = 0;

            if (int.TryParse(strInput, out result))
            {
                Console.WriteLine("your input is a number: " + result);

            }
            else
            {
                Console.WriteLine("your input is not a number: " + strInput);
            }

        }
    }
}
