using System;

namespace Konfektionsgrößen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geschlecht M/W:");
            String gender = Console.ReadLine();
            Console.WriteLine("Brustumfang:");
            int u = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Körpergröße");
            int h = Convert.ToInt32(Console.ReadLine());
            int konfgr;
            if (gender.ToLower() == "m")
            {
                konfgr = u / 2;
                Console.WriteLine("Konfektionsgröse ist " + konfgr);
            }
            else
            {
                if (h >= 164 && h <= 170)
                {
                    konfgr = (u / 2) - 6;
                    Console.WriteLine("Konfektionsgröse ist " + konfgr);
                }
                else if (h > 170) 
                {
                    konfgr = ((u / 2) - 6) * 2;
                    Console.WriteLine("Konfektionsgröse ist " + konfgr);
                }
                else if (h < 164)
                {
                    konfgr = ((u / 2) - 6) / 2;
                    Console.WriteLine("Konfektionsgröse ist " + konfgr);
                }
            }
        }
    }
}
