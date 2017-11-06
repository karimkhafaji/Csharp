using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Methods
{
    partial class EmployeesPart
    {
        public void PrintName() { Console.WriteLine($"Employee Name is {name}"); }
        public void PrintAddress() { Console.WriteLine($"Employee Address is {address}"); }
        partial void MyAge()
        {
            Console.WriteLine($"Employee age is {age}");
        }


        public void PrintDepartment()
        {

            Console.WriteLine($"Employee Department is {department}");
            MyAge();
        }

    }
}
