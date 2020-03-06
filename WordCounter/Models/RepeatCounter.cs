using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public static string Word { get; set; }
    public static string Sentence { get; set; }
    public static int Count { get; set; }
    public static Dictionary<string, string> Match { get; set; } = new Dictionary<string, string> {};

    public RepeatCounter(string word, string sentence)
    {
      Word = word;
      Sentence = sentence;
      Match[word] = sentence;
    }

    public static Dictionary<string, string> GetAll()
    {
      return Match;
    }

    public static bool CheckValidInput()
    {
      return false;
    }
  }
}
