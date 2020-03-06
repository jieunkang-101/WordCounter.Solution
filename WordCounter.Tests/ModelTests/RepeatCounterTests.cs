using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {

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
    public void CheckValidInput_CheckIfMatchesExist_True()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("test", "This is test");

      //Act
      bool result = RepeatCounter.CheckValidInput();

      //Assert
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void SearchWords_FindSingleChar_NumberOfMatches()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("test", "This is test");

      //Act
      int result = RepeatCounter.SearchWords();

      //Assert
      Assert.AreEqual(1, result);
    }
  }
}