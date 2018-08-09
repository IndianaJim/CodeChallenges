using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_is_and_as_keywords_in_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                ID = 101,
                Name = "Mark"
            };

            //returns true, as emp is Employee
            if (emp is Employee)
                Console.WriteLine(emp.Name + " is Employee");
            else
                Console.WriteLine(emp.Name + " is not Employee");


            //returns false, as base type cannot be converted to derived type...
            if (emp is PermanentEmployee)
                Console.WriteLine(emp.Name + " is PermanentEmployee");
            else
                Console.WriteLine(emp.Name + " is not PermanentEmployee");
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class PermanentEmployee : Employee
    {
        public int AnnualSalary { get; set; }
    }

    public class ContractEmployee : Employee
    {
        public int HourlySalary { get; set; }
    }
}
