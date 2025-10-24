using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] plants = {};
        string result = Plants.GetFastestGrowing(plants);

        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        string[] plants = { "lale" };
        string result = Plants.GetFastestGrowing(plants);
        string expected = $"Plants with 4 letters:{Environment.NewLine}lale";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        string[] plants = { "Tulip", "Gerber", "Nivalis"};
        string result = Plants.GetFastestGrowing(plants);
        string expected = $"Plants with 5 letters:{Environment.NewLine}Tulip{Environment.NewLine}" +
            $"Plants with 6 letters:{Environment.NewLine}Gerber{Environment.NewLine}" +
            $"Plants with 7 letters:{Environment.NewLine}Nivalis"; ;

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        string[] plants = { "TuLip", "GeRber", "NIvalIs" };
        string result = Plants.GetFastestGrowing(plants);
        string expected = $"Plants with 5 letters:{Environment.NewLine}TuLip{Environment.NewLine}" +
            $"Plants with 6 letters:{Environment.NewLine}GeRber{Environment.NewLine}" +
            $"Plants with 7 letters:{Environment.NewLine}NIvalIs"; 

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetFastestGrowing_SameFLowers_ShouldReturnAllOfThem()
    {
        string[] plants = { "TuLip", "TuLip", "NIvalIs" };
        string result = Plants.GetFastestGrowing(plants);
        string expected = $"Plants with 5 letters:{Environment.NewLine}TuLip{Environment.NewLine}TuLip" +
        $"{Environment.NewLine}Plants with 7 letters:{Environment.NewLine}NIvalIs";

        Assert.That(result, Is.EqualTo(expected));

    }
}
