

namespace StringCalculatorKata111222;

public static class StringCalculator
{
    private static string _input = string.Empty;

    public static int Add(string input)
    {
        _input = input;

        if(string.IsNullOrEmpty(_input))
            return 0;

        List<string> inputList = _input.Split(",").ToList();

        return inputList.Count == 2 ?
            int.Parse(inputList[0]) + int.Parse(inputList[1]) :
            int.Parse(inputList[0]);
    }
}
