using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console_count_occurrences_of_digits_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //found
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[10];

            while (s > 0)
            {
                int x = s % 10;
                arr[x]++;
                s = s / 10;
                //how it's done
                Console.WriteLine("x or s%10 = " + x + ", s or s/10 = " + s);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i + " " + arr[i]);
            }
        }




    }
}
