using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Classes
{
    sealed class PTEmployees:Employees
    {
        public string shift;

        public override void PrintName()
        {
            Console.WriteLine($"{name}");
        }
        public override void PrintDepart()
        {
            Console.WriteLine($"{Depart = "PartTime Employees"}");
        }
    }
}
