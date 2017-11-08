using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Karim Khafaji";
            int age = 25;
            Person myObj = new Person();
            myObj.SetName(name);
            myObj.SetAge(age);

            Console.WriteLine("Name is " + myObj.GetName());
            Console.WriteLine("Age is " + myObj.GetAge());
            Console.ReadKey();

        }
    }
}
