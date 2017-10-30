using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Recursive_Function
{
    class Program
    {
        static int x(int myValue, ref int counter)
        {
            counter++;
            //if value = 0
            if (myValue == 0)
                return 0;
            //if value less than 10
            else if (myValue < 10)
            {
                return x(myValue + 1, ref counter);

            }
            //if value equal or exceeds 10
            return myValue;
        }

        //static int Factorial(int n, ref int counter)
        //{
        //    counter++;
        //    if (n == 0)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return n * Factorial(n - 1, ref counter);
        //    }

        //}


            static void Main(string[] args)
            { 


            int counter = 0, myResult, myValue = 4;
            myResult = x(myValue, ref counter);
            WriteLine($"My Result is {myResult} and Counter value is {counter}");
            ReadKey();



            //Challenge 32 
            // Find Factorial of the number n where n =5;

            //int MyReslut, counter = 0;
            //MyReslut = Factorial(5, ref counter);
            //WriteLine($"The Factorial is = {MyReslut}\nand the counter value = {counter}");
            //ReadKey();

            }
    }
}
