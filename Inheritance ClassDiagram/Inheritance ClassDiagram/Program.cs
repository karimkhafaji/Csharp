﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_ClassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Toyota myObj = new Toyota();
            myObj.PrintEngineSize();
            myObj.PrintModel();

            Console.ReadKey();
        }
    }
}
