using System;

namespace AbstandsBerechnungMitGeoKoordinaten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Längengrad Punkt eins Bitte:");
            float l1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Breitengrad Punkt eins Bitte:");
            float b1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Längengrad Punkt zwei Bitte:");
            float l2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Breitengrad Punkt zwei Bitte:");
            float b2 = float.Parse(Console.ReadLine());
            double dx = 111.3 * Math.Cos((b1 * Math.PI) / 180) * (l1 -l2);
            double dy = 111.3 * (b1 - b2);
            double res = Math.Sqrt((dx * dx) + (dy * dy));
            Console.WriteLine("Der Abstand beträgrt " + res + "Km");
        }

    }
}
