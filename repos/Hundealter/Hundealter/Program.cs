using System;

namespace Hundealter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alter des Hundes");
            float hAlter = float.Parse(Console.ReadLine());
            Console.WriteLine("Gewicht des Hundes");
            float hRasse = float.Parse(Console.ReadLine());
            float hAlterInMenschenJahren;
            if (hRasse < 15)
            {
                if (hAlter <= 1)
                {
                    hAlterInMenschenJahren = 20 * hAlter;
                }
                else if (hAlter <= 2)
                {
                    hAlterInMenschenJahren = 20 + (8 * (hAlter - 1));
                }
                else
                {
                    hAlterInMenschenJahren = 28 + (4 * (hAlter - 2));
                }
            }
            else if (hRasse > 15 && hRasse < 45)
            {
                if (hAlter <= 1)
                {
                    hAlterInMenschenJahren = 18 * hAlter;
                }
                else if (hAlter <= 2)
                {
                    hAlterInMenschenJahren = 18 + (9 * (hAlter - 1));
                }
                else
                {
                    hAlterInMenschenJahren = 27 + (6 * (hAlter - 2));
                }
            }
            else
            {
                if (hAlter <= 1)
                {
                    hAlterInMenschenJahren = 14 * hAlter;
                }
                else if (hAlter <= 2)
                {
                    hAlterInMenschenJahren = 14 + (8 * (hAlter - 1));
                }
                else
                {
                    hAlterInMenschenJahren = 22 + (9 * (hAlter - 2));
                }
            }
            Console.WriteLine("Das Alter umgerechnet in Menschenjahre beträgt: " + hAlterInMenschenJahren);
        }
    }
}
