using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance_ClassDiagram
{
    public class Toyota : Cars
    {
        public int engineSize = 4;

        public void PrintEngineSize()
        {
            Console.WriteLine($"{engineSize}");
        }
    }
}