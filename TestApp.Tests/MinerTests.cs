using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] input = new string[] { };
        string result = Miner.Mine(input);

        string expected = $"didito -> 16{Environment.NewLine}cvetito -> 10";
        Assert.That(result, Is.Empty);

    }


    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {

        string[] input = new string[] { "DidiTo 5", "CveTitO 10", "didito 11" };
        string result = Miner.Mine(input);

        string expected = $"didito -> 16{Environment.NewLine}cvetito -> 10";
        Assert.That(result, Is.EqualTo(expected));
        
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        string[] input = new string[] { "DidiTo 5", "CveTitO 10", "tedito 11" };
        string result = Miner.Mine(input);

        string expected = $"didito -> 5{Environment.NewLine}cvetito -> 10{Environment.NewLine}tedito -> 11";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Mine_WithNegativeValues_ShouldReturnResourceCounts()
    {
        string[] input = new string[] { "DidiTo -5","didiTo -3", "CveTitO 10", "tedito 11" };
        string result = Miner.Mine(input);

        string expected = $"didito -> -8{Environment.NewLine}cvetito -> 10{Environment.NewLine}tedito -> 11";
        Assert.That(result, Is.EqualTo(expected));
    }
}
