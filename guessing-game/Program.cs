using System;

Console.WriteLine("Guess the Secret Number!");

int SecretNumber = new Random().Next(1, 101);

for (int i = 1; i <= 4; i++)
{
    Console.Write($"Your Guess {(i)}: ");
    string answer = Console.ReadLine();
    if (SecretNumber == int.Parse(answer))
    {
        Console.WriteLine("Correct!");
        break;
    }
    else
    {
        Console.WriteLine("Nope!");
    }
}

