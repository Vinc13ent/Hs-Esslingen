using System;

namespace Übungsaufgebe_Vorlesung2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ihr Gewicht in Kg.");
            String eingabe = Console.ReadLine();
            double weight = double.Parse(eingabe);

            Console.WriteLine("Ihr Größe in m.");
            eingabe = Console.ReadLine();
            double height = double.Parse(eingabe);

            double bmi = weight / (height * height);

            Console.WriteLine("Ihr BMI liegt bei " + bmi);
        }
    }
}
