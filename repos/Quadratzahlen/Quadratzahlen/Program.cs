using System;

namespace Quadratzahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = 0;
            Console.WriteLine("**********");
            Console.WriteLine("***For****");
            Console.WriteLine("**********");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "² " + i * i);
            }
            Console.WriteLine("**********");
            Console.WriteLine("***While**");
            Console.WriteLine("**********");
            while (w <= 10)
            {
                Console.WriteLine(w + "² " + w * w);
                w++;
            }
        }
    }
}
