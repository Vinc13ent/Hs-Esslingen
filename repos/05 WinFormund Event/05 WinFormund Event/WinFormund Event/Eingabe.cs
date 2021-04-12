using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormund_Event
{
    class Eingabe
    {
        public delegate void schreibe_delegat(String t);
        public event schreibe_delegat schreibe_event;
        
        private String _eingabeText;

        public string EingabeText { 
            get => _eingabeText+ " Euro";
            set  {  _eingabeText = value; if (schreibe_event != null) schreibe_event(EingabeText);} }
    }
}
