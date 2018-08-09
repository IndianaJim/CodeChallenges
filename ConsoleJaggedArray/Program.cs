using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {

            string[][] jaggedArray = new string[3][];
            jaggedArray[0] = new string[4];
            jaggedArray[1] = new string[3];
            jaggedArray[2] = new string[2];

            jaggedArray[0][0] = "fe";
            jaggedArray[0][1] = "fi";
            jaggedArray[0][2] = "fo";
            jaggedArray[0][3] = "fum";

            jaggedArray[1][0] = "Me";
            jaggedArray[1][1] = "Mi";
            jaggedArray[1][2] = "Mo";

            jaggedArray[2][0] = "Le";
            jaggedArray[2][1] = "Li";

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                string[] innerArray = jaggedArray[i];
                for (int j = 0; j < innerArray.Length; j++)
                {
                    Console.WriteLine(innerArray[j]);
                }
                Console.WriteLine();
            }


        }
    }
}
