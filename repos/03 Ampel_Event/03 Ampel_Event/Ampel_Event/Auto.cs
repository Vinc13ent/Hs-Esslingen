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

        public Auto(String kennzeichen)
        {
            _kennzeichen = kennzeichen;
        }

        public void wach_auf()
        {
            Console.WriteLine("Auto " + _kennzeichen +" fährt");
        }
    }
}
