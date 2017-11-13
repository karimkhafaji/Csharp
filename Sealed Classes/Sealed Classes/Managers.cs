using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Classes
{
    class Managers:Employees
    {
        public override void PrintName()
        {
            Console.WriteLine($"{name}");  
        }
        public override void PrintDepart()
        {
            Console.WriteLine($"{Depart = "Manager"}");
        }
    }
}
