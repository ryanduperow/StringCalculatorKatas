
namespace StringCalculatorKata092722;

public class StringCalculator
{
    private string _input = string.Empty;

    public int Add(string input)
    {
        _input = input;

        if (string.IsNullOrEmpty(_input))
            return 0;

        var inputList = _input.Split(",").ToList();
        var numbers = inputList.Select(item => ConvertToNum(item)).ToList();

        return numbers.Sum() ;
    }

    private int ConvertToNum(string item)
    {
        return int.Parse(item);
    }
}
