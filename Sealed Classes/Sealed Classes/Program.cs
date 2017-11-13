using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Managers myMag = new Managers();
            HR myHr = new HR();

            myMag.name = "Karim";
            myHr.name = "Majid";

            myMag.PrintName();
            myMag.PrintDepart();

            Console.WriteLine();

            myHr.PrintName();
            myHr.PrintDepart();

            Console.WriteLine();

            PTEmployees myObj = new PTEmployees();

            myObj.shift = "Day";
            Console.WriteLine($"{myObj.shift}");

            Console.ReadKey();
        }
    }
}
