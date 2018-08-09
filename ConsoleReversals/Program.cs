using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


//reverse each word in a sentence string
namespace ConsoleReversals
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialStr = "one two three four five";
            string result = ReverseMyString(initialStr);
            Console.WriteLine(result);
        }

        public static string ReverseMyString(string str)
        {
            string resultStr = string.Join(" ", str
                .Split(' ')
                .Select(x => new String(x.Reverse().ToArray())));


            return resultStr;
        }
    }
}
