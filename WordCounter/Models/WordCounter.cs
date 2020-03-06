using System;
using System.Linq;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string SearchWord { get; set; }
    public string Sentence { get; set; }
    public RepeatCounter(string word, string sentence)
    {
      SearchWord = word;
      Sentence = sentence;
    }
    
    public bool IsValidInput()
    {
      return !(SearchWord.Any(char.IsDigit) || Sentence.Any(char.IsDigit));
    }

    public int InstancesOfWordInSentence()
    {
      string[] words = Sentence.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' });
      var wordMatches = from word in words
                        where word.ToLower() == SearchWord.ToLower()
                        select word;
      return wordMatches.Count();
    }
  }

}