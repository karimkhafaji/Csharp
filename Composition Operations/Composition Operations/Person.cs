using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_Operations
{
    class Person
    {
          Employee obj = new Employee();

        public void PrintPerson()
        {
            obj.PrintEmployees();
            Console.WriteLine("\nI'm a Person");
        }
    }
}
