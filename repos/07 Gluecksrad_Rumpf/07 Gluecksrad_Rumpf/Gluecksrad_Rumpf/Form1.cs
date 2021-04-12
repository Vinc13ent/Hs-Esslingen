using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gluecksrad_Rumpf
{
    public partial class Form1 : Form
    {
        private const int AnzahlSpieler = 3;               //könnten auch mehr sein
        Spieler[] dieSpieler = new Spieler[AnzahlSpieler]; //die Spieler werden in einem Feld verwaltet
        Gluecksrad gluecksrad = new Gluecksrad();          //klar

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < AnzahlSpieler; i++)
            {
                Thread.Sleep(10);//sonst starten alle Zufallszahlengeneratoren mit dem selben Startwert
                dieSpieler[i] = new Spieler(gluecksrad, (char)(i + 65), this); //(char)(i+65) liefert A, B, C,...
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AnzahlSpieler; i++)
            {
                dieSpieler[i].setzen();
            }
            gluecksrad.DreheRad();
            for (int i = 0; i < AnzahlSpieler; i++)
            {
                dieSpieler[i].loeschen();
            }
        }

        public void ausgeben(String Ausgabe)
        {
           // hier schreiben wir in die Textbox die Ausgabe
        }

    }
}
