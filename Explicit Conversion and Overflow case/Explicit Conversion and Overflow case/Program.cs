using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversion_and_Overflow_case
{
    class Program
    {
        static void Main(string[] args)
        {

            //type1 = (type1)type2           the rule              //casting


                                                                   //overflow
            byte mySbyte;                  //byte value            //0 - 255         
            int myInt = 350;               //integer               //‭000101011110‬
            // mySbyte = myInt;                                    //‭000011111111‬     +
            mySbyte = (byte)myInt;                                 //000001011110
            Console.WriteLine($"My Variable int = {myInt} "+ "\n");
            Console.WriteLine($"My Byte Bariable = {mySbyte}");
            Console.ReadKey();


        }
    }
}
