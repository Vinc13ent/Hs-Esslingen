using System;

namespace Übungsaufgabe_Vorlesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eingabe 1 bitte: ");
            int eingabe1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eingabe 2 bitte: ");
            int eingabe2 = Convert.ToInt32(Console.ReadLine());

            int summe = eingabe1 + eingabe2;
            int dif1 = eingabe1 * eingabe2;
            
            Console.WriteLine("Die Summe ist: " + summe);
            Console.WriteLine("Das Produckt ist: " + dif1);

        }
    }
}
