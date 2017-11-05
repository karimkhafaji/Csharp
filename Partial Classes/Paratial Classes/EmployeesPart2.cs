using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Classes
{
    partial class EmployeesPart
    {
        public void PrintName() { Console.WriteLine($"Employee Name is {name}"); }
        public void PrintAddress() { Console.WriteLine($"Employee Address is {address}"); }
        public void PrintDepartment() { Console.WriteLine($"Employee Department is {department}"); }
        
    }
}
