using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance_ClassDiagram
{
    public class Nissan : Cars
    {
        public string make = "Nissan";

        public void PrintMake()
        {
            Console.WriteLine($"{make}");
        }
    }
}