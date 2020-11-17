using System;

namespace LKW_Maut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele achsen hat der LKW:");
            int achsen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In welcher schadstoffklasse befindet sich der LKW(A, B, C, D, ...):");
            String schadtoffKlasse = Console.ReadLine().ToUpper();
            Console.WriteLine("Wie viel Km sind sie mit dem LKW gefahren");
            int gefahreneKm = Convert.ToInt32(Console.ReadLine());
            double maut;
            if (achsen <= 3)
            {
                if (schadtoffKlasse == "A")
                {
                  maut = gefahreneKm * 17.3;
                }
                else if (schadtoffKlasse == "B")
                {
                    maut = gefahreneKm * 18.4;
                }
                else if (schadtoffKlasse == "C")
                {
                    maut = gefahreneKm * 19.4;
                }
                else if (schadtoffKlasse == "D")
                {
                    maut = gefahreneKm * 22.6;
                }
                else if (schadtoffKlasse == "E")
                {
                    maut = gefahreneKm * 23.6;
                }
                else if (schadtoffKlasse == "F")
                {
                    maut = gefahreneKm * 24.7;
                }else
                {
                    maut = 0;
                }
            }
            else
            {
                if (schadtoffKlasse == "A")
                {
                    maut = gefahreneKm * 18.7;
                }
                else if (schadtoffKlasse == "B")
                {
                    maut = gefahreneKm * 19.8;
                }
                else if (schadtoffKlasse == "C")
                {
                    maut = gefahreneKm * 20.8;
                }
                else if (schadtoffKlasse == "D")
                {
                    maut = gefahreneKm * 24.0;
                }
                else if (schadtoffKlasse == "E")
                {
                    maut = gefahreneKm * 25.0;
                }
                else if (schadtoffKlasse == "F")
                {
                    maut = gefahreneKm * 26.1;
                }else
                {
                    maut = 0;
                }
            }
            Console.WriteLine("Die maut beträgt:" + maut/100);
        }
    }
}
