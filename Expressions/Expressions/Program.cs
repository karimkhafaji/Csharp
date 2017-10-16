using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            float myVari = 10.5f; //operand1  
            float myVari2 = 10.7f; //operand2

            float temp = myVari + myVari2; // expressions

            Console.WriteLine("{0}", temp);
            Console.ReadKey();

            // - + / * simple or basic operators
            // bitwise operations 
            // logical operators : boolean true , false 


            //operands types :
            //1 - unary operand , the rest of the operations 
            //2 - binary operand , 75% of the operations 
            //3 - 3 "ternary" , operands only one operation
        }
    }
}
