using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgammimgproblem
{
    public class Binary
    {
        public static void DToBConversion()
        {
            double fractional, no, number;
            long integer, rem, i = 0;
            long[] integerBinary = new long[100];
            Console.WriteLine("Enter any number : ");
            number = Convert.ToDouble(Console.ReadLine()); 
            no = number;
            integer = Convert.ToInt32(no); 
            fractional = no - integer; 
            while (integer > 0) 
            {
                rem = integer % 2;
                integer /= 2;
                integerBinary[i] = rem;
                i++;
            }
            for (long j = i - 1; j >= 0; j--) 
            {
                Console.Write(integerBinary[j]);
            }
            Console.Write(".");
            for (long k = 1; k <= 8; k++)
            {

            
                fractional = fractional * 2;
                double temp = fractional;
                int fractionalBinary = (int)(temp);
                if (fractionalBinary > 1)
                    break;
                Console.Write(fractionalBinary);
                if (temp == 1)
                    fractional = fractional - temp;
            }
        }
    }
}
