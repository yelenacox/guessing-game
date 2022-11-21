using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int SecretNum = r.Next(1, 101);
            bool FoundNum = false;
            int UserTries = 4;



            while ((FoundNum != true) && (UserTries != 0))
            {
                Console.WriteLine("Guess the secret number.");
                string UserGuess = Console.ReadLine();
                int ParsedGuess = int.Parse(UserGuess);
                if (ParsedGuess == SecretNum)
                {
                    Console.WriteLine("Yes, that's the number!");
                    FoundNum = true;
                }
                else
                {
                    if (ParsedGuess > SecretNum)
                    {
                        Console.WriteLine("No, that's not the number." + "Your guess was higher than the secret number" + "Attempts remaining: " + UserTries--);
                        FoundNum = false;
                    }
                    else
                    {
                        Console.WriteLine("No, that's not the number." + "Your guess was lower than the secret number. " + "Attempts remaining: " + --UserTries);
                        FoundNum = false;
                    }
                }
            }
        }
    }
}

