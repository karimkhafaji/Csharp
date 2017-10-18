using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            //Boolean comparison == , != , < , > , <= , >=
            //Boolean conditions && , ||


            Boolean myResult;
            int myVari1 = 5,myVari2 = 7;
            //myResult = myVari1 != 6;

            //myResult = (myVari1 == 5) && (myVari2 == 7);                                                 //Truth Table  & ||
            myResult = (myVari1 >= 6) || (myVari2 >= 7);                                                   // F    F   -- F  F
                                                                                                           // F    T   -- F  T
                                                                                                           // T    T   -- T  T
                                                                                                           // T    F   -- F  T

            Console.WriteLine("That answar is = {0}", myResult);
            Console.ReadKey();


        }
    }
}
