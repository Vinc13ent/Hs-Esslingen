using System;

namespace Summe_von_Zahle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Startwert");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Endwert");
            int end = Convert.ToInt32(Console.ReadLine());
            int summe = 0;
            for (; start <= end; start++)
            {
                summe += start;
            }
            Console.WriteLine("Summe" + summe );
        }
    }
}
