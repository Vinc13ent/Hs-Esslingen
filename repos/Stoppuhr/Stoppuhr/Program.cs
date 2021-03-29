using System;
using System.Diagnostics;

namespace Stoppuhr
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();
            int x = 0;
            for (int i = 1; i <= 1000; i++)
            {
                x += i;
            }
            Console.WriteLine(x);
            stop.Stop();
            Console.WriteLine(stop.ElapsedMilliseconds);
        }
    }
}
