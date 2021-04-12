
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gluecksrad_Rumpf
{
    class Gluecksrad
    {
        private Random r = new Random();
        //delegate fehlt
        //events fehlen - Achtung die events können nicht in einem Feld verwaltet werden!



        public void DreheRad()
        {
            int zahl = r.Next(3);
            switch (zahl)
            {
                case 0:



                    break;
                case 1:



                    break;
                case 2:




                    break;
            }
        }

    }
}
