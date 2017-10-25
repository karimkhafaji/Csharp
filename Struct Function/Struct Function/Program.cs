using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Function
{
    class Program
    {
            struct FullName
            {
            public string myFirstName, myLastName;
            public string printName() => myFirstName + " " + myLastName;
            }
        static void Main(string[] args)
        {
            FullName myFullname;
            myFullname.myFirstName = "Karim";
            myFullname.myLastName = "Khafaji";
            //Console.Write($"{myFullname.myFirstName} {myFullname.myLastName}");
            Console.Write(myFullname.printName());
            Console.ReadKey();
        }
    }
}
