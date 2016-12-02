using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    public static int CountRepeats(string Word, string Sentence)
    {
      int wordCounter = 0;
      string sentenceString = "";
      foreach (char delimeter in Sentence)
      {
        if (!char.IsPunctuation(delimeter))
        {
          sentenceString += delimeter;
        }
      }
      sentenceString = sentenceString.ToLower();
      string[] sentenceArray = sentenceString.Split(' ');
      foreach (string word in sentenceArray)
      {
        if (word == Word)
        {
          wordCounter++;
        }
      };
      return wordCounter;
    }
  }
}
