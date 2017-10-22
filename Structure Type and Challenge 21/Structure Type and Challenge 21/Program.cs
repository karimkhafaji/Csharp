using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Type_and_Challenge_21
{
    class Program
    {
        enum toyota : byte
        {
            RAV4 = 1,
            Camery = 2,
            Tundra = 3,
            Highland = 4
        }
        struct carType
        {

            public toyota modelName;
            public double modelYear;
        }

        static void Main(string[] args)
        {
            carType myCarType;
            int carType = -1;
            double modelYear;
            Console.WriteLine("1) RAV4\n2) Camery\n3) Tundra\n4) Highland ");
            do
            {
                Console.WriteLine("Enter Your Car Type:");
                carType = Convert.ToInt32(Console.ReadLine());
            }
            while ((carType < 1) || (carType > 4));

            Console.WriteLine("Input a modelYear :");
            modelYear = Convert.ToDouble(Console.ReadLine());

            myCarType.modelName = (toyota)carType;
            myCarType.modelYear = modelYear;
            Console.WriteLine($"My Car Type is {myCarType.modelName} " + $"and the model Year is {myCarType.modelYear}");
            Console.ReadKey();

            //Q21/ Define a struct that contains the directions by the orientation
            //as a enum and the distance to reach a destination
            // and print the direction and that distance


            //enum orientation : sbyte
            //{
            //    south = 1,
            //    north = 2,
            //    west = 3,
            //    east = 4

            //}
            //struct var
            //{
            //    public orientation var1;
            //    public Int16 var5;
            //}


            //static void Main(string[] args)
            //{
            //    int var, var2; orientation var1;
            //    //var3 = Convert.ToInt32(var2);
            //    Console.WriteLine("1- south\n\n2- north\n\n3- west\n\n4- east\n\n");
            //    do
            //    {
            //        Console.WriteLine("enter your the destination");
            //        var = Convert.ToInt16(Console.ReadLine());

            //    } while ((var < 1) || var > 4);
            //    Console.WriteLine("enter your distance");
            //    var2 = Convert.ToInt32(Console.ReadLine());
            //    var1 = (orientation)var;
            //    Console.WriteLine($"your the destination is {var1} and your distance is {var2}");
            //    Console.ReadKey();

        }
    }
}
