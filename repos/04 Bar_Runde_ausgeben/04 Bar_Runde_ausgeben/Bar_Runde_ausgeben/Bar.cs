using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Runde_ausgeben
{
    class Bar
    {
        public delegate void D_rundeausgeben(string name);
        public event D_rundeausgeben EsWirdEineRundeAusgegeben;

        public void Rundevon(string name)
        {
            if (EsWirdEineRundeAusgegeben != null)
                EsWirdEineRundeAusgegeben(name);
        }

    }
}
