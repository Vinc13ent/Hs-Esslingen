using System;

namespace Parkhaus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Einfahrt Monat.Tag Stunde:Minute ");
            String ein = Console.ReadLine();
            Console.WriteLine("Einfahrt Monat.Tag Stunde: Minute");
            String aus = Console.ReadLine();

            String[] einarry = ein.Split(" ");
            String[] datumein = einarry[0].Split(".");
            String[] zeitein = einarry[1].Split(":");
            float stundeein = float.Parse(zeitein[0]);
            float minuteein = float.Parse(zeitein[1]);
            float monatein = float.Parse(datumein[1]);
            float tagein = float.Parse(datumein[0]);

            String[] ausarry = aus.Split(" ", 0);
            String[] datumaus = einarry[0].Split(".");
            String[] zeitaus = einarry[1].Split(":");
            float stundeaus = float.Parse(zeitaus[0]);
            float minuteaus = float.Parse(zeitaus[1]);
            float monataus = float.Parse(datumaus[1]);
            float tagaus = float.Parse(datumaus[0]);

            if ((monataus - monatein) > 0)
            {

            }


        }
    }
}
