using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char ch = 'z'; ch >= 'a'; ch--)
            {
                Console.WriteLine(ch);
            }
            Console.ReadLine();
        }
    }
}
