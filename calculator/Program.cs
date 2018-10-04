using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two numbers");
            double numberOne = Convert.ToDouble(Console.ReadLine());
            double numberTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter operation '+' or '-' or '*' or '/'");
            char sign = Convert.ToChar(Console.ReadLine());
            switch (sign)
            {
                case '+':
                    double result = numberOne + numberTwo;
                    Console.WriteLine($"{numberOne} + {numberTwo} = {result}");
                    break;
                case '-':
                    double result1 = numberOne - numberTwo;
                    Console.WriteLine($"{numberOne} - {numberTwo} = {result1}");
                    break;
                case '*':
                    double result2 = numberOne * numberTwo;
                    Console.WriteLine($"{numberOne} * {numberTwo} = {result2}");
                    break;
                case '/':
                    double result3 = numberOne / numberTwo;
                    Console.WriteLine($"{numberOne} / {numberTwo} = {result3}");
                    break;
                default:
                    Console.WriteLine("you enter wrong number or operation");
                    break;
            }
            Console.ReadLine();
        }
    }
}
