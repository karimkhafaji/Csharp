using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Person obj1 = new Person();
            obj1.PrintPerson();

            Address obj2 = new Address();
            Employee obj3 = new Employee(obj2);
            
            obj2.PrintAddress();


            Console.ReadKey();
        }
    }
}
