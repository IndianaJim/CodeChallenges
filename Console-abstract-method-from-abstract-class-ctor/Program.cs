using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_abstract_method_from_abstract_class_ctor
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsCustomer sc = new SavingsCustomer();
            CorporateCustomer cc = new CorporateCustomer();

        }

        public abstract class Customer
        {
            public Customer()
            {
                Print();
            }
            public abstract void Print();
        }

        public class SavingsCustomer : Customer
        {
            public override void Print()
            {
                Console.WriteLine("SavingsCustomer class Print() method invoked");
            }
        }

        public class CorporateCustomer : Customer
        {
            public override void Print()
            {
                Console.WriteLine("CorporateCustomer class Print() method invoked");
            }
        }
    }
}
