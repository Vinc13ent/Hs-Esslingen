using System;

namespace Schaltjahr_Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jahr bitte");
            float year = float.Parse(Console.ReadLine());
            if ((year % 100) == 0)
            {
                if ((year % 400) == 0)
                {
                    Console.WriteLine(year + " ist ein Schaltjahr.");
                }
                else
                {
                    Console.WriteLine(year + " ist kein Schaltjahr.");
                }
            }else if ((year % 4 ) == 0)
            {
                Console.WriteLine(year + " ist ein Schaltjahr.");
            }
            else
            {
                Console.WriteLine(year + " ist kein Schaltjahr");
            }
        }
    }
}
