using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_store_diff_types_in_a_list_of_listof_objects
{
    class Program
    {
        static void Main(string[] args)
        {

            List<List<object>> list = new List<List<object>>();

            List<object> list1 = new List<object>();
            list1.Add(101);
            list1.Add(102);
            list1.Add(103);

            List<object> list2 = new List<object>();
            list1.Add("test1");
            list1.Add("test2");
            list1.Add("test3");

            list.Add(list1);
            list.Add(list2);

            foreach (List<object> objectList in list)
            {
                foreach (object obj in objectList)
                {
                    Console.WriteLine(obj);
                }
            }
        }
    }
}
