using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadNamenlesen
{
    class Namenschreiben
    {
        public Namenschreiben(Namen dieNamen)
        {
            _namen = dieNamen;
        }

        public void schreiben()
        {
            for (int i = 0; i < 100; i++)
            {
                _namen.setNamen("Donald", "Trump");
                //Console.WriteLine("--> Donald Trump");
                _namen.setNamen("Boris", "Johnson");
                //Console.WriteLine("--> Boris Johnson");
            }
            Console.ReadKey();
        }
        Namen _namen;
    }
}
