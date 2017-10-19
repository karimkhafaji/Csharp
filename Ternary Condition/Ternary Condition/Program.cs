using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Condition
{
    class Program
    {
        static void Main(string[] args)
        {

            //int myvar = 12;

            //string myResult = (myvar < 10) ? "Less than 10" : "greater than 10";

            //Console.WriteLine("My Result is {0}", myResult);
            //Console.ReadKey();



            string myName = "KaRiM", myResult;

            myResult = (myName.Equals("karim")) ? "Yes" : "No";
            Console.WriteLine("The Answar is {0}", myResult);
            Console.ReadKey();

        }
    }
}
