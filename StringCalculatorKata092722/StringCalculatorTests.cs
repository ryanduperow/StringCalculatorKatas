

namespace StringCalculatorKata092722;

[TestClass]
public class StringCalculatorTests
{
    [TestMethod]
    public void Add_EmptyString_ShouldReturn_Zero()
    {
        StringCalculator sc = new StringCalculator();

        int expected = 0;

        int actual = sc.Add("");

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Add_StringNum_ShouldReturn_Num()
    {
        StringCalculator sc = new StringCalculator();

        int expected = 4;

        int actual = sc.Add("4");

        Assert.AreEqual(expected, actual);
    }
}
