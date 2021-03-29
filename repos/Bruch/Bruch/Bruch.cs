using System;
using System.Collections.Generic;
using System.Text;

namespace Bruch
{
    class Bruch
    {
        private int _nenner;
        private int _zähler;
        //Konstruktor
        public Bruch()
        {
            _nenner = 1;
            _zähler = 1;
        }
        //Konstrktor
        public Bruch(int nenner)
        {
            _nenner = nenner;
            _zähler = 1;
        }
        //Konstruktor
        public Bruch( int zähler, int nenner)
        {
            _zähler = zähler;
            _nenner = nenner;
        }

        //Funktion
        public String AlsString()
        {
            String S1 = String.Format("{0}/{1}", _zähler, _nenner);
            return S1;
        }

        //Funktion
        public void KehreUm()
        {
            int temp = _nenner;
            _nenner = _zähler;
            _zähler = temp;
        }
        //Propetry
        public int Nenner
        {
            get
            {
                return _nenner;
            }
            set
            {
                _nenner = value;
            }
        }

        //Property
        public int Zähler
        {
            get
            {
                return _zähler;
            }
            set
            {
                _zähler = value;
            }
        }

        //Property
        public double Dezimal
        {
            get
            {
                double d = _nenner / _zähler;
                return d;
            }
        }

        //Methode
        public static int BerechneGgT(int nenner, int zähler )
        {
            int min = Math.Min(nenner, zähler);
            int ggT = 1;

            for (int i = 1; i <= min; i++)
            {
                // Wir prüfen, ob i beide Zahlen teilt.
                bool teiltZahl1 = (nenner % i) == 0;
                bool teiltZahl2 = (zähler % i) == 0;

                if (teiltZahl1 && teiltZahl2)
                {
                    /* i ist ein gemeinsamer Teiler. 
                     * Weil wir i immer erhöhen, ist es auf jeden 
                     * Fall größer als der bisherige ggT. */
                    ggT = i;
                }
            }

            return ggT;

        }

        //Methode
        public void Kürze()
        {
            int ggt = BerechneGgT(_nenner, _zähler);
            _nenner /= ggt;
            _zähler /= ggt;
        }

    }
}
