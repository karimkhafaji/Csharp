using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DateTime_Type
{
    class Program
    {
        static void Main(string[] args)
        {

            //WriteLine(DateTime.Now.ToString("hh:mm:ss \ndd MM yyyy"));


            //DateTime time = DateTime.Now;
            //string format = "dd MM yyyy  h:mm";
            //WriteLine(time.ToString(format));

            //DateTime time = DateTime.Now;
            //string format = "ddd d MMM yyyy  hh:mm";
            //WriteLine(time.ToString(format));


            //DateTime now = DateTime.Now;
            //WriteLine(now.ToString("d"));
            //WriteLine(now.ToString("D"));
            //WriteLine(now.ToString("f"));
            //WriteLine(now.ToString("F"));
            //WriteLine(now.ToString("g"));
            //WriteLine(now.ToString("G"));
            //WriteLine(now.ToString("m"));
            //WriteLine(now.ToString("M"));
            //WriteLine(now.ToString("o"));
            //WriteLine(now.ToString("O"));
            //WriteLine(now.ToString("s"));
            //WriteLine(now.ToString("t"));
            //WriteLine(now.ToString("T"));
            //WriteLine(now.ToString("u"));
            //WriteLine(now.ToString("U"));
            //WriteLine(now.ToString("y"));
            //WriteLine(now.ToString("Y"));


            //DateTime now = DateTime.Now;
            ////use space after s to avoid one-char date format
            //string result = now.ToString("m ");
            //WriteLine($"{now} m = {result}");

            DateTime now = DateTime.Now;
            for (int i = 0; i < 7; i++)
            {
                WriteLine(now.ToString("dddd"));
                now = now.AddDays(1);

            }
                

            ReadKey();
        }
    }
}
