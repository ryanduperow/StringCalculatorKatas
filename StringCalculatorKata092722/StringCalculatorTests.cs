

namespace StringCalculatorKata092722;

[TestClass]
public class StringCalculatorTests
{

    // Step 1: Simple Calculator

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

    // Step 2: Arbitrary Number Size

    [TestMethod]
    public void Add_StringNums_ShouldReturn_Sum()
    {
        StringCalculator sc = new StringCalculator();

        int expected = 5;

        int actual = sc.Add("2,3");

        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow("2,3,5,7", 17)]
    [DataRow("2,3,57,605", 667)]
    [DataRow("0,3,22,33,66,122", 246)]
    [DataRow("2,4,7,9,11,22,18", 73)]
    public void Add_UnknownAmountOfNums_ShouldReturn_Sum(string input, int expected)
    {
        StringCalculator sc = new StringCalculator();

        int actual = sc.Add(input);

        Assert.AreEqual(expected, actual);
    }

    // Step 3: Newline Separator

    [TestMethod]
    public void Add_NewlineSeparator_ShouldReturn_Sum()
    {
        StringCalculator sc = new StringCalculator();

        int expected = 6;

        int actual = sc.Add("1\n2,3");

        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow("2\n3,5,7", 17)]
    [DataRow("2\n3,57\n605", 667)]
    [DataRow("0,3\n22\n33\n66,122", 246)]
    [DataRow("2,4\n7,9\n11,22\n18", 73)]
    public void Add_MultNewLineSeparator_ShouldReturn_Sum(string input, int expected)
    {
        StringCalculator sc = new StringCalculator();

        int actual = sc.Add(input);

        Assert.AreEqual(expected, actual);
    }
}
