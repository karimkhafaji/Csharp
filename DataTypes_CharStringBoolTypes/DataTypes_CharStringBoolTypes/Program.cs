using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_CharStringBoolTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = char.MinValue;
            int charMax = char.MaxValue;

            char myVar = 'G';
            int myVarValue = 'G';

            char myVarvalue2 = Convert.ToChar(myVarValue);
            Console.WriteLine("Min char = {0} Max char = {1} My character = {2} My Variable Nummber = {3} My Conversion Value = {4}", charMin, charMax, myVar, myVarValue, myVarvalue2);

            String myString = "this is my Variable";
            Console.WriteLine("\nmyString is {0}", myString);

            bool myBool = true;
            Console.WriteLine("my boolean value is {0}", myBool);

            Console.ReadKey();
        }
    }
}
