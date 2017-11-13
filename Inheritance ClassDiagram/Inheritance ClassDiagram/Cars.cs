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
        public string drivingType = "4WD";

        public void PrintModel()
        {
            Console.WriteLine($"{model}");
        }

        public string engineCapacity = "02.4L";

        public void PrintEngineCapacity()
        { Console.WriteLine($"{engineCapacity}"); }

        public virtual void PrintMake()
        {
            Console.WriteLine($"{drivingType}"); // example to see that this has nothing to do with the others (children's classes)
                                                 // therefore we have written something else "not make" 
        }
    }
}