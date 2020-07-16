using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public static class Scrabble
  {
    private static Dictionary<string, int> _letterScore = new Dictionary<string, int>
    {
      { "a", 1 }
    };

  public static int GetScore(string letter)
  {
    if (_letterScore.ContainsKey(letter))
    {
      return 0;
    }
    else
    {
      return 0;
    }

  } 
    
  }

}