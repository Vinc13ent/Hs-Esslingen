using System;

namespace MaximumVonDreiZahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Erste Zahl bitte ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zwiete Zahl bitte ");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Drite Zahl bitte ");
            float num3 = float.Parse(Console.ReadLine());
            float biggest;
            if (num1 >= num2)
            {
                biggest = num1;
            }
            else
            {
                biggest = num2;
            }
            if (biggest > num3)
            {
                Console.WriteLine(biggest + " ist die größte Zahl");
            }
            else
            {
                Console.WriteLine(num3 + " ist die größte Zahl");
            }
        }
    }
}
