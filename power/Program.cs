using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace power
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int power = Convert.ToInt32(Console.ReadLine());
            while (power < 20)
            {
                double result = Math.Pow(number, power);
                Console.WriteLine($"{number}^{power}={result}");
                power++;
            }
            Console.ReadLine();
        }
    }
}
