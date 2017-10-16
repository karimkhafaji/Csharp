using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Operations_Par1
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - * / %

            int myVar1 = 700;
            int myVar2 = 1400;

            int temp = myVar1 + myVar2;
            int temp2 = myVar2 - myVar1;
            int temp3 = myVar1 * myVar2;
            int temp4 = myVar2 / myVar1;
            int temp5 = myVar2 % myVar1;


            // + -
            int myNegativeVar = -100;
            int temp6 = + myVar1;
            int temp7 = - myVar1;
            int temp8 = +myNegativeVar;

            string myStr = "this is awesome";
            string myStr2 = ", ísn't ?";
            myStr = myStr + myStr2;

            //Console.WriteLine("{0}\n\n{1}\n\n{2}", temp6, temp7, temp8);
            //Console.WriteLine("the result is {0}\nthe result is {1}\nthe result is {2}\nthe result is {3}\nthe remaining is {4}", temp, temp2, temp3, temp4, temp5);
            Console.Write("{0}", myStr);
            Console.ReadKey();
        }
    }
}
