using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter circle radius: ");
            string input = Console.ReadLine();
            double radius = Convert.ToDouble(input);
            double area = Math.Pow(Math.PI * radius, 2);
            Console.WriteLine("Circle area: " + area);
            Console.ReadKey();
        }
    }
}
