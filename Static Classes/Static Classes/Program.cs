using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Static_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employees1 myObj = new Employees1(); not allowed
            Employees1.PrintName();
            ReadKey();
        }
    }
}
