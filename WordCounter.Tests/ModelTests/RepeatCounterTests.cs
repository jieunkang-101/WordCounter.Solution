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
  }
}