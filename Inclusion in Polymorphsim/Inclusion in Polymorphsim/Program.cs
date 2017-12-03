using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclusion_in_Polymorphsim
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees obj = new Employees();
            obj.PrintName();

            obj = new Managers();
            obj.PrintName();

            obj = new HuRes();
            obj.PrintName();

            Console.ReadKey();
        }
    }
}
