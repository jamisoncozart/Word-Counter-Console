using System;

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
    
    public bool IsValidateInput()
    {
      return true;
    }
  }

}