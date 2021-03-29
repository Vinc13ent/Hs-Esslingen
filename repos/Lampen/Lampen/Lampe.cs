using System;
using System.Collections.Generic;
using System.Text;

namespace Lampen
{
    class Lampe
    {
        public Lampe(int _watt, bool _led)
        {
            int watt = _watt;
            bool led = _led;
        }

        public static int BerechneJahresverbrauch(int BetriebsstundenProTag)
        {
            int jahresverbrauch = BetriebsstundenProTag * (365 / 1000);
            return jahresverbrauch;
        }

        public static void Leuchte(Lampe _lampe)
        {
            if (_lampe.led)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" .    |     .");
                Console.WriteLine(" \\   '    /");
                Console.WriteLine("   ' .-.  '");
                Console.WriteLine("--- (   ) ---");
                Console.WriteLine("    \\ /");
                Console.WriteLine("    _|=|_");
                Console.WriteLine("   |_____|");
            }else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" .    |     .");
                Console.WriteLine(" \\   '    /");
                Console.WriteLine("   ' .-.  '");
                Console.WriteLine("--- (   ) ---");
                Console.WriteLine("    \\ /");
                Console.WriteLine("    _|=|_");
                Console.WriteLine("   |_____|");
            }

        }
    }
}
