using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclusion_in_Polymorphsim
{
    class Managers : Employees
    {
        public override void PrintName()
        {
            Console.WriteLine("\nI'm print from class Managers\n");
        }

    }
}
