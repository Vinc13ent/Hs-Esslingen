using System;

namespace Mitternachtsformel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c:");
            int c = Convert.ToInt32(Console.ReadLine());
            double D = (b * b) - (4 * a * c);
            double n1;
            double n2;
            if (D < 0)
            {
                Console.WriteLine("Angaben haben keine Reale Lösung");
            } else if (D == 0)
            {
                n1 = (0 - b) / (2 * a);
                Console.WriteLine("Es gibt nur eine Nullstelle bei x = " + n1);
            }
            else
            {
                n1 = ((0 - b) + (Math.Sqrt((b * b) - (4 * a * c)))) / 2 * a;
                n2 = ((0 - b) - (Math.Sqrt((b * b) - (4 * a * c)))) / 2 * a;
                Console.WriteLine("Die Nullstellen liegen bei x1 = " + n2 + " und x2 = " + n1);
            }
        }
    }
}
