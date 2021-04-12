using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gluecksrad_Rumpf
{
    class Spieler
    {
        Gluecksrad _dasRad;       //der Spieler sieht das Rad - warum??
        Form1 _form1;             //der Spieler sieht form1 - warum?
        char _name;               //der Spieler ist einsilbig, der Name hat nur einen Buchstaben...
        Random r = new Random();  //nötig um Zufallszahlen zu erzeugen
        private int gesetzteZahl; //braucht man nicht nur für die Ausgabe sondern auch für....?

        public Spieler(Gluecksrad dasRad, char v, Form1 form1)
        {
            _dasRad = dasRad;
            _name = v;
            _form1 = form1;
        }

        public void setzen()
        {
            gesetzteZahl = r.Next(3);    //liefert eine Ganzzahl zwischen 0 und 2;
            switch (gesetzteZahl)
            {
                case 0:

                     break;
                case 1:
                    break;

                case 2:

                    break;
            }
        }

        public void loeschen()        // das Spiel kann wiederholt werden
        {
         }

        //Event-Handler
        private void Gewinnmeldung()
        {
            _form1.ausgeben(_name + " hat mit " + gesetzteZahl + " gewonnen" + Environment.NewLine);
        }


    }
}
