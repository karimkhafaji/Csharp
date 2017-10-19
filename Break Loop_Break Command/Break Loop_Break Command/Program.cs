using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Loop_Break_Command
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Hello Karim");
                if (i > 3)
                    break;
                for (int j = 0; j <= 4; j++)
                {
                    Console.WriteLine("\t Hello World");
                }
                Console.WriteLine("\n");

            }
            Console.ReadKey();
        }
    }
}
