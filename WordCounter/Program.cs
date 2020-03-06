using System;
using WordCounter.Models;

namespace WordCounter.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();
      RollText("Welcome to Word Counter Console!\n================================\n");
      bool valid = false;
      while(!valid)
      {
        RollText("Please enter a word you would like to search for: ");
        string searchWord = Console.ReadLine();
        RollText("Please enter a sentence to search for this word in: ");
        string searchSentence = Console.ReadLine();
        RepeatCounter newCounter = new RepeatCounter(searchWord, searchSentence);
        if(newCounter.IsValidInput())
        {
          int instancesOfWord = newCounter.InstancesOfWordInSentence();
          RollText($"'{searchWord}' is found {instancesOfWord} times in '{searchSentence}'");
          valid = true;
        }
        else
        {
          RollText("Invalid input! Please only use letters and punctuation.");
        }
      }
    }
    public static void RollText(string str)
    {
      for(int i = 0; i < str.Length; i++)
      {
        Console.Write(str[i]);
        System.Threading.Thread.Sleep(30);
      }
    }
  }

}