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

    public static void ClearAll()
    {
      Match.Clear();
    }

    public static Dictionary<string, string> GetAll()
    {
      return Match;
    }

    public static bool CheckValidInput()
    {
      if (Sentence.IndexOf(Word) != -1)
      {
        return true;
      }
      return false;
    }

    public static int SearchWords()
    {
      int count = 0;
      string wordCheck;
      string sentenceCheck;
      foreach (KeyValuePair<string, string> matches in Match)
      {
        string[] sentenceArr = matches.Value.Split(" ");
        for (int i = 0; i < sentenceArr.Length; i++)
        {
          wordCheck = matches.Key.ToLower();
          sentenceCheck = sentenceArr[i].ToLower();
          if (wordCheck == sentenceCheck)
          {
            count ++;
          }
        }
      }
      return count;
    }
  }
}
