using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_ClassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars myCarsObj = new Cars();


            Toyota myToyotaObj = new Toyota();
            //myObj.PrintEngineSize();
            //myObj.PrintModel();
            // myObj.PrintEngineCapacity();

            Nissan myNissanObj = new Nissan();
            Ford myFordObj = new Ford();


            myCarsObj.PrintMake();
            myFordObj.PrintMake();
            myNissanObj.PrintMake();
            myToyotaObj.PrintMake();


            Console.ReadKey();
        }
    }
}
