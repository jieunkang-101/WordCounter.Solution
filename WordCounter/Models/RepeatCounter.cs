using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public static string Word { get; set; }
    public static string Sentence { get; set; }
    
    public RepeatCounter(string word, string sentence)
    {
      Word = word;
      Sentence = sentence;
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
      string wordCheck = Word.ToLower();
      string sentenceCheck;
      char[] charsToTrim = {',', '.', '\'', '\"', ' ', '!', '?', ';', ':'};
      string[] sentenceArr = Sentence.Split(" ");
      
      for (int i = 0; i < sentenceArr.Length; i++)
      {
        sentenceCheck = sentenceArr[i].ToLower().Trim(charsToTrim);
        if (wordCheck == sentenceCheck)
        {
          count ++;
        }
        // Check for Apostrophe
        else if (wordCheck.Length > 1 && wordCheck + "\'s" == sentenceCheck || wordCheck +"\'m" == sentenceCheck || wordCheck +"\'re" == sentenceCheck || wordCheck +"\'t" == sentenceCheck || wordCheck +"\ve" == sentenceCheck || wordCheck +"\'ll" == sentenceCheck)
        {
          count ++;
        }
        // Check for Plural
        else if (wordCheck.Length > 1 && wordCheck + "s" == sentenceCheck  || wordCheck + "es" == sentenceCheck)
        {
          count ++;
        }
      }
      return count;
    }
  }
}
