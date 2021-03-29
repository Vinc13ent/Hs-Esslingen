using System;

namespace Feld_umsortieren
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 2, 3, 5, 7, 11, 13, 17, 19 };
            int[] array2 = { 1, 2, 3, 4 };


            arrayprint(array1);
            umdrehen(array1);
            arrayprint(array1);

            arrayprint(array2);
            umdrehen(array2);
            arrayprint(array2);



            static void arrayprint(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            static int[] umdrehen(int[] array)
            {
                int j;
                for (int i = 0; i < array.Length / 2; i++)
                {
                    j = array[i];
                    array[i] = array[array.Length - 1 - i];
                    array[array.Length - 1 - i] = j;
                    
                }
                return array;
            }
        }
    }
}
