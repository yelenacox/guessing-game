using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int SecretNum = 42;
            bool FoundNum = false;
            int UserTries = 0;


            while ((FoundNum != true) && (UserTries < 4))
            {
                Console.WriteLine("Guess the secret number. " + "Your Guess" + "(" + ++UserTries + ")");
                string UserGuess = Console.ReadLine();
                int ParsedGuess = int.Parse(UserGuess);
                if (ParsedGuess == SecretNum)
                {
                    Console.WriteLine("Yes, that's the number!");
                    FoundNum = true;
                }
                else
                {
                    Console.WriteLine("No, that's not the number");
                    FoundNum = false;
                }
            }
        }
    }
}

