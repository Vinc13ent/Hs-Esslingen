using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerklemmungPhilosophen
{
    public class Staebchen
    {
        private Boolean[] dieStaebchen;
        public Staebchen(int dieAnzahl)
        {
            dieStaebchen = new Boolean[dieAnzahl];
            for (int i = 0; i < dieAnzahl; i++)
            {
                dieStaebchen[i] = true;
            }
        }
        public void hole_Stab(int i)
        {
            while (dieStaebchen[i] == false) { };//aktives Warten
            dieStaebchen[i] = false;
        }

        public void gebe_Stab(int i)
        {
            dieStaebchen[i] = true;
        }
    }
}
