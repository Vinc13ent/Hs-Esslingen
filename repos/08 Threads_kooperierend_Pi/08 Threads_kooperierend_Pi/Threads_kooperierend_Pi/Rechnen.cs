using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads_kooperierend_Pi
{
    class Rechnen
    {
        public Rechnen(long Startwert, long Endwert, long n)
        {
            _Startwert = Startwert;
            _Endwert = Endwert;
            _n = n;
            w = 1.0 / (double)n;
        }

        public void rechne()
        {
            for (long i = _Startwert; i <= _Endwert; i++)
            {
                x = w * ((double)i - 0.5);
                sum += 4 / (1 + x * x);
            }
        }

        public double getSumme()
        {
            return w * sum;
        }

        private long _Startwert, _Endwert, _n;
        private double w, x;
        private double sum = 0;
    }
}
