using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_Diff_types
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] myArray = new object[3];
            myArray[0] = "Bob";
            myArray[1] = 45;
            myArray[2] = 99;

            foreach (object obj in myArray)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
