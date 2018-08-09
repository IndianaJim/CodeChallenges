using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_abstract_class_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            CorporateCustomer CC = new CorporateCustomer();
            Console.WriteLine(CC.ID);

            SavingsCustomer SC = new SavingsCustomer();
            Console.WriteLine(SC.ID);
        }

        public abstract class Customer
        {

            public Customer()
            {
                this._id = Guid.NewGuid();
            }
            private Guid _id;

            public Guid ID
            {
                get
                {
                    return this._id;
                }
            }
        }

        public class CorporateCustomer : Customer
        {
            public CorporateCustomer()
            {

            }
        }

        public class SavingsCustomer : Customer
        {
            public SavingsCustomer()
            {

            }

        }
    }
}
