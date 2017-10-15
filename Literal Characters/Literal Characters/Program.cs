using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_Characters
{
    class Program
    {
        static void Main(string[] args)
        {

            int myVar = -100;
            uint myUVar = 1000U;
            long myLVar = 1000;
            ulong myULVar = 1000UL;

            float myFlVar = 1.5F;
            double myDVar = 100.5D;
            decimal myDECVar = 100.5M;


            Console.WriteLine("{0} {1}{2}{3}", myVar, myUVar, myLVar, myULVar);

            Console.WriteLine($"\n {myFlVar} \n {myDVar} \n {myDECVar}");
            Console.ReadKey();
        }
    }
}
