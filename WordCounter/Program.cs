using System;
using WordCounter.Models;
using System.Threading;

public class Program
{
  public static void Main()
  {
    Console.Clear();
    ValidateInputLoop();
  }
  
  public static void ValidateInputLoop()
  {
    bool valid = false;
    while(!valid)
    {
      RollText("Welcome to Word Counter Console!\n================================\n");
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
        RollText("Invalid input! Please only use letters and punctuation.\n");
        Thread.Sleep(500);
        Console.Clear();
      }
    }
  }

  public static void RollText(string str)
  {
    for(int i = 0; i < str.Length; i++)
    {
      Console.Write(str[i]);
      Thread.Sleep(30);
    }
  }

}