using System;
using ScrabbleScore.Models;

namespace project
{
  public class project
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a word to get your Scrabble score:");
      string word = Console.ReadLine().ToLower();
      int score = Scrabble.AddScore(word);
      Console.WriteLine($"Your score is {score}.");
    }
  }
}