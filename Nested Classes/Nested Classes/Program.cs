using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nested_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Employees myEmployee = new Employees();
            myEmployee.PrintValues();

            Employees.Departments myDepart = new Employees.Departments();
            myDepart.PrintDepartmentName();

            ReadKey();
        }
    }
}
