using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgammimgproblem
{
    public class TempratureConversion
    {
        public static void CheckTemp()
        {
            double fahrenheit = 97;
            double celsius = 36;
             

           

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheite:" + fahrenheit);

            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius:" + celsius);

        }
    }
}
