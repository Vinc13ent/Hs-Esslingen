using System;

namespace Widerstände
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wiederstand R1:");
            double r1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Wiederstand R2:");
            double r2 = double.Parse(Console.ReadLine());
            double reihe = r1 + r2;
            double parallel = (r1 * r2) / (r1 + r2);
            Console.WriteLine("Gesamtwiederstand in Reiehe: " + reihe);
            Console.WriteLine("Gesamtwiederstand parallel: " + parallel);
        }
    }
}
