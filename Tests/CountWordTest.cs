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
  }
}
