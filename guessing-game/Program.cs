using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number");
            string UserGuess = Console.ReadLine();
            int ParsedGuess = int.Parse(UserGuess);
            Console.WriteLine(ParsedGuess);
        }
    }
}
