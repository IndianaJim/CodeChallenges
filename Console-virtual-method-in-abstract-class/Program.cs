using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_virtual_method_in_abstract_class
{

    public abstract class AbstractClass
    {
        public virtual void AbstractClassMethod()
        {
            Console.WriteLine("default implementation");
        }
    }

    public class SomeClass : AbstractClass
    {

    }

    public class SomeOtherClass : AbstractClass
    {
        public override void AbstractClassMethod()
        {
            Console.WriteLine("new implementation");
        }
    }
    class Program
    {
        //q: an abstract class has a default implementation for a method. 
        //the method's default implementation is needed in some classes but not some other classes.
        //how can you acheive this? 
        // answer: use "virtual" to allow override.

        static void Main(string[] args)
        {

            SomeClass sc = new SomeClass();
            sc.AbstractClassMethod();

            SomeOtherClass soc = new SomeOtherClass();
            soc.AbstractClassMethod();
        }
    }
}
