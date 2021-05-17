using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadNamenlesen
{
    class Namenlesen
    {
        public Namenlesen(Namen dieNamen)
        {
            _namen = dieNamen;
        }

        public void lesen()
        {
            for (int i=0;i<100;i++)
            {
                 Console.WriteLine(_namen.getNamen());
            }
        }

        private Namen _namen;
    }
}
