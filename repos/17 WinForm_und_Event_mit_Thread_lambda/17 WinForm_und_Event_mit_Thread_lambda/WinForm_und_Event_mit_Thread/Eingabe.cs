using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_und_Event_mit_Thread_lambda

{
    class Eingabe
    {
        public delegate void schreibe_delegat(String t);
        public event schreibe_delegat schreibe_event;

        private String _eingabeText;

        public void schreibe_als_Thread(String t)
        {
            EingabeText = t;
        }

        public string EingabeText
        {
            get => _eingabeText;
            set { if (schreibe_event != null) schreibe_event(value ); _eingabeText = value ; }
        }

    }
}
