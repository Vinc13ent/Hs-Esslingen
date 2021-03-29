using System;

namespace Umgang_mit_Feldern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 1
            int[] array1 = { 0, 3, 6, 9, 12, 15, 18, 21, 24, 27 };

            for (int i = 0; i <= array1.Length - 1; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();

            for (int i = array1.Length - 1; i >= 0; i--)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();

            //Aufgabe 2
            int[] array2 = new int[25];
            int j = 17;
            for (int i = 0; i < 25; i++)
            {
                
                array2[i] = j;
                j++;
            }

            for (int i = 0; i < 25; i++)
            {
                if (array2[i] % 2 != 0)
                {
                    Console.Write(array2[i] + " " );
                }
            }
            Console.WriteLine();
            for (int i = 25 - 1; i >= 0; i--)
            {
                if (array2[i] %2 == 0)
                {
                    Console.Write(array2[i] + " ");
                }
            }
            Console.WriteLine();

            // Aufgabe 3
            int[] array3 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < 8; i++)
            {
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();
            for ( int i = 0; i < 7; i++)
            {
                j = array3[i];
                array3[i] = array3[i + 1];
                array3[i + 1] = j;

            }
            for ( int i = 0; i < 8; i++)
            {
                Console.Write(array3[i] + " ");
            }
        }
    }
}
