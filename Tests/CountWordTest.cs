using System;
using System.Collections.Generic;
using Xunit;
using WordCounter.Objects;

namespace WordCounterTest
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountWord_CountsWordRepetedInString_True()
    {
      int count = 1;
      int result = RepeatCounter.CountRepeats("dog", "dog");
      Assert.Equal(count, result);
    }
    [Fact]
    public void CountWord_CountsWordRepetedInStringTwiceRetrunsTwo_True()
    {
      int count = 2;
      int result = RepeatCounter.CountRepeats("dog", "My dog loves to play with my friend's dogdog dog");
      Assert.Equal(count, result);
    }
    [Fact]
    public void CountWord_CountsWordsWithCaseInsensitivity_True()
    {
      int count = 1;
      int result = RepeatCounter.CountRepeats("dog", "dOg");
      Assert.Equal(count, result);
    }
    [Fact]
    public void CountWord_CountsWordsWithDelimiters_True()
    {
      int count = 1;
      int result = RepeatCounter.CountRepeats("dog", "dog!");
      Assert.Equal(count, result);
    }
    [Fact]
    public void CountWord_CountReturnsZero_True()
    {
      int count = 0;
      int result = RepeatCounter.CountRepeats("dog", "cat");
      Assert.Equal(count, result);
    }
  }
}
