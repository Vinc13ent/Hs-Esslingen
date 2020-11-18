using System;

namespace Domino_Steine
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 6; i++)
            {
                for (int j = i; j <= 6; j++)
                {
                    Console.Write("(" + i + "|" + j + ")");
                }
                Console.WriteLine();
            }
        }
    }
}
