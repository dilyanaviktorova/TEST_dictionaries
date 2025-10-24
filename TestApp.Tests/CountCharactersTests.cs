using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
      
        List<string> input = new();

        string result = CountCharacters.Count(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        List<string> input = new List<string>() {};

        string result = CountCharacters.Count(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {

        List<string> input = new List<string>()
        {
            "H"
        };

        string result = CountCharacters.Count(input);

        string expected = "H -> 1";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {

        List<string> input = new List<string>()
        {
            "Hello", "Lo"
        };

        string result = CountCharacters.Count(input);

        string expected = $"H -> 1{Environment.NewLine}e -> 1{Environment.NewLine}l -> 2{Environment.NewLine}o -> 2{Environment.NewLine}L -> 1";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        List<string> input = new List<string>()
        {
            "!@!!"
        };

        string result = CountCharacters.Count(input);

        string expected = $"! -> 3{Environment.NewLine}@ -> 1";

        Assert.That(result, Is.EqualTo(expected));

    }
}
