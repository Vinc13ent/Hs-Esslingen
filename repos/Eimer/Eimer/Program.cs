using System;

namespace Eimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viel liter sind in Eimer A");
            float x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie viel liter sind in Eimer B");
            float y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie viel Prozent an wasser soll aus Eimmer A in Eimer B");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie viel Prozent an wasser soll aus Eimmer B in Eimer A");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie oft soll der vorgang wiederholt werden");
            float n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                float wasserAusA = x * (a / 100);
                x -= wasserAusA;
                y += wasserAusA;
                float wasserAusB = y * (b / 100);
                y -= wasserAusB;
                x += wasserAusB;

            }
            Console.WriteLine(x + ", " + y);
        }
    }
}
