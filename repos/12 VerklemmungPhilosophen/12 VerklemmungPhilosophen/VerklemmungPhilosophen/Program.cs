using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace VerklemmungPhilosophen
{
    class Program
    {
        private static int dieAnzahl = 10;
        private static Philosoph[] diePhilosophen = new Philosoph[dieAnzahl];
        private static Thread[] dieThreads = new Thread[dieAnzahl];
        private static Staebchen dieStaebchen;

        static void Main(string[] args)
        {
            dieStaebchen = new Staebchen(dieAnzahl);
            for (int i = 0; i < dieAnzahl; i++)
            {
                diePhilosophen[i] = new Philosoph(i, dieStaebchen, dieAnzahl);
                dieThreads[i] = new Thread(diePhilosophen[i].lebe);
            }
             for (int i = 0; i < dieAnzahl; i++)
            {
                dieThreads[i].Start();
            }
        }
    }
}

