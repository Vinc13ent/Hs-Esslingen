using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadNamenlesen
{
    class Namen
    {
        public Namen()
        {
        }

        public void setNamen(String Vnamen, String NNamen)
        {
            _vornamen = Vnamen;
            System.Threading.Thread.Sleep(1);
            _nachnamen = NNamen;
        }

        public String getNamen()
        {
            System.Threading.Thread.Sleep(2);
            return _vornamen + " " + _nachnamen;
        }

        private String _vornamen;
        private String _nachnamen;
    }
}
