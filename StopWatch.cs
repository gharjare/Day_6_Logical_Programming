using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgammimgproblem
{
    public class StopWatch
    {
        public static void CheckTime()
        {
            
            


                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("HI");
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed : {0}",
                    stopwatch.Elapsed);
                Console.ReadLine();

            
        }
    }
}
