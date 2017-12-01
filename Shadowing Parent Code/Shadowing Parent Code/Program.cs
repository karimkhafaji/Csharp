using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowing_Parent_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Finance myFinanObj = new Finance();
            myFinanObj.PrintName();

            //Method of the Parent!
            ((HumRe)myFinanObj).PrintName();
            Console.ReadKey();

        }
    }
}
