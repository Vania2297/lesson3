using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите два числа: ");
            int sum = NewMethod();

            //Console.WriteLine("введите ожидаемый ответ");
            //int c = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("введите ожидаемый ответ");
                int c = Convert.ToInt32(Console.ReadLine());
                if (sum == c)
                {
                    Console.WriteLine("Правильно");
                    break;
                }
                else
                {
                    Console.WriteLine("Неправильно");
                    if (c < sum)
                    {
                        Console.WriteLine("Должно быть больше");
                    }
                    else
                    {
                        Console.WriteLine("Должно быть меньше");
                    }
                    Console.WriteLine("Осталось" + (3-i) + "попытки");
                }
            }
            Console.ReadKey();
        }

        private static int NewMethod()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            return sum;
        }
    }
}
