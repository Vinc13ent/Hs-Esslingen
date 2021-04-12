using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ampel_Event
{
    class Auto
    {
        private String _kennzeichen;
        private Ampel _ampel;

        public Auto(Ampel ampel, String kennzeichen)
        {
            _kennzeichen = kennzeichen;
            _ampel = ampel;
            _ampel.ampelgruen += wach_auf;
        }

        public void wach_auf()
        {
            Console.WriteLine("Auto " + _kennzeichen +" fährt");
            abmelden();
        }

        public void abmelden()
        {
            _ampel.ampelgruen -= wach_auf;
        }
    }
}
