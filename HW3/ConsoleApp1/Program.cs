using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите радиус круга: ");
            double stepen = 2;
            double r = Convert.ToInt32(Console.ReadLine());
            double area = 3.14 * r ^ 2 + Math.Pow (stepen);   
            Console.WriteLine("площадь круга: "+area);
            Console.ReadKey();
        }
    }
}
