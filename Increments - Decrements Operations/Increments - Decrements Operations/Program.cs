using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increments___Decrements_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            int myVar1 = 5;
            int myVar2 = 9;
            int temp1 = ++myVar1;
            int temp2 = --myVar2;
            Console.WriteLine("{0}\n{1}", temp1, temp2);
            Console.ReadKey();

        }
    }
}
