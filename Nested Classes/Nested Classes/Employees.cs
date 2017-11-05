using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nested_Classes
{
    class Employees
    {

        public string fName = "Karim";
        public string Address = "Eduard-Ellmauthaler Str";
        public void PrintValues()
        { WriteLine($"Employee Name is {fName} \nLiving at {Address}"); }


        public class Departments
        {
            public string departmentName = "Administration";
            public void PrintDepartmentName()
            { WriteLine($"Working at {departmentName}"); }
        }

    }
}
