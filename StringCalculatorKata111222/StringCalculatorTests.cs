

namespace StringCalculatorKata111222;

[TestClass]
public class StringCalculatorTests
{
    [TestMethod]
    public void Add_EmptyString_ShouldReturn_Zero()
    {
        int expected = 0;

        int actual = StringCalculator.Add(string.Empty);

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Add_StringNumber_ShouldReturn_Number()
    {
        int expected = 5;

        int actual = StringCalculator.Add("5");

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Add_TwoNums_ShouldReturn_Sum()
    {
        int expected = 7;

        int actual = StringCalculator.Add("5,2");

        Assert.AreEqual(expected, actual);
    }
}
