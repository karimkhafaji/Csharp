using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Statement_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar1 = 4, myvar2 = 6;

            if (myvar1 <= 3 && myvar2 >= 5)
            {
                Console.Write("condition one is right");
            }
            else if  (myvar1 <= 4 && myvar2 >= 6)
            {
                Console.WriteLine("condition two is right");
            }
            else if (myvar2 > 5)
            {
                Console.WriteLine("condition three is right");

            }
            else
            {
                Console.WriteLine("nothing right of the conditions");
            }
            Console.ReadKey();
        }
    }
}
