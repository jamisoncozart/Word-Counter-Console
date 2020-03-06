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
      Assert.AreEqual(false, newCounter.IsValidInput());
    }

    [TestMethod]
    public void IsValidInput_CorrectlyReturnsTrueWhenNumbersArePresentInUserInput_true()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "This is my cat");
      Assert.AreEqual(true, newCounter.IsValidInput());
    }

    [TestMethod]
    public void InstancesOfWordInSentence_CorrectlyReturnsInstancesOfWordInSentence_1()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "This is my cat");
      Assert.AreEqual(1, newCounter.InstancesOfWordInSentence());
    }

    [TestMethod]
    public void InstancesOfWordInSentence_CorrectlyReturnsInstancesOfWordInSentence_3()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "This is my cat I love my cat my cat is fluffy.");
      Assert.AreEqual(3, newCounter.InstancesOfWordInSentence());
    }

    [TestMethod]
    public void InstancesOfWordInSentence_DoesNotCountInstancesOfWordWithinOtherWords_1()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "This is my cat cathedral");
      Assert.AreEqual(1, newCounter.InstancesOfWordInSentence());
    }

    [TestMethod]
    public void InstancesOfWordInSentence_WordCountAgnosticToCapitalAndLowercase_2()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "This is my CAT cat");
      Assert.AreEqual(2, newCounter.InstancesOfWordInSentence());
    }

    [TestMethod]
    public void InstancesOfWordInSentence_WordCountAgnosticToPunctuation_3()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "This is my cat, He is a fat !cat; I love my fat cat.");
      Assert.AreEqual(3, newCounter.InstancesOfWordInSentence());
    }

  }
}