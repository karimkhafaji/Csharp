using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Static_Classes
{
    static class Employees1
    {
        static public string name = "Karim Khafaji";
        static public int age = 24;

        static public void PrintName()
        {
            WriteLine($"{name} , {age}");
        }

    }
}
