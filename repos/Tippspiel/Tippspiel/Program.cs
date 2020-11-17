using System;

namespace Tippspiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Was haten sie getippt wie viele tore ihr Team kassiert: ");
            float tipTorHeim = float.Parse(Console.ReadLine());
            Console.WriteLine("Was haten sie getippt wie viele tore ihr Team macht: ");
            float tipTorGeg = float.Parse(Console.ReadLine());
            Console.WriteLine("Wie viele tore musste ihr Team tatzächlich einstecken: ");
            float resTorHeim = float.Parse(Console.ReadLine());
            Console.WriteLine("Wie viele tore hat ihr team tatzächlich gemacht: ");
            float resTorGeg = float.Parse(Console.ReadLine());
            Console.Write("Ergebnis: " + resTorHeim + ":" + resTorGeg + " Tipp: " + tipTorHeim + ":" + tipTorGeg);

            if ((tipTorHeim == resTorHeim) && (tipTorGeg == resTorGeg))
            {
                Console.WriteLine(" Punkte: 3 Begründung: Korrektes Ergebnis.");
            }
            else if ((tipTorGeg - tipTorHeim) == (resTorGeg - resTorHeim))
            {
                Console.WriteLine(" Punkte: 2 Begründung: richtige Tordifferenz.");
            }
            else if (((tipTorGeg < tipTorHeim) && (resTorGeg < resTorHeim)) || ((tipTorGeg > tipTorHeim) && (resTorGeg > resTorHeim)))
            {
                Console.WriteLine(" Punkte: 1 Begründung: Tendenz richtig.");
            }
            else
            {
                Console.WriteLine(" Punkte: 0 Begründung: komplett falsch.");
            }

        }
    }
}
