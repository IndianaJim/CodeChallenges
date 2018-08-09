using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_HE_test_framework
{
    class Class1
    {
using System; 
using System.Numerics;
class MyClass
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0 && n <= 10)
            {
                n = n * 2;
                Console.WriteLine(n);
                System.Console.WriteLine("helloworld\n");
            }

        }
    }


    -----------------------
    using System;
namespace helloworld
    {
        class Hello
        {
            static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                n = n * 2;
                Console.WriteLine(n);
                string s = Console.ReadLine();
                Console.WriteLine(s);
            }
        }
    }
    -------------------------
    using System; 
using System.Numerics;
class MyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int.Parse(Console.ReadLine()) * 2));
            Console.WriteLine(Console.ReadLine());
        }
    }
    --------------------------
    using System; 
using System.Numerics;
class MyClass
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0 && n <= 10)
            {
                n = n * 2;
                Console.WriteLine(n);
                System.Console.WriteLine("helloworld\n");
            }

        }
    }
    ---------------------------
}using System; 
using System.Numerics;
class MyClass
{
    static void Main(string[] args)
    {
        var n1 = System.Console.ReadLine();
        var s1 = System.Console.ReadLine();
        var num = Int32.Parse(n1);
        System.Console.WriteLine(num * 2);
        System.Console.WriteLine(s1);
    }
}

-------------------------------------------------
}using System; 
using System.Numerics;
class MyClass
{
    static void Main(string[] args)
    {
        /*
        * Read input from stdin and provide input before running
        var line1 = System.Console.ReadLine().Trim();
        var N = Int32.Parse(line1);
        for (var i = 0; i < N; i++) {
        System.Console.WriteLine("hello world");
        }
        */

        int n = Convert.ToInt32(Console.ReadLine());
        string str = Console.ReadLine();

        System.Console.WriteLine(n * 2);
        System.Console.WriteLine(str);
        //System.Console.WriteLine("Hello World!\n");
    }
}------------------------------------------------------------

using System; 
using System.Numerics;
class MyClass
{
    static void Main(string[] args)
    {
        int n = Int32.Parse(System.Console.ReadLine().Trim());
        string str = System.Console.ReadLine().Trim();
        System.Console.WriteLine(n * 2 + "\n" + str);
    }
}-------------------------------------------------

using System.Numerics;
class MyClass
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string res = Console.ReadLine();
        string result = (n * 2).ToString() + "\n" + res;
        System.Console.WriteLine(result);
    }
}
--------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string name = "helloworld";

            if (number == 5)
            {
                number = number * 2;
                Console.WriteLine(number);
                Console.WriteLine(name);
            }
        }
    }
}
this one works
--------------------------------------------
