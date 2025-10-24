using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {

        string[] input = new string[] { };

        string result = Orders.Order(input);

        Assert.That(result, Is.Empty);
    }


    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        string[] input = new string[] {"apple 6.00 2", "banana 3.75 1", "orange 1.98 1" };

        string expected = $"apple -> 12.00{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98";

        string result = Orders.Order(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        string[] input = new string[] { "apple 6 2", "banana 3 1", "orange 3 1" };

        string expected = $"apple -> 12.00{Environment.NewLine}banana -> 3.00{Environment.NewLine}orange -> 3.00";

        string result = Orders.Order(input);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        string[] input = new string[] { "apple 6.00 1.5", "banana 3.75 1.5", "orange 1.98 1.5" };

        string expected = $"apple -> 9.00{Environment.NewLine}banana -> 5.63{Environment.NewLine}orange -> 2.97";

        string result = Orders.Order(input);

        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void Test_Order_ZeroQuantities_ShouldReturnZeroPrice()
    {
        string[] input = new string[] { "apple 6.00 0", "banana 3.75 0", "orange 1.98 0" };

        string expected = $"apple -> 0.00{Environment.NewLine}banana -> 0.00{Environment.NewLine}orange -> 0.00";

        string result = Orders.Order(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_ZeroProductValue_ShouldReturnZeroPrice()
    {
        string[] input = new string[] { "apple 0.00 3", "banana 0 5", "orange 0 5" };

        string expected = $"apple -> 0.00{Environment.NewLine}banana -> 0.00{Environment.NewLine}orange -> 0.00";

        string result = Orders.Order(input);

        Assert.That(result, Is.EqualTo(expected));
    }
}
