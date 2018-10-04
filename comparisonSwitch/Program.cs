using System;

namespace comparisonSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number X");
            int x = ReadNumberFromConsole();

            Console.WriteLine("Please enter number Y");
            int y = ReadNumberFromConsole();

            int diff;

            switch (x)
            {
                case int n when n < y:
                    diff = y - n;
                    Console.WriteLine($"Y more X for {diff}");
                    break;
                case int n when n > y:
                    diff = n - y;
                    Console.WriteLine($"X more Y {diff}");
                    break;
                case int n when n == y:
                    Console.WriteLine("X equals Y");
                    break;
            }

            Console.ReadLine();
        }


        private static int ReadNumberFromConsole()
        {
            int number;
            bool isSuccess;
            do
            {
                // Enter number
                string input = Console.ReadLine();

                // Convertion and validation of number
                isSuccess = int.TryParse(input, out number);
                if (!isSuccess)
                {
                    Console.WriteLine("You entered invalid number. Try enter again");
                }
            } while (!isSuccess);

            return number;
        }
    }
}
