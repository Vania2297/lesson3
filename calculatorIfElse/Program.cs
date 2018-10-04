using System;

namespace calculatorIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter in format: '1'(enter) '+' or '-' or '*' or '/'(enter) '2'(enter)");
            double numberOne = Convert.ToDouble(Console.ReadLine());
            char sign = Convert.ToChar(Console.ReadLine());
            double numberTwo = Convert.ToDouble(Console.ReadLine());
            if (sign == '+')
            {
                Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
            }
            else if (sign == '-')
            {
                Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
            }
            else if (sign == '*')
            {
                Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");
            }
            else if (sign == '/')
            {
                Console.WriteLine($"{numberOne} / {numberTwo} = {numberOne / numberTwo}");
            }
            Console.ReadLine();
        }
    }
}
