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
            string newStr = "";
            string initialStr = "one two three four five";

            //version with Reverse function
            string resultStr = string.Join(" ", initialStr
                .Split(' ')
                .Select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine(resultStr);


            //version 2 - without Reverse function
            string[] splits = initialStr.Split(' ');
            for (int i = 0; i < splits.Length; i++)
            {
                //Console.WriteLine("original word = " + splits[i]);
                int length = splits[i].Length - 1;
                string split1 = splits[i];
                while (length >= 0)
                {
                    newStr = newStr + split1[length];
                    length--;
                }

                newStr = newStr + " ";

            } //end version 2
            Console.WriteLine(newStr);


        }
    }
}
