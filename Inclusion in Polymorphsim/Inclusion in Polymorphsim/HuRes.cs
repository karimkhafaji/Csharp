using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclusion_in_Polymorphsim
{
    class HuRes:Employees
    {
        public override void PrintName()
        {
            Console.WriteLine("\nI'm print for class Human Resources\n");
        }
    }
}
