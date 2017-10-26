using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Type
{
    delegate int MyNewNumber(int myNumber);
    class Program
    {
        static int myXnumber = 5;
        static int addFunct(int number)
        {
            myXnumber += number;
            return myXnumber;
        }
        static int mulFunct(int number1)
        {
            myXnumber *= number1;
            return myXnumber;

        }
        static void Main(string[] args)
        {
            MyNewNumber n1 = new MyNewNumber(addFunct);
            MyNewNumber n2 = new MyNewNumber(mulFunct);
            n1(4);Console.Write($"{myXnumber}\n");
            n2(5);Console.Write($"{myXnumber}");
            Console.ReadKey();

        }
    }
}
