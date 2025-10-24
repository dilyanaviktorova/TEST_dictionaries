using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{

    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        List<int> nums = new List<int>();

        string result = Grouping.GroupNumbers(nums);

        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        List<int> nums = new List<int>() { 1, 5, 2 };

        string expected = $"Odd numbers: 1, 5{Environment.NewLine}Even numbers: 2";

        string result = Grouping.GroupNumbers(nums);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        List<int> nums = new List<int>() { 2, 4 };

        string expected = $"Even numbers: 2, 4";

        string result = Grouping.GroupNumbers(nums);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        List<int> nums = new List<int>() { 1, 5 };

        string expected = $"Odd numbers: 1, 5";

        string result = Grouping.GroupNumbers(nums);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        List<int> nums = new List<int>() { -1, -5, -2 };

        string expected = $"Odd numbers: -1, -5{Environment.NewLine}Even numbers: -2";

        string result = Grouping.GroupNumbers(nums);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithZero_ShouldReturnOnlyEvenGroupByZeroes()
    {
        List<int> nums = new List<int>() { 0, 0, 0 };

        string expected = $"Even numbers: 0, 0, 0";

        string result = Grouping.GroupNumbers(nums);

        Assert.That(result, Is.EqualTo(expected));

    }
}
