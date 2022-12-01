using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgammimgproblem
{
    public class ReverseNumber
    {
        public static void CheckReverse()
        {
            int num, rem, reverse = 0;

            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            while(num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse number "+ reverse);
        }
    }
}
