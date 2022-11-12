
namespace StringCalculatorKata111222;

public class StringCalculator
{
    private string _input = string.Empty;

    public int Add(string input)
    {
        _input = input;

        if(string.IsNullOrEmpty(_input))
            return 0;

        List<string> inputList = CalculatorHelper.FormatInput(_input);

        List<int> numberList = CalculatorHelper.CleanNumberList(inputList);

        return numberList.Sum();
    }
}
