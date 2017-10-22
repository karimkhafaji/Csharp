using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Variables
{
    class Program
    {
        //enum humanSex : sbyte
        //{
        //    male =1,
        //    female=2
        //}

        enum orientation : sbyte
        {
            north = 2, East = 3, west = 4, south = 5
        }

     

            static void Main(string[] args)
        {
            //sbyte humanSbyte;
            //string humanGender;
            //humanSex myhumanSex = humanSex.male;
            //Console.WriteLine($"Human Sex = {myhumanSex}" + "\n");

            //humanSbyte = (sbyte)myhumanSex;
            //Console.WriteLine($"Human Gender index = {humanSbyte}"+ "\n");

            //humanGender = Convert.ToString(myhumanSex);
            //Console.WriteLine($"Human associated with this index = {humanGender}"+"\n");
            //Console.ReadKey();

            sbyte orien1, orien2, orien3, orien4;
            string index1, index2, index3, index4;


            orientation oriennorth = orientation.north;
            orientation orieneast = orientation.East;
            orientation orienwest = orientation.west;
            orientation oriensouth = orientation.south;
            Console.WriteLine("the orientations is :\n {0}\n {1}\n {2}\n {3}\n", oriennorth, orieneast, orienwest, oriensouth);
            orien1 = (sbyte)oriennorth;
            orien2 = (sbyte)orieneast;
            orien3 = (sbyte)orienwest;
            orien4 = (sbyte)oriensouth;

            Console.WriteLine(" orientation index is : {0}\n orientation index is : {1}\n orientation index is : {2}\n" +
                " orientation index is : {3}\n", orien1, orien2, orien3, orien4);
            index1 = Convert.ToString(oriennorth); index2 = Convert.ToString(orieneast);
            index3 = Convert.ToString(orienwest); index4 = Convert.ToString(oriensouth);
            Console.WriteLine($"orientation associated with this index = {index1}\n" + $"orientation associated with this index = {index2}\n"
             + $"orientation associated with this index = {index3}\n" + $"orientation associated with this index = {index4}\n");


            Console.ReadKey();

        }
    }
}
