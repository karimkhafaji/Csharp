using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance_ClassDiagram
{
    public class Cars
    {
        public string model ="RAV4";
        public string make ="Toyota";
        public int year=2009;

        public void PrintModel()
        {
            Console.WriteLine($"{model}");
        }
    }
}