using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_recursive_folders_function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a folder path: ");
            string path = Console.ReadLine();
            FindFiles(path);
        }

        public static void FindFiles(string path)
        {
            foreach (string fileName in Directory.GetFiles(path))
            {
                Console.WriteLine(fileName);
            }

            foreach (string directory in Directory.GetDirectories(path))
            {
                FindFiles(directory);
            }
        }
    }
}
