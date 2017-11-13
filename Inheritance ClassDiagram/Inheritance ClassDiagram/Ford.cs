using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance_ClassDiagram
{
    public class Ford : Cars
    {
        public string make = "Ford";

        public override void PrintMake()
        {
            Console.WriteLine($"{make}");
        }
    }
}