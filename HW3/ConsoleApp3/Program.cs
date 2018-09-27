using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите сумму кредита:");
            double s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите проценты кредита:");
            double p = Convert.ToInt32(Console.ReadLine());
            double everymanth = s / 12;
            double summa = s;
            double sp = 0;
            for (int i = 1; i <= 12; i++)
            {
                double prosent = summa * (p / 100);
                Console.WriteLine(i+" месяц = "+(everymanth + prosent));
                summa -= everymanth;
                sp += prosent;
            }
            Console.WriteLine("Общая сумма выплат составит: "+(s+sp));
            Console.ReadKey();
        }
    }
}
