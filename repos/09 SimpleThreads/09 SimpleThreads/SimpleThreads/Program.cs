using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            MeineKlasse einObjektmeinerKlasse = new MeineKlasse();
            Thread neuerThread = new Thread(einObjektmeinerKlasse.meineMethode);
            neuerThread.Start(12);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Der alte Thread läuft weiter...");
                Thread.Sleep(1000);
            }
        }
    }
}
