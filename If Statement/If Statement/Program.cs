using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {

            //int myVar = 10;

            //if (myVar == 20)
            //    Console.WriteLine("My Value is Equel 10");
            //else
            //    Console.WriteLine("My Value is not Equel 10");

            //Console.ReadKey();


            //int myVar1 = 9, myVar2 = 7;
            //if ((myVar1 <= 4) || (myVar2 >= 55))
            //{
            //    Console.WriteLine("the condition is true");

            //}

            //else
            //{
            //    Console.WriteLine("the condition is false");
            //}
            //Console.ReadKey();

            int myvari1 = 100;
            string myResult;

            if (myvari1 < 10) 
            {
                myResult = "less than 10";
                Console.WriteLine(myResult);
            
            }

            if (myvari1 > 10) 
            {
                myResult = "greater than 10";
                Console.WriteLine(myResult);
            }
            if (myvari1 == 10)
            {
                myResult = "equal 10";
                Console.WriteLine(myResult);
            }
            Console.ReadKey();


        }
    }
}
