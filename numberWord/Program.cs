using System;

namespace NumberWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] letters = word.ToCharArray();

            int numberOfLetterA = 0;
            foreach (char letter in letters)
            {
                if (letter == 'a')
                {
                    numberOfLetterA++;
                }
            }

            Console.WriteLine($"In this word {numberOfLetterA} letter(s) 'a'");
            Console.ReadLine();
        }
    }
}
