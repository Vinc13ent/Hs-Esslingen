using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ampel_Event
{
    class Ampel
    {
        enum Farbwerte { rot, gelb, gruen }
        private Farbwerte _farbe = Farbwerte.rot;
        private Thread _ampel_thread;
        public Ampel()
        {
            _ampel_thread = new Thread(eingeschaltet);
            _ampel_thread.Start();
        }

        public delegate void AmpelgruenHandler();
        public event AmpelgruenHandler ampelgruen;

        private void eingeschaltet()
        {
            while (true)
            {
                Console.WriteLine(_farbe.ToString());
                switch (_farbe)
                {
                    case Farbwerte.rot:
                        Thread.Sleep(1000);
                        _farbe = Farbwerte.gelb;
                        break;
                    case Farbwerte.gelb:
                        Thread.Sleep(200);
                        _farbe = Farbwerte.gruen;
                        break;
                    case Farbwerte.gruen:
                        if (ampelgruen != null)//warten Autos?
                        {
                            ampelgruen();
                        }
                        Thread.Sleep(1000);
                        _farbe = Farbwerte.rot;
                        break;
                }
            }
        }

    }
}
