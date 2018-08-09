using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Find_Product_of_Array_of_nums
{
    class Program
    {
        static void Main(string[] args)
        {

            int cases = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            double bigNum = (10E9 + 7);
            double answer = 1;

            for (int i = 0; i < cases; i++)
            {
                answer = (answer * double.Parse(nums[i])) % bigNum;

                //NOTE!!! error in answer but works on some test cases
            }
            Console.WriteLine(answer);
        }

    }
}
