using System;

namespace WordOpposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any word");
            string word = Console.ReadLine();
            char[] letters = word.ToCharArray();

            for (int i = letters.Length - 1; i >= 0; i--)
            {
                Console.Write(letters[i]);
            }

            Console.ReadLine();
        }
    }
}
