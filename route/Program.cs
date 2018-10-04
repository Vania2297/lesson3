using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace route
{
    class Program
    {
        static void Main(string[] args)
        {
            char route = moveToRoute();

            switch (route)
            {
                case 'a':
                    Console.WriteLine("move to left");
                    break;
                case 's':
                    Console.WriteLine("move to down");
                    break;
                case 'd':
                    Console.WriteLine("move to right");
                    break;
                case 'w':
                    Console.WriteLine("move to up");
                    break;
                default:
                    Console.WriteLine("wrong move");
                    break;
            }
            Console.ReadLine();
        }

        private static char moveToRoute()
        {
            Console.WriteLine("enter route move w, a, s, d");
            string routeInput = Console.ReadLine();
            char route = Convert.ToChar(routeInput);
            return route;
        }
    }
}
