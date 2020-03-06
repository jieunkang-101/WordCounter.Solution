using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests : IDisposable
  {

    public void Dispose()
    {
      RepeatCounter.ClearAll();
    }

    [TestMethod]
    public void RepeatCounter_CreateInstance_NewInstance()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("test", "This is test");
      Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());
    }

    [TestMethod]
    public void GetAll_ResturnsMatches_MatchDictionary()
    {
      //Arrange
      string word = "test";
      string sentence = "This is test.";
      RepeatCounter newRepeatCounter = new RepeatCounter(word, sentence);
      Dictionary<string, string> newDictionary = new Dictionary<string, string> {{word, sentence}};

      //Act
      Dictionary<string, string> result = RepeatCounter.GetAll();

      //Assert
      CollectionAssert.AreEqual(newDictionary, result);
    }

    [TestMethod]
    public void CheckValidInput_CheckIfMatchesExist_False()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("this", "I'm walking to the cathedral with a cat.");

      //Act
      bool result = RepeatCounter.CheckValidInput();

      //Assert
      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void SearchWords_FindSingleChar_NumberOfMatches()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("a", "I'm walking to the cathedral with a cat.");
      
      //Act
      int result = RepeatCounter.SearchWords();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void SearchWords_FindMultiChar_NumberOfMatches()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("walking", "I'm walking to the cathedral with a cat.");
      
      //Act
      int result = RepeatCounter.SearchWords();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void SearchWords_FindMultipleIstance_NumberOfMatches()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("the", "I'm walking to the cathedral with the cat.");
      
      //Act
      int result = RepeatCounter.SearchWords();

      //Assert
      Assert.AreEqual(2, result);
    }

  }
}