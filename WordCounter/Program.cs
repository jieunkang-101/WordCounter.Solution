using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter 
{
  public class Program
  {
    public static void Main()
    {
      CountWord();
      Continue();
    }

    public static void CountWord()
    {
      Console.Clear();
      Console.WriteLine("Welcome, please enter a sentence and a word to check the occurence of your word in your sentence.");
      Console.Write("Enter a sentence: ");
      string userSentence = Console.ReadLine().ToLower();
      Console.Write("Enter a word: ");
      string userWord = Console.ReadLine().ToLower();
      RepeatCounter newUserInput = new RepeatCounter(userWord, userSentence);

      if (RepeatCounter.CheckValidInput() == true)
      {
        Console.WriteLine($"Your word \"{userWord}\" appears {RepeatCounter.SearchWords()} times in your sentence.");
      }
      else 
      {
        Console.WriteLine($"Your word \"{userWord}\" does not exist in your sentence \"{userSentence}\"");
      }
    }

    public static void Continue()
    {
      Console.WriteLine("Would you like to check again? [Y or N]");
      string response = Console.ReadLine().ToLower();

      if (response == "y")
      {
        Main();
      }
      else if (response == "n")
      {
        Console.WriteLine("Thank you for using our program.");
      }
      else
      {
        Console.WriteLine("Please enter a valid input.");
        Continue();
      }
    }
  }
}