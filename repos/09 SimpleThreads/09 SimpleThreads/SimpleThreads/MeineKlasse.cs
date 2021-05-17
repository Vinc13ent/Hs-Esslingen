using System;
using System.Threading;
namespace SimpleThreads
{
    class MeineKlasse
    {
        public void meineMethode(Object o)
        {
            int grenze = Int32.Parse(o.ToString());
            //grenze = o as int;
            for (int i = 0; i < grenze; i++)
            {
                Console.WriteLine("Ich bin der neue Thread...");
                Thread.Sleep(1000);
            }
        }
    }
}
