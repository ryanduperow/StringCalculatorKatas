

namespace StringCalculatorKata092722;

[TestClass]
public class StringCalculatorTests
{
    private StringCalculator sc = new StringCalculator();

    // Step 1: Simple Calculator

    [TestMethod]
    public void Add_EmptyString_ShouldReturn_Zero()
    {
        int expected = 0;

        int actual = sc.Add("");

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Add_StringNum_ShouldReturn_Num()
    {
        int expected = 4;

        int actual = sc.Add("4");

        Assert.AreEqual(expected, actual);
    }

    // Step 2: Arbitrary Number Size

    [TestMethod]
    public void Add_StringNums_ShouldReturn_Sum()
    {
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
        int actual = sc.Add(input);

        Assert.AreEqual(expected, actual);
    }

    // Step 3: Newline Separator

    [TestMethod]
    public void Add_NewlineSeparator_ShouldReturn_Sum()
    {
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
        int actual = sc.Add(input);

        Assert.AreEqual(expected, actual);
    }

    // Step 4: Custom Separators

    [TestMethod]
    public void Add_CustomSeparator_ShouldReturn_Sum()
    {
        int expected = 6;

        int actual = sc.Add("//;\n1\n2;3");

        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow("//;\n2;3;5,7", 17)]
    [DataRow("//?\n2,3?57?605", 667)]
    [DataRow("//$\n0,3$22$33,66$122", 246)]
    [DataRow("//@\n2@4@7,9,11@22@18", 73)]
    public void Add_MultCustomSeparator_ShouldReturn_Sum(string input, int expected)
    {
        int actual = sc.Add(input);

        Assert.AreEqual(expected, actual);
    }

    // Step 5: Disallow Negatives

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Add_NegativeNumber_ThrowsArgumentException()
    {
        sc.Add("-5");
    }

    [TestMethod]
    public void Add_NegativeNumber_ErrorMessageContainsNumber()
    {
        try
        {
            sc.Add("-5");
            Assert.Fail();
        }
        catch (ArgumentException e)
        {
            Assert.AreEqual("Negatives not allowed: -5", e.Message);
        }
    }

    [TestMethod]
    public void Add_MultNegativeNumber_ErrorMessageContainsNumber()
    {
        try
        {
            sc.Add("-5,3,-2,-10,22");
            Assert.Fail();
        }
        catch (ArgumentException e)
        {
            Assert.AreEqual("Negatives not allowed: -5 -2 -10", e.Message);
        }
    }

    // Step 6: Ignore Numbers bigger than 100

    [DataTestMethod]
    [DataRow("1000,2,3,5,7", 17)]
    [DataRow("2,3000,57,605", 664)]
    [DataRow("0,3,2200,33,66,1220", 102)]
    [DataRow("2000,4,7,999,11,22,1800", 1043)]
    public void Add_NumsGreaterThan1000_ShouldBeIgnored(string input, int expected)
    {
        int actual = sc.Add(input);

        Assert.AreEqual(expected, actual);
    }

}
