using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ampel_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Ampel _ampel = new Ampel();
            Auto a = new Auto(_ampel,"GP - LS 999");
            _ampel.ampelgruen += a.wach_auf; //Die Main Methode meldet das Auto an der Ampel an
            Auto b = new Auto(_ampel,"GP - IL 888");
            _ampel.ampelgruen += b.wach_auf;
        }
    }
}
