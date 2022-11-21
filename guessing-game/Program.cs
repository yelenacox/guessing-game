using System;
using System.Collections.Generic;

Console.Write("Difficulty? (1 - easy, 2 - medium, 3 - hard)");
int difficulty = int.Parse(Console.ReadLine());
List<int> difficulties = new List<int> { 8, 6, 4 };
int numberOfGuesses = difficulties[difficulty - 1];


Console.WriteLine("Guess the Secret Number!");

int SecretNumber = new Random().Next(1, 101);

for (int i = numberOfGuesses; i >= 1; i--)
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

