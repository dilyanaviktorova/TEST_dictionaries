using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{

    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        int[] nums = { };
       
        string result = CountRealNumbers.Count(nums);

        Assert.That(result, Is.Empty);

    }

        [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        int[] nums = { 1 };
        string expected = $"1 -> 1";

        string result = CountRealNumbers.Count(nums);

        Assert.IsTrue(result.Equals(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        int[] nums = { 1, 2, 3, 1, 1 };
        string expected = $"1 -> 3{Environment.NewLine}2 -> 1{Environment.NewLine}3 -> 1";

        string result = CountRealNumbers.Count(nums);

        Assert.IsTrue(result.Equals(expected));

    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        int[] nums = { -1, -2, -3, -1, -1 };
        string expected = $"-3 -> 1{Environment.NewLine}-2 -> 1{Environment.NewLine}-1 -> 3";

        string result = CountRealNumbers.Count(nums);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        int[] nums = { 0, 0, 0, 0, 0 };
        string expected = $"0 -> 5";

        string result = CountRealNumbers.Count(nums);

        Assert.IsTrue(result.Equals(expected));
    }
}
