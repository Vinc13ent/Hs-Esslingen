using System;

namespace Sanduhr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie breit soll die Sanduhr sein");
            int breite = Convert.ToInt32(Console.ReadLine());
            for (int i = breite; i > 0; i -= 2)
            {
                for (int k = (breite - i) / 2; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
            for (int i = (breite % 2) + 1; i <= breite; i += 2)
            {
                for (int k = (breite - i) / 2; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0 ; j <= i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}
