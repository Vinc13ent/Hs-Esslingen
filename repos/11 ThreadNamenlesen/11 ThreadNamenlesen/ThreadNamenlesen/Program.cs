using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadNamenlesen
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread schreibeThread = new Thread(_schreiben.schreiben);
            Thread leseThread = new Thread(_lesen.lesen);
            schreibeThread.Start();
            leseThread.Start();
        }
        private static Namen _namen = new Namen();
        private static Namenschreiben _schreiben = new Namenschreiben(_namen);
        private static Namenlesen _lesen = new Namenlesen(_namen);
    }
}
