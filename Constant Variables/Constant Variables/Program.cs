using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_Variables
{
    class Program
    {
        //public const double pi = 3.14;
        static void Main(string[] args)
        {
            ReadOnlyFields myObj = new ReadOnlyFields();

            Console.WriteLine($"{ReadOnlyFields.pi}");
            Console.ReadKey();
        }
    }
}
