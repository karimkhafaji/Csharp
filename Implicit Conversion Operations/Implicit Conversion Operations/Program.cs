using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Conversion_Operations
{
    class Program
    {
        static void Main(string[] args)
        {


            //long myVar = 1000;

            //float myVar2 = myVar;
            //Console.WriteLine($"{myVar2}");
            //Console.ReadKey();


            char myVar3 = 'G';
            int myVar4 = myVar3;
            Console.WriteLine($"{myVar4}");
            Console.ReadKey();


            // byte  -->   short, ushort, int, uint, long, ulong, float, double, decimal
            //sbyte  -->   short, int, long, float, double, decimal
            //short  -->   int, long, float, double, decimal
            //ushort -->   int, uint, long, ulong, float, double, decimal
            //int    -->   long, float, double, decimal
            //uint   -->   long, ulong, float, double, decimal
            //long   -->   float, double, decimal
            //ulong  -->   float, double, decimal
            //float  -->   double
            //char   -->   ushort, int, uint, long, ulong, float, double, decimal
        }
    }
}
