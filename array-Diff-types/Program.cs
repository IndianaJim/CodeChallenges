using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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

            ArrayList array = new ArrayList();
            array.Add(100);
            array.Add("Bobby");
            array.Add(33);
            foreach (object obj1 in array)
            {
                Console.WriteLine(obj1);
            }



        }
    }
}
