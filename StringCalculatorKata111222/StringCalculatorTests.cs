﻿

namespace StringCalculatorKata111222;

[TestClass]
public class StringCalculatorTests
{
    private StringCalculator _sut;

    [TestInitialize]
    public void SetUp()
    {
        _sut = new StringCalculator();
    }

    [TestMethod]
    public void Add_EmptyString_ShouldReturn_Zero()
    {
        int expected = 0;

        int actual = _sut.Add(string.Empty);

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Add_StringNumber_ShouldReturn_Number()
    {
        int expected = 5;

        int actual = _sut.Add("5");

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Add_TwoNums_ShouldReturn_Sum()
    {
        int expected = 7;

        int actual = _sut.Add("5,2");

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Add_ArbitraryLengthNumList_ShouldReturn_Sum()
    {
        int expected = 26;

        int actual = _sut.Add("5,2,3,7,9");

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Add_NewlineSeparator_ShouldReturn_Sum()
    {
        int expected = 26;

        int actual = _sut.Add("5,2\n3,7\n9");

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Add_CustomSeparator_ShouldReturn_Sum()
    {
        int expected = 26;

        int actual = _sut.Add("//$\n5,2$3,7$9");

        Assert.AreEqual(expected, actual);
    }
}
