using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace archinator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("guess a number from 0 to 100");
            string answer;
            int num = 1;
            Console.WriteLine("answer yes or no");

            while ((num > 0) && (num < 100))
            {
                Console.WriteLine($"Is this number = {num}?");
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine($"you guess number {num}!!!");
                    break;
                }
                else
                {
                    num++;
                }
            }
            Console.ReadLine();

        }
    }
}
