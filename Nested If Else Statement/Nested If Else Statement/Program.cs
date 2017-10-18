using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Else_Statement
{
    class Program
    {
        static void Main(string[] args)
        {

            int myvar1 = 9 , myvar2 = 6;

            if (myvar1 == 10)
            {
                Console.WriteLine("myvar1 equal 9");
                if (myvar2 == 7)
                {
                    Console.WriteLine("myvar2 == 6");
                }
                else
                {
                    Console.WriteLine("myvar2 is not eqaul 6");
                }
            }
            else
            {
                Console.WriteLine("myvar1 is not equal 10");
            }
            Console.ReadKey();
        }
    }
}
