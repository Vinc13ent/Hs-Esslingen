using System;

namespace Kreis
{
    class Program
    {
        static void Main(string[] args)
        {
            Kreis K1 = new Kreis(5.0);
            Kreis K2 = new Kreis(1, 2, 5.0);

            double KreisUmfang = K1.BerechneUmfang();
            Console.WriteLine(KreisUmfang);
        }
    }
}
