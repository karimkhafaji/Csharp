using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeesPart myEmployee = new EmployeesPart();

            myEmployee.PrintName();
            myEmployee.PrintAddress();
            myEmployee.PrintDepartment();
            Console.ReadKey();
        }
    }
}
