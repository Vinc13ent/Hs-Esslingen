using System;

namespace Würfeln
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++) {
                for (int j = 1; j <= 6; j++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("(");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(i);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(",");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(j);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(") ");
                }
                Console.WriteLine();
            }
        }
    }
}
