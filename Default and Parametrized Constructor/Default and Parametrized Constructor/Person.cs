using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Default_and_Parametrized_Constructor
{
    class Person
    {
        //Member Variables
        string name;
        int age;


        public void PrintValues()
        {
            WriteLine($"{name} , {age}");
        }

        //Deafult
        public Person()
        {
            name = "Karim Khafaji";
            age = 25;

        }
        //Parametrized Constructor
        public Person(string name)
        {
            this.name = name;
            age = 24;

        }
        //Parametrized Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;

        }

    }
}
