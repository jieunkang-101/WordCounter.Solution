using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string Word { get; set; }
    public string Sentence { get; set; }
    public int Count { get; set; }
    public static Dictionary<string, string> Match { get; set; } = new Dictionary<string, string> {};

    public RepeatCounter(string word, string sentence)
    {
      Word = word;
      Sentence = sentence;
      Match[word] = sentence;
    }
  }
}
