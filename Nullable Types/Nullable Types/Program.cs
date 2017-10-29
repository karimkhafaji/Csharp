using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {

            string myString = null;         //only string type accept the value null without "?" Question mark
            int? myVariable = null;
            double? myDouble = null;
            WriteLine(myString);
            WriteLine(myVariable);
            WriteLine(myDouble);
            ReadKey();
        }
    }
}
