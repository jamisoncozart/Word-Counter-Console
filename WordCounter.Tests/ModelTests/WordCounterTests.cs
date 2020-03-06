using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;

namespace WordCounter.Models.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void RepeatCounter_CreatesNewInstanceOfWordCounterWithCorrectSearchWord_cat()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "This is my cat");
      Assert.AreEqual("cat", newCounter.SearchWord);
    }

    [TestMethod]
    public void RepeatCounter_CreatesNewInstanceOfWordCounterWithCorrectSentence_Thisismycat()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "This is my cat");
      Assert.AreEqual("This is my cat", newCounter.Sentence);
    }

    [TestMethod]
    public void IsValidateInput_CorrectlyReturnsFalseWhenNumbersArePresentInUserInput_false()
    {
      RepeatCounter newCounter = new RepeatCounter("cat1", "This is my cat");
      Assert.AreEqual(false, newCounter.IsValidateInput());
    }

    [TestMethod]
    public void IsValidateInput_CorrectlyReturnsTrueWhenNumbersArePresentInUserInput_true()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "This is my cat");
      Assert.AreEqual(true, newCounter.IsValidateInput());
    }

  }
}