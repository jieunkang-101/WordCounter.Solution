using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
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

    [TestMethod]
    public void SearchWords_FindFullWordMatchesOnly_NumberOfMatches()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("cat", "I'm walking to the cathedral with my cat Misty.");
      
      //Act
      int result = RepeatCounter.SearchWords();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void SearchWords_IgnoreLetterCase_NumberOfMatches()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("Cat", "I'm walking to the cathedral with my cAT Misty.");
      
      //Act
      int result = RepeatCounter.SearchWords();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void SearchWords_IgnorePunctuation_NumberOfMatches()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("cat", "I'm walking to the cathedral with my cat? cat! cat.!!");
      
      //Act
      int result = RepeatCounter.SearchWords();

      //Assert
      Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void SearchWords_IgnoreApostrophe_NumberOfMatches()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("I", "I'm walking to the cathedral with my cat. I'll be home soon.");
      
      //Act
      int result = RepeatCounter.SearchWords();

      //Assert
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void SearchWords_CheckSingularToPlural_NumberOfMatches()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("cat", "I'm walking to the cathedral with my cats. One cat is running after birds.");
      
      //Act
      int result = RepeatCounter.SearchWords();

      //Assert
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void SearchWords_CheckPluralToSingular_NumberOfMatches()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("cats", "I'm walking to the cathedral with my cats. One cat is running after birds.");
      
      //Act
      int result = RepeatCounter.SearchWords();

      //Assert
      Assert.AreEqual(1, result);
    }


  }
}