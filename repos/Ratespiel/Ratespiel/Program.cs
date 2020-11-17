using System;

namespace Ratespiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eine Zahl zwischen 1 und 1023!");
            int myth = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int guess = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            for (; myth != guess; i++ )
            {
                if (guess < myth)
                {
                    Console.WriteLine("Höher");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Niedriger");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Richtig. Und du hast nur " + i + " Versuche gebreaucht");
        }
    }
}
