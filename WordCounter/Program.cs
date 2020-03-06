using System;
using WordCounter.Models;

namespace WordCounter.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();
      Console.WriteLine("Welcome to Word Counter Console!\n================================");
      bool valid = false;
      while(!valid)
      {
        Console.Write("Please enter a word you would like to search for: ");
        string searchWord = Console.ReadLine();
        Console.Write("Please enter a sentence to search for this word in: ");
        string searchSentence = Console.ReadLine();
        RepeatCounter newCounter = new RepeatCounter(searchWord, searchSentence);
        if(newCounter.IsValidInput())
        {
          int instancesOfWord = newCounter.InstancesOfWordInSentence();
          Console.WriteLine($"'{searchWord}' is found {instancesOfWord} times in '{searchSentence}'");
          valid = true;
        }
        else
        {
          Console.WriteLine("Invalid input! Please only use letters and punctuation.");
        }
      }

    }
  }

}