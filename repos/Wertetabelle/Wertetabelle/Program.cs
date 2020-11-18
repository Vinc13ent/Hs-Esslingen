using System;

namespace Wertetabelle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Einen Startwert ");
            double xAnf = double.Parse(Console.ReadLine());
            Console.WriteLine("Einen Endwert ");
            double xEnd = double.Parse(Console.ReadLine());
            Console.WriteLine("Eine Schrittwert ");
            double xDelta = double.Parse(Console.ReadLine());
            for ( ;xAnf <= xEnd ; xAnf += xDelta)
            {
                Console.WriteLine(xAnf + "² = " + (xAnf * xAnf));
            }

        }
    }
}
