using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Runde_ausgeben
{
    class Person
    {
        public Person(Form1 gui)
        {
            this.gui = gui;
        }
        public string Name { get; set; }

        public void Eintreten(Bar bar)
        {
            bar.EsWirdEineRundeAusgegeben += RundeEmpfangen;
        }

        public void Verlassen(Bar bar)
        {
            bar.EsWirdEineRundeAusgegeben -= RundeEmpfangen;
        }

        public void RundeEmpfangen(string name)
        {
            if (name != Name)
                gui.ausgebenText(Name + " freut sich über ein Getränk von " + name);
        }

        Form1 gui;
    }
}

