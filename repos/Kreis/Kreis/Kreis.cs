using System;
using System.Collections.Generic;
using System.Text;

namespace Kreis
{
    class Kreis
    {
        private double _X;
        private double _Y;
        private double _radius;
        private double PI = 3.14;

        //Konstruktor
        public Kreis(double radius)
        {
            _X = 0;
            _Y = 0;
            _radius = radius;
        }

        //Konstruktor
        public Kreis(double X, double Y, double radius)
        {
            _X = X;
            _X = Y;
            _radius = radius;
        }


        //Funktion
        public double BerechneUmfang()
        {
            double umfang = 2 * PI * _radius;
            return umfang;
        }

        //Funktion 
        public void VerschiebeUmEinsNachRechts()
        {
            _X += 1;
        }

        //Funktion
        public Kreis Dupliziere()
        {
            Kreis duplikat = new Kreis(_X, _Y, _radius);
            return duplikat;
        }

        //Funktion
        public void VerschiebeAnPosition(double x, double y)
        {
            _X = x;
            _Y = y;
        }

        //Funktion
        public bool InsMitteInQuadrant(int q)
        {
            int quadrant;
            if (_X > 0)
            {
                if (_Y > 0)
                {
                    quadrant = 1;
                }
                else
                {
                    quadrant = 4;
                }
            }
            else
            {
                if (_Y > 0)
                {
                    quadrant = 2;
                }
                else
                {
                    quadrant = 3;
                }
            }
            if (q == quadrant)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Funktion
        public bool Schneidet(Kreis andererKreis)
        {
            double dx = andererKreis._X - _X;
            double dy = andererKreis._Y - _Y;
            double abstand = Math.Sqrt(dx * dx + dy * dy);

            return abstand < _radius + andererKreis._radius;
        }

        //Property
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
    }
}
