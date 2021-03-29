using System;

namespace Bruch
{
    class Program
    {
        static void Main(string[] args)
        {
            Bruch B1 = new Bruch();
            Bruch B2 = new Bruch(2);
            Bruch B3 = new Bruch(27, 6);


            Console.WriteLine("Original Bruch: " + B3.AlsString());
            B3.Kürze();
            Console.WriteLine("Gekürzter Bruch: " + B3.AlsString());
            B3.KehreUm();
            Console.WriteLine("Umkehrbruch: " + B3.AlsString());


        }
    }
}
