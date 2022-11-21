using System;
using System.Collections.Generic;

Console.Write("Difficulty? (1 - easy, 2 - medium, 3 - hard, 4 - cheater: ");

int difficulty;
if (!int.TryParse(Console.ReadLine(), out difficulty))
{
    Console.WriteLine("Input integers only!!");
    return;
}
if (difficulty > 4 || difficulty < 1)
{
    Console.WriteLine("choose a number betwen 1 and 4");
    return;
}

List<int> difficulties = new List<int> { 8, 6, 4, 2 };
int numberOfGuesses = difficulties[difficulty - 1];


Console.WriteLine("Guess the Secret Number!");

int SecretNumber = new Random().Next(1, 101);

int guessesLeft = numberOfGuesses;
while (difficulty == 4 || guessesLeft > 0)
{
    Console.Write($"Your Guess (Guesses left: {(difficulty == 4 ? "INFINITE!!" : guessesLeft)}: ");
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
    guessesLeft--;
}

