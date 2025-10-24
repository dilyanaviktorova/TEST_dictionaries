using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] input = new string[] { };

        string result = OddOccurrences.FindOdd(input);
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        string[] input = new string[] { "didi", "didi", "tedi", "tedi" };
      
        string result = OddOccurrences.FindOdd(input);
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        string[] input = new string[] { "didi", "didi", "cveti", "tedi", "tedi" };
        string expected = "cveti";
        string result = OddOccurrences.FindOdd(input);
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        string[] input = new string[] { "didi", "didi", "cveti", "tedi", "tedi", "viki"};
        string expected = "cveti viki";
        string result = OddOccurrences.FindOdd(input);
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        string[] input = new string[] { "didi", "Didi", "Cveti", "Tedi", "tedi", "vIki" };
        string expected = "cveti viki";
        string result = OddOccurrences.FindOdd(input);
        Assert.That(result, Is.EqualTo(expected));
    }
}
