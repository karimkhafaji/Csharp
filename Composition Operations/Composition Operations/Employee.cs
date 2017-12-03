using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_Operations
{
    class Employee
    {

        private Address address;

        public Employee()
        {
        }

        public Employee(Address myAddress)
        {
            address = myAddress;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("I'm an Employee");
        }
    }
}
