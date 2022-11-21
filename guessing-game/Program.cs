using System;

Console.WriteLine("Guess the Secret Number!");

int SecretNumber = new Random().Next(1, 101);
Console.WriteLine(SecretNumber);
for (int i = 4; i >= 1; i--)
{
    Console.Write($"Your Guess (Guesses left: {i}): ");
    int answer = int.Parse(Console.ReadLine());
    if (SecretNumber == answer)
    {
        Console.WriteLine("Correct!");
        break;
    }
    else
    {
        Console.WriteLine(SecretNumber > answer ? "too low!" : "too high!");
    }
}

