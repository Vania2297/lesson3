using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"number {i} even");
                }
                else
                {
                    Console.WriteLine($"number {i} odd");
                }
            }
            Console.ReadLine();
        }
    }
}
