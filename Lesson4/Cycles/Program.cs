using System;

namespace comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter first number");
            int numberX = ReadNumberFromConsoleAndValidate();
            Console.WriteLine("Please, enter second number");
            int numberY = ReadNumberFromConsoleAndValidate();

            int diff;
            if (numberX > numberY)
            {
                diff = numberX - numberY;
                Console.WriteLine($"X more Y from {diff}");
            }
            else if (numberX < numberY)
            {
                diff = numberY - numberX;
                Console.WriteLine($"Y more X from {diff}");
            }
            else
            {
                Console.WriteLine("X equels Y");
            }

            Console.ReadLine();
        }

        private static int ReadNumberFromConsoleAndValidate()
        {
            int number;
            bool isSuccess;
            do
            {
                string input = Console.ReadLine();
                isSuccess = int.TryParse(input, out number);
                if (!isSuccess) 
                {
                    Console.WriteLine("You entered not valid number. Try again");
                }
                else if (number < 0)
                {
                    isSuccess = false;
                    Console.WriteLine("You entered number < 0. Try again");
                }
            } while (!isSuccess);

            return number;
        }
    }
}
