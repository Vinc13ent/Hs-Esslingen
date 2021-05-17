using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerklemmungPhilosophen
{
    public class Philosoph
    {
        private int diePhilosophenNr;
        private static Staebchen dieStaebchen;
        private static int dieAnzahl;
        private int links;// das eigene Stäbchen
        private int rechts;
        private static int[] Status;
        private static Random random = new Random();
        private const int denken = 0; // für den Status und die Lesbarkeit
        private const int hungrig = 1;
        private const int essen = 2;
        private static String[] Ausgabetext = new string[] { "_______", ".......", "|||||||" };
        // denken  , warten,     essen - lecker Spaghetti

        public Philosoph(int pPhilosophenNr, Staebchen pStaebchen, int pAnzahl)
        {
            diePhilosophenNr = pPhilosophenNr;
            dieStaebchen = pStaebchen;
            dieAnzahl = pAnzahl;
            links = diePhilosophenNr;
            rechts = (diePhilosophenNr + 1) % dieAnzahl;
            Status = new int[dieAnzahl];
        }

        public void lebe()
        {
            while (true)
            {
                // essen oder denken
                if (random.Next(10) < 3)
                {
                    dieStaebchen.hole_Stab(links);
                    dieStaebchen.hole_Stab(rechts);
                    Status[diePhilosophenNr] = essen;
                    ausgeben();
                    dieStaebchen.gebe_Stab(links);
                    dieStaebchen.gebe_Stab(rechts);
                    Status[diePhilosophenNr] = denken;
                    ausgeben();
                }
                else
                {
                    ausgeben();
                }
            }
        }


        private void ausgeben()
        {
 //           synchronized(dieStaebchen) {
                for (int i = 0; i < dieAnzahl; i++)
                {
                    System.Console.Write(Ausgabetext[Status[i]] + " ");
                }
                System.Console.WriteLine();
            }


        }
    }

