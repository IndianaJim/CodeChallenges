using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Finally_block_throws_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Hello();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("input string was not correct Dude!");
                Console.WriteLine(ex.Message);
            }

        }

        public static void Hello()
        {
            try
            {
                throw new Exception("Try block exception");
            }

            finally
            {

                throw new Exception("Finally block exception");

                //Console.WriteLine("This line will be executed");
                //    int result = Convert.ToInt32("TEN");
                //    Console.WriteLine("This line will NOT be executed");
            }
        }
    }
}
